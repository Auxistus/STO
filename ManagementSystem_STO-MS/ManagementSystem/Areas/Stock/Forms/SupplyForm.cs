using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.BusinessLogic.Stock;
using ManagementSystem.Common;
using ManagementSystem.Database;
using ManagementSystem.Main;
using ManagementSystem.Properties;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Shared.Interfaces;
using System.Drawing.Drawing2D;

namespace ManagementSystem.Stock
{
    public partial class SupplyForm : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private bool _isSupplyItemChanged;
        private int supplyID;

        private bool IsWork { get; set; }
        private MainForm MainForm;

        public RibbonMode RibbonMode
        {
            get { return _ribbonMode; }
            set
            {
                _ribbonMode = value;
                SetRibbonButtons(_ribbonMode);
            }
        }

        private bool IsSupplyItemChanged
        {
            get { return _isSupplyItemChanged; }
            set
            {
                _isSupplyItemChanged = value;
                SaveSupplyItemButton.Enabled = _isSupplyItemChanged;
            }
        }

        public SupplyForm(Form main)
        {
            supplyID = -1;
            MainForm = main as MainForm;

            InitializeComponent();

            DatePicker.InitializeDatePickers(new List<DateTimePicker> { FilterDeliveredFromDatePicker, FilterDeliveredToDatePicker, DeliveredDatePicker });
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            ViewSupplyListingTab();

            ClearControl(FilterDeliveredFromDatePicker);
            ClearControl(FilterDeliveredToDatePicker);
        }

        private void SupplyForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && supplyID == -1)
            {
                SupplyGrid.ClearSelection();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new SupplyFilter
            {
                ID = FilterIDTextBox.Text.AsInt(),
                SupplierName = FilterSupplierNameTextBox.Text,
                ComponentID = (FilterComponentDropDown.SelectedValue.AsInt() == 0) ? null : FilterComponentDropDown.SelectedValue.AsInt(),
                DeliveredFrom = (FilterDeliveredFromDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterDeliveredFromDatePicker.Value.Date.AsDateTime(),
                DeliveredTo = (FilterDeliveredToDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterDeliveredToDatePicker.Value.Date.AsDateTime(),
                IsNotApprovedOnly = FilterIsNotApprovedOnlyCheckBox.Checked
            };

            using (var repository = new SupplyRepository())
            {
                SupplyGrid.DataSource = repository.GetSupplies(filter);
            }

            SupplyGrid.ClearSelection();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ViewSupplyDetailTab(supplyID = 0, true);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IsWork = true;
            RibbonMode = RibbonMode.Edit;

            ChangeControlsEnabled(DetailTab.Controls, true, false);
            IDTextBox.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Validation.IsAllValid(Detail.Controls))
                return;

            using (var repository = new SupplyRepository())
            {
                if (supplyID > 0)
                {
                    var supply = repository.GetSupply(supplyID);

                    supply.Delivered = DeliveredDatePicker.Value.Date;
                    supply.SupplierName = SupplierNameTextBox.Text;
                    supply.Description = DescriptionTextBox.Text;

                    repository.UpdateSupply(supply);
                    repository.Commit();

                    supplyID = supply.ID;
                }
                else
                {
                    var supply = new Supply
                    {
                        ID = (int)IDTextBox.Text.AsInt(),
                        Delivered = DeliveredDatePicker.Value.Date,
                        SupplierName = SupplierNameTextBox.Text,
                        Description = DescriptionTextBox.Text
                    };

                    repository.InsertSupply(supply);
                    repository.Commit();

                    supplyID = supply.ID;
                }
            }

            ViewSupplyDetailTab(supplyID, false);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SupplyErrorProvider.Clear();

            if (supplyID > 0)
            {
                ViewSupplyDetailTab(supplyID, false);
            }
            else
            {
                ViewSupplyListingTab();

                supplyID = -1;

                SupplyGrid.ClearSelection();
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (IsSupplyItemChanged)
            {
                result = MessageBox.Show(Resources.SupplyApproveUnsavedItemsText.FormatWith(supplyID), Resources.SupplyApproveConfirmationCaption, MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveSupplyItemButton_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            else
            {
                result = MessageBox.Show(Resources.SupplyApproveConfirmationText.FormatWith(supplyID), Resources.SupplyApproveConfirmationCaption, MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;
            }

            using (var repository = new SupplyRepository())
            {
                repository.ApproveSupply(supplyID);
                repository.CalculateComponentStockQuantity(supplyID);
                repository.Commit();
            }

            ViewSupplyDetailTab(supplyID, true);
        }

        private void AddSupplyItemButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SupplyItemPopup>().Count() < 1)
            {
                SupplyItemPopup SupplyItemPopup = new SupplyItemPopup(supplyID, MainForm);
                SupplyItemPopup.FormClosed += new FormClosedEventHandler(SupplyItemPopupClosed);
                SupplyItemPopup.ShowDialog();
            }
        }

        private void RemoveSupplyItemButton_Click(object sender, EventArgs e)
        {
            var supplyItemOrders = SupplyItemGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (short)x.Cells[SupplyItemGrid_Order.Name].Value.AsShort())
                .ToList();

            using (var repository = new SupplyRepository())
            {
                repository.RemoveSupplyItems(supplyID, supplyItemOrders);
                repository.Commit();
            }

            ViewSupplyDetailTab(supplyID, true);
        }

        private void SaveSupplyItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SupplyItemGrid.Rows)
            {
                short order = (short)row.Cells[SupplyItemGrid_Order.Name].Value.AsShort();

                using (var repository = new SupplyRepository())
                {
                    var supplyItem = repository.GetSupplyItem(supplyID, order);

                    supplyItem.Quantity = (int)row.Cells[SupplyItemGrid_Quantity.Name].Value.AsInt();

                    repository.UpdateSupplyItem(supplyItem);
                    repository.Commit();
                }
            }

            ViewSupplyDetailTab(supplyID, true);
        }

        private void SupplyItemPopupClosed(object sender, FormClosedEventArgs e)
        {
            ViewSupplyDetailTab(supplyID, true);
        }

        private void SupplyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                supplyID = (SupplyGrid.CurrentRow.DataBoundItem as SupplyData).ID;

                ViewSupplyDetailTab(supplyID, true);
            }
        }

        private void SupplyTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == DetailTab && supplyID == -1)
            {
                e.Cancel = true;
            }

        }

        private void SupplyTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplyErrorProvider.Clear();

            if (SupplyTabControl.SelectedTab == ListingTab)
            {
                RibbonMode = RibbonMode.Listing;
            }
            else if (SupplyTabControl.SelectedTab == DetailTab)
            {
                if (IsWork)
                {
                    RibbonMode = RibbonMode.Edit;
                }
                else
                {
                    RibbonMode = RibbonMode.Detail;
                }
            }

        }

        private void SupplyItemGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (SupplyItemGrid.SelectedRows.Count > 0 && !IsWork)
            {
                RemoveSupplyItemButton.Enabled = true;
            }
            else
            {
                RemoveSupplyItemButton.Enabled = false;
            }
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            SupplyItemGrid.SelectAll();
        }

        private void ViewSupplyListingTab()
        {
            IsWork = false;

            using (var repository = new ComponentRepository())
            {
                var dropDown = repository.GetComponentsForDropDown();
                dropDown.Insert(0, new KeyValuePair<int, string>());

                FilterComponentDropDown.DataSource = dropDown;
            }

            ChangeControlsEnabled(DetailTab.Controls, false, true);

            SupplyTabControl.SelectedTab = ListingTab;
        }

        private void ViewSupplyDetailTab(int id, bool isSupplyItemIncluded)
        {
            using (var repository = new SupplyRepository())
            {
                if (id > 0)
                {
                    IsWork = false;
                    RibbonMode = RibbonMode.Detail;

                    ChangeControlsEnabled(DetailTab.Controls, false, false);

                    var supply = repository.GetSupply(id);

                    IDTextBox.Text = supply.ID.ToString();
                    DeliveredDatePicker.Value = supply.Delivered;
                    SupplierNameTextBox.Text = supply.SupplierName;
                    DescriptionTextBox.Text = supply.Description;

                    if (isSupplyItemIncluded)
                    {
                        SupplyItemGrid.DataSource = repository.GetSupplyItems(id);
                        IsSupplyItemChanged = false;
                        SupplyItemGrid.Enabled = !supply.IsApproved;
                    }

                    SupplyTabControl.SelectedTab = DetailTab;

                    SupplyItemGrid.ClearSelection();
                }
                else
                {
                    IsWork = true;
                    RibbonMode = RibbonMode.Edit;

                    ChangeControlsEnabled(DetailTab.Controls, true, true);

                    IDTextBox.Enabled = false;
                    IDTextBox.Text = repository.GetNextSupplyID().ToString();

                    SupplyTabControl.SelectedTab = DetailTab;
                }
            }
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            bool isApproved;

            if (supplyID > 0)
                using (var repository = new SupplyRepository())
                {
                    isApproved = repository.GetSupply(supplyID).IsApproved;
                }

            else
                isApproved = false;

            switch (mode)
            {
                case RibbonMode.Listing:
                    FilterButton.Enabled = true;
                    NewButton.Enabled = true;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    ApproveButton.Enabled = false;
                    AddSupplyItemButton.Enabled = false;
                    break;
                case RibbonMode.Detail:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = !isApproved;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    ApproveButton.Enabled = !isApproved;
                    AddSupplyItemButton.Enabled = !isApproved;
                    SaveSupplyItemButton.Enabled = IsSupplyItemChanged;
                    break;
                case RibbonMode.Edit:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = true;
                    CancelButton.Enabled = true;
                    ApproveButton.Enabled = false;
                    AddSupplyItemButton.Enabled = false;
                    RemoveSupplyItemButton.Enabled = false;
                    SaveSupplyItemButton.Enabled = false;
                    break;
            }
        }

        public bool HasUnsavedWork()
        {
            return IsWork;
        }

        public void DiscardUnsavedWork()
        {
            throw new NotImplementedException();
        }

        private void DeliveredDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DeliveredDatePicker.Format == DateTimePickerFormat.Custom)
            {
                SupplyErrorProvider.SetError(DeliveredDatePicker, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else
            {
                SupplyErrorProvider.SetError(DeliveredDatePicker, "");
            }
        }

        private void SupplierNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SupplierNameTextBox.Text.IsNullOrWhiteSpace())
            {
                SupplyErrorProvider.SetError(SupplierNameTextBox, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else if (SupplierNameTextBox.Text.Length > 50)
            {
                SupplyErrorProvider.SetError(SupplierNameTextBox, Resources.ValidationLength.FormatWith(50));
                e.Cancel = true;
            }
            else
            {
                SupplyErrorProvider.SetError(SupplierNameTextBox, "");
            }
        }

        private void SupplyItemGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (SupplyItemGrid.CurrentCell.ColumnIndex == SupplyItemGrid.Columns[SupplyItemGrid_Quantity.Name].Index)
            {
                if (SupplyItemGrid.CurrentCell.EditedFormattedValue.ToString().AsInt() == null)
                {
                    SaveSupplyItemButton.Enabled = false;
                    e.Cancel = true;
                }
                else
                {
                    SupplyItemGrid.CurrentCell.ErrorText = string.Empty;
                    if (SupplyItemGrid.CurrentCell.Value.ToString() != SupplyItemGrid.CurrentCell.EditedFormattedValue.ToString())
                    {
                        SupplyItemGrid.CurrentCell.Style.ForeColor = Color.Red;
                        IsSupplyItemChanged |= true;
                    }
                }
            }
        }

        private void SupplyItemGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (SupplyItemGrid.CurrentCell.ColumnIndex == SupplyItemGrid.Columns[SupplyItemGrid_Quantity.Name].Index)
            {
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    var cell = e.Control as DataGridViewTextBoxEditingControl;
                    //cell.KeyDown -= SupplyItemGrid_KeyDown;
                    //cell.PreviewKeyDown -= SupplyItemGrid_PreviewKeyDown;
                    //cell.KeyDown += SupplyItemGrid_KeyDown;
                    //cell.PreviewKeyDown += SupplyItemGrid_PreviewKeyDown;
                    cell.TextChanged -= cell_TextChanged;
                    cell.TextChanged += cell_TextChanged;
                }
            }
        }

        private void cell_TextChanged(object sender, EventArgs e)
        {
            var cell = sender as TextBox;

            if (cell.Text.AsInt() == null)
            {
                SupplyItemGrid.CurrentCell.ErrorText = Resources.ValidationInteger;
                SaveSupplyItemButton.Enabled = false;
            }
            else
            {
                SupplyItemGrid.CurrentCell.ErrorText = string.Empty;
                SaveSupplyItemButton.Enabled = IsSupplyItemChanged;
            }
        }

        private void SupplyItemGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SupplyItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 18, 0);
        }

        private void SupplyItemGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SupplyItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 0, 0);
        }

        private void SupplyItemGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All &
                        ~(DataGridViewPaintParts.ErrorIcon));

            if (e.ErrorText.IsNotNullOrEmpty())
            {
                GraphicsContainer container = e.Graphics.BeginContainer();
                e.Graphics.TranslateTransform(e.CellStyle.Padding.Right, 0);
                e.Paint(e.CellBounds, DataGridViewPaintParts.ErrorIcon);
                e.Graphics.EndContainer(container);
            }

            e.Handled = true;
        }

        //private void SupplyItemGrid_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (SupplyItemGrid.CurrentCell.RowIndex == SupplyItemGrid.Rows.Count - 1)
        //        {
        //            e.SuppressKeyPress = true;
        //            SupplyItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}

        //private void SupplyItemGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (SupplyItemGrid.CurrentCell.RowIndex == SupplyItemGrid.Rows.Count - 1)
        //        {
        //            SupplyItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}
    }
}
