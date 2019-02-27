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
    public partial class InventoryForm : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private bool _isInventoryItemChanged;
        private int inventoryID;

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

        private bool IsInventoryItemChanged
        {
            get { return _isInventoryItemChanged; }
            set
            {
                _isInventoryItemChanged = value;
                SaveInventoryItemButton.Enabled = _isInventoryItemChanged;
            }
        }

        public InventoryForm(Form main)
        {
            inventoryID = -1;
            MainForm = main as MainForm;

            InitializeComponent();

            DatePicker.InitializeDatePickers(new List<DateTimePicker> { FilterEnteredFromDatePicker, FilterEnteredToDatePicker, EnteredDatePicker });
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            ViewInventoryListingTab();

            ClearControl(FilterEnteredFromDatePicker);
            ClearControl(FilterEnteredToDatePicker);
        }

        private void InventoryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && inventoryID == -1)
            {
                InventoryGrid.ClearSelection();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new InventoryFilter
            {
                ID = FilterIDTextBox.Text.AsInt(),
                ComponentID = (FilterComponentDropDown.SelectedValue.AsInt() == 0) ? null : FilterComponentDropDown.SelectedValue.AsInt(),
                EnteredFrom = (FilterEnteredFromDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterEnteredFromDatePicker.Value.Date.AsDateTime(),
                EnteredTo = (FilterEnteredToDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterEnteredToDatePicker.Value.Date.AsDateTime(),
                IsNotApprovedOnly = FilterIsNotApprovedOnlyCheckBox.Checked
            };

            using (var repository = new InventoryRepository())
            {
                InventoryGrid.DataSource = repository.GetInventories(filter);
            }

            InventoryGrid.ClearSelection();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ViewInventoryDetailTab(inventoryID = 0, true);
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

            using (var repository = new InventoryRepository())
            {
                if (inventoryID > 0)
                {
                    var inventory = repository.GetInventory(inventoryID);

                    inventory.Entered = EnteredDatePicker.Value.Date;

                    repository.UpdateInventory(inventory);
                    repository.Commit();

                    inventoryID = inventory.ID;
                }
                else
                {
                    var inventory = new Inventory
                    {
                        ID = (int)IDTextBox.Text.AsInt(),
                        Entered = EnteredDatePicker.Value.Date
                    };

                    repository.InsertInventory(inventory);
                    repository.Commit();

                    inventoryID = inventory.ID;
                }
            }

            ViewInventoryDetailTab(inventoryID, false);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            InventoryErrorProvider.Clear();

            if (inventoryID > 0)
            {
                ViewInventoryDetailTab(inventoryID, false);
            }
            else
            {
                ViewInventoryListingTab();

                inventoryID = -1;

                InventoryGrid.ClearSelection();
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (IsInventoryItemChanged)
            {
                result = MessageBox.Show(Resources.InventoryApproveUnsavedItemsText.FormatWith(inventoryID), Resources.InventoryApproveConfirmationCaption, MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveInventoryItemButton_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            else
            {
                result = MessageBox.Show(Resources.InventoryApproveConfirmationText.FormatWith(inventoryID), Resources.InventoryApproveConfirmationCaption, MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;
            }

            using (var repository = new InventoryRepository())
            {
                repository.ApproveInventory(inventoryID);
                repository.CalculateComponentStockQuantity(inventoryID);
                repository.Commit();
            }

            ViewInventoryDetailTab(inventoryID, true);
        }

        private void AddInventoryItemButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<InventoryItemPopup>().Count() < 1)
            {
                InventoryItemPopup InventoryItemPopup = new InventoryItemPopup(inventoryID, MainForm);
                InventoryItemPopup.FormClosed += new FormClosedEventHandler(InventoryItemPopupClosed);
                InventoryItemPopup.ShowDialog();
            }
        }

        private void RemoveInventoryItemButton_Click(object sender, EventArgs e)
        {
            var inventoryItemOrders = InventoryItemGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (short)x.Cells[InventoryItemGrid_Order.Name].Value.AsShort())
                .ToList();

            using (var repository = new InventoryRepository())
            {
                repository.RemoveInventoryItems(inventoryID, inventoryItemOrders);
                repository.Commit();
            }

            ViewInventoryDetailTab(inventoryID, true);
        }

        private void SaveInventoryItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InventoryItemGrid.Rows)
            {
                short order = (short)row.Cells[InventoryItemGrid_Order.Name].Value.AsShort();

                using (var repository = new InventoryRepository())
                {
                    var inventoryItem = repository.GetInventoryItem(inventoryID, order);

                    inventoryItem.ActualQuantity = (int)row.Cells[InventoryItemGrid_ActualQuantity.Name].Value.AsInt();

                    repository.UpdateInventoryItem(inventoryItem);
                    repository.Commit();
                }
            }

            ViewInventoryDetailTab(inventoryID, true);
        }

        private void InventoryItemPopupClosed(object sender, FormClosedEventArgs e)
        {
            ViewInventoryDetailTab(inventoryID, true);
        }

        private void InventoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                inventoryID = (InventoryGrid.CurrentRow.DataBoundItem as InventoryData).ID;

                ViewInventoryDetailTab(inventoryID, true);
            }
        }

        private void InventoryTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == DetailTab && inventoryID == -1)
            {
                e.Cancel = true;
            }

        }

        private void InventoryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryErrorProvider.Clear();

            if (InventoryTabControl.SelectedTab == ListingTab)
            {
                RibbonMode = RibbonMode.Listing;
            }
            else if (InventoryTabControl.SelectedTab == DetailTab)
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

        private void InventoryItemGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (InventoryItemGrid.SelectedRows.Count > 0 && !IsWork)
            {
                RemoveInventoryItemButton.Enabled = true;
            }
            else
            {
                RemoveInventoryItemButton.Enabled = false;
            }
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            InventoryItemGrid.SelectAll();
        }

        private void ViewInventoryListingTab()
        {
            IsWork = false;

            using (var repository = new ComponentRepository())
            {
                var dropDown = repository.GetComponentsForDropDown();
                dropDown.Insert(0, new KeyValuePair<int, string>());

                FilterComponentDropDown.DataSource = dropDown;
            }

            ChangeControlsEnabled(DetailTab.Controls, false, true);

            InventoryTabControl.SelectedTab = ListingTab;
        }

        private void ViewInventoryDetailTab(int id, bool isInventoryItemIncluded)
        {
            using (var repository = new InventoryRepository())
            {
                if (id > 0)
                {
                    IsWork = false;
                    RibbonMode = RibbonMode.Detail;

                    ChangeControlsEnabled(DetailTab.Controls, false, false);

                    var inventory = repository.GetInventory(id);

                    IDTextBox.Text = inventory.ID.ToString();
                    if (inventory.IsApproved)
                        EnteredDatePicker.ResetMinDate();
                    else
                        EnteredDatePicker.MinDate = repository.GetMinEntered();
                    EnteredDatePicker.Value = inventory.Entered;

                    if (isInventoryItemIncluded)
                    {
                        InventoryItemGrid.DataSource = repository.GetInventoryItems(id);
                        IsInventoryItemChanged = false;
                        InventoryItemGrid.Enabled = !inventory.IsApproved;
                    }

                    InventoryTabControl.SelectedTab = DetailTab;

                    InventoryItemGrid.ClearSelection();
                }
                else
                {
                    IsWork = true;
                    RibbonMode = RibbonMode.Edit;

                    ChangeControlsEnabled(DetailTab.Controls, true, true);

                    IDTextBox.Enabled = false;
                    IDTextBox.Text = repository.GetNextInventoryID().ToString();
                    EnteredDatePicker.MinDate = repository.GetMinEntered();

                    InventoryTabControl.SelectedTab = DetailTab;
                }
            }
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            bool isApproved;

            if (inventoryID > 0)
                using (var repository = new InventoryRepository())
                {
                    isApproved = repository.GetInventory(inventoryID).IsApproved;
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
                    AddInventoryItemButton.Enabled = false;
                    break;
                case RibbonMode.Detail:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = !isApproved;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    ApproveButton.Enabled = !isApproved;
                    AddInventoryItemButton.Enabled = !isApproved;
                    SaveInventoryItemButton.Enabled = IsInventoryItemChanged;
                    break;
                case RibbonMode.Edit:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = true;
                    CancelButton.Enabled = true;
                    ApproveButton.Enabled = false;
                    AddInventoryItemButton.Enabled = false;
                    RemoveInventoryItemButton.Enabled = false;
                    SaveInventoryItemButton.Enabled = false;
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

        private void EnteredDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (EnteredDatePicker.Format == DateTimePickerFormat.Custom)
            {
                InventoryErrorProvider.SetError(EnteredDatePicker, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else
            {
                InventoryErrorProvider.SetError(EnteredDatePicker, "");
            }
        }

        private void InventoryItemGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (InventoryItemGrid.CurrentCell.ColumnIndex == InventoryItemGrid.Columns[InventoryItemGrid_ActualQuantity.Name].Index)
            {
                if (InventoryItemGrid.CurrentCell.EditedFormattedValue.ToString().AsInt() == null)
                {
                    SaveInventoryItemButton.Enabled = false;
                    e.Cancel = true;
                }
                else
                {
                    InventoryItemGrid.CurrentCell.ErrorText = string.Empty;
                    if (InventoryItemGrid.CurrentCell.Value.ToString() != InventoryItemGrid.CurrentCell.EditedFormattedValue.ToString())
                    {
                        InventoryItemGrid.CurrentCell.Style.ForeColor = Color.Red;
                        IsInventoryItemChanged |= true;
                    }
                }
            }
        }

        private void InventoryItemGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == InventoryItemGrid.Columns[InventoryItemGrid_ActualQuantity.Name].Index)
            {
                DataGridViewRow row = InventoryItemGrid.Rows[e.RowIndex];
                int stockQuantity = (int)row.Cells[InventoryItemGrid_StockQuantity.Name].Value.ToString().AsInt();
                int actualQuantity = (int)row.Cells[InventoryItemGrid_ActualQuantity.Name].Value.ToString().AsInt();

                row.Cells[InventoryItemGrid_TotalDifference.Name].Value = actualQuantity - stockQuantity;
            }
        }

        private void InventoryItemGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (InventoryItemGrid.CurrentCell.ColumnIndex == InventoryItemGrid.Columns[InventoryItemGrid_ActualQuantity.Name].Index)
            {
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    var cell = e.Control as DataGridViewTextBoxEditingControl;
                    //cell.KeyDown -= InventoryItemGrid_KeyDown;
                    //cell.PreviewKeyDown -= InventoryItemGrid_PreviewKeyDown;
                    //cell.KeyDown += InventoryItemGrid_KeyDown;
                    //cell.PreviewKeyDown += InventoryItemGrid_PreviewKeyDown;
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
                InventoryItemGrid.CurrentCell.ErrorText = Resources.ValidationInteger;
                SaveInventoryItemButton.Enabled = false;
            }
            else
            {
                InventoryItemGrid.CurrentCell.ErrorText = string.Empty;
                SaveInventoryItemButton.Enabled = IsInventoryItemChanged;
            }
        }

        private void InventoryItemGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            InventoryItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 18, 0);
        }

        private void InventoryItemGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            InventoryItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 0, 0);
        }

        private void InventoryItemGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        //private void InventoryItemGrid_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (InventoryItemGrid.CurrentCell.RowIndex == InventoryItemGrid.Rows.Count - 1)
        //        {
        //            e.SuppressKeyPress = true;
        //            InventoryItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}

        //private void InventoryItemGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (InventoryItemGrid.CurrentCell.RowIndex == InventoryItemGrid.Rows.Count - 1)
        //        {
        //            InventoryItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}
    }
}
