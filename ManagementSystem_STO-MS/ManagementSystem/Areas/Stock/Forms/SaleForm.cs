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
    public partial class SaleForm : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private bool _isSaleItemChanged;
        private int saleID;

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

        private bool IsSaleItemChanged
        {
            get { return _isSaleItemChanged; }
            set
            {
                _isSaleItemChanged = value;
                SaveSaleItemButton.Enabled = _isSaleItemChanged;
            }
        }

        public SaleForm(Form main)
        {
            saleID = -1;
            MainForm = main as MainForm;

            InitializeComponent();

            DatePicker.InitializeDatePickers(new List<DateTimePicker> { FilterSoldFromDatePicker, FilterSoldToDatePicker, SoldDatePicker });
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            ViewSaleListingTab();

            ClearControl(FilterSoldFromDatePicker);
            ClearControl(FilterSoldToDatePicker);
        }

        private void SaleForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && saleID == -1)
            {
                SaleGrid.ClearSelection();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new SaleFilter
            {
                ID = FilterIDTextBox.Text.AsInt(),
                CustomerName = FilterCustomerNameTextBox.Text,
                ProductID = (FilterProductDropDown.SelectedValue.AsInt() == 0) ? null : FilterProductDropDown.SelectedValue.AsInt(),
                SoldFrom = (FilterSoldFromDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterSoldFromDatePicker.Value.Date.AsDateTime(),
                SoldTo = (FilterSoldToDatePicker.Format == DateTimePickerFormat.Custom) ? null : FilterSoldToDatePicker.Value.Date.AsDateTime(),
                IsNotApprovedOnly = FilterIsNotApprovedOnlyCheckBox.Checked
            };

            using (var repository = new SaleRepository())
            {
                SaleGrid.DataSource = repository.GetSales(filter);
            }

            SaleGrid.ClearSelection();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ViewSaleDetailTab(saleID = 0, true);
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

            using (var repository = new SaleRepository())
            {
                if (saleID > 0)
                {
                    var sale = repository.GetSale(saleID);

                    sale.Sold = SoldDatePicker.Value.Date;
                    sale.CustomerName = CustomerNameTextBox.Text;

                    repository.UpdateSale(sale);
                    repository.Commit();

                    saleID = sale.ID;
                }
                else
                {
                    var sale = new Sale
                    {
                        ID = (int)IDTextBox.Text.AsInt(),
                        Sold = SoldDatePicker.Value.Date,
                        CustomerName = CustomerNameTextBox.Text
                    };

                    repository.InsertSale(sale);
                    repository.Commit();

                    saleID = sale.ID;
                }
            }

            ViewSaleDetailTab(saleID, false);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SaleErrorProvider.Clear();

            if (saleID > 0)
            {
                ViewSaleDetailTab(saleID, false);
            }
            else
            {
                ViewSaleListingTab();

                saleID = -1;

                SaleGrid.ClearSelection();
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if (IsSaleItemChanged)
            {
                result = MessageBox.Show(Resources.SaleApproveUnsavedItemsText.FormatWith(saleID), Resources.SaleApproveConfirmationCaption, MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveSaleItemButton_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            else
            {
                result = MessageBox.Show(Resources.SaleApproveConfirmationText.FormatWith(saleID), Resources.SaleApproveConfirmationCaption, MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;
            }

            using (var repository = new SaleRepository())
            {
                repository.ApproveSale(saleID);
                repository.CalculateComponentStockQuantity(saleID);
                repository.Commit();
            }

            ViewSaleDetailTab(saleID, true);
        }

        private void AddSaleItemButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SaleItemPopup>().Count() < 1)
            {
                SaleItemPopup SaleItemPopup = new SaleItemPopup(saleID, MainForm);
                SaleItemPopup.FormClosed += new FormClosedEventHandler(SaleItemPopupClosed);
                SaleItemPopup.ShowDialog();
            }
        }

        private void RemoveSaleItemButton_Click(object sender, EventArgs e)
        {
            var saleItemOrders = SaleItemGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (short)x.Cells[SaleItemGrid_Order.Name].Value.AsShort())
                .ToList();

            using (var repository = new SaleRepository())
            {
                repository.RemoveSaleItems(saleID, saleItemOrders);
                repository.Commit();
            }

            ViewSaleDetailTab(saleID, true);
        }

        private void SaveSaleItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SaleItemGrid.Rows)
            {
                short order = (short)row.Cells[SaleItemGrid_Order.Name].Value.AsShort();

                using (var repository = new SaleRepository())
                {
                    var saleItem = repository.GetSaleItem(saleID, order);

                    saleItem.Quantity = (int)row.Cells[SaleItemGrid_Quantity.Name].Value.AsInt();

                    repository.UpdateSaleItem(saleItem);
                    repository.Commit();
                }
            }

            ViewSaleDetailTab(saleID, true);
        }

        private void SaleItemPopupClosed(object sender, FormClosedEventArgs e)
        {
            ViewSaleDetailTab(saleID, true);
        }

        private void SaleGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                saleID = (SaleGrid.CurrentRow.DataBoundItem as SaleData).ID;

                ViewSaleDetailTab(saleID, true);
            }
        }

        private void SaleTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == DetailTab && saleID == -1)
            {
                e.Cancel = true;
            }

        }

        private void SaleTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaleErrorProvider.Clear();

            if (SaleTabControl.SelectedTab == ListingTab)
            {
                RibbonMode = RibbonMode.Listing;
            }
            else if (SaleTabControl.SelectedTab == DetailTab)
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

        private void SaleItemGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (SaleItemGrid.SelectedRows.Count > 0 && !IsWork)
            {
                RemoveSaleItemButton.Enabled = true;
            }
            else
            {
                RemoveSaleItemButton.Enabled = false;
            }
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            SaleItemGrid.SelectAll();
        }

        private void ViewSaleListingTab()
        {
            IsWork = false;

            using (var repository = new ProductRepository())
            {
                var dropDown = repository.GetProductsForDropDown();
                dropDown.Insert(0, new KeyValuePair<int, string>());

                FilterProductDropDown.DataSource = dropDown;
            }

            ChangeControlsEnabled(DetailTab.Controls, false, true);

            SaleTabControl.SelectedTab = ListingTab;
        }

        private void ViewSaleDetailTab(int id, bool isSaleItemIncluded)
        {
            using (var repository = new SaleRepository())
            {
                if (id > 0)
                {
                    IsWork = false;
                    RibbonMode = RibbonMode.Detail;

                    ChangeControlsEnabled(DetailTab.Controls, false, false);

                    var sale = repository.GetSale(id);

                    IDTextBox.Text = sale.ID.ToString();
                    SoldDatePicker.Value = sale.Sold;
                    CustomerNameTextBox.Text = sale.CustomerName;

                    if (isSaleItemIncluded)
                    {
                        SaleItemGrid.DataSource = repository.GetSaleItems(id);
                        IsSaleItemChanged = false;
                        SaleItemGrid.Enabled = !sale.IsApproved;
                    }

                    SaleTabControl.SelectedTab = DetailTab;

                    SaleItemGrid.ClearSelection();
                }
                else
                {
                    IsWork = true;
                    RibbonMode = RibbonMode.Edit;

                    ChangeControlsEnabled(DetailTab.Controls, true, true);

                    IDTextBox.Enabled = false;
                    IDTextBox.Text = repository.GetNextSaleID().ToString();

                    SaleTabControl.SelectedTab = DetailTab;
                }
            }
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            bool isApproved;

            if (saleID > 0)
                using (var repository = new SaleRepository())
                {
                    isApproved = repository.GetSale(saleID).IsApproved;
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
                    AddSaleItemButton.Enabled = false;
                    break;
                case RibbonMode.Detail:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = !isApproved;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    ApproveButton.Enabled = !isApproved;
                    AddSaleItemButton.Enabled = !isApproved;
                    SaveSaleItemButton.Enabled = IsSaleItemChanged;
                    break;
                case RibbonMode.Edit:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = true;
                    CancelButton.Enabled = true;
                    ApproveButton.Enabled = false;
                    AddSaleItemButton.Enabled = false;
                    RemoveSaleItemButton.Enabled = false;
                    SaveSaleItemButton.Enabled = false;
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

        private void SoldDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SoldDatePicker.Format == DateTimePickerFormat.Custom)
            {
                SaleErrorProvider.SetError(SoldDatePicker, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else
            {
                SaleErrorProvider.SetError(SoldDatePicker, "");
            }
        }

        private void CustomerNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CustomerNameTextBox.Text.Length > 50)
            {
                SaleErrorProvider.SetError(CustomerNameTextBox, Resources.ValidationLength.FormatWith(50));
                e.Cancel = true;
            }
            else
            {
                SaleErrorProvider.SetError(CustomerNameTextBox, "");
            }
        }

        private void SaleItemGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (SaleItemGrid.CurrentCell.ColumnIndex == SaleItemGrid.Columns[SaleItemGrid_Quantity.Name].Index)
            {
                if (SaleItemGrid.CurrentCell.EditedFormattedValue.ToString().AsInt() == null)
                {
                    SaveSaleItemButton.Enabled = false;
                    e.Cancel = true;
                }
                else
                {
                    SaleItemGrid.CurrentCell.ErrorText = string.Empty;
                    if (SaleItemGrid.CurrentCell.Value.ToString() != SaleItemGrid.CurrentCell.EditedFormattedValue.ToString())
                    {
                        SaleItemGrid.CurrentCell.Style.ForeColor = Color.Red;
                        IsSaleItemChanged |= true;
                    }
                }
            }
        }

        private void SaleItemGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (SaleItemGrid.CurrentCell.ColumnIndex == SaleItemGrid.Columns[SaleItemGrid_Quantity.Name].Index)
            {
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    var cell = e.Control as DataGridViewTextBoxEditingControl;
                    //cell.KeyDown -= SaleItemGrid_KeyDown;
                    //cell.PreviewKeyDown -= SaleItemGrid_PreviewKeyDown;
                    //cell.KeyDown += SaleItemGrid_KeyDown;
                    //cell.PreviewKeyDown += SaleItemGrid_PreviewKeyDown;
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
                SaleItemGrid.CurrentCell.ErrorText = Resources.ValidationInteger;
                SaveSaleItemButton.Enabled = false;
            }
            else
            {
                SaleItemGrid.CurrentCell.ErrorText = string.Empty;
                SaveSaleItemButton.Enabled = IsSaleItemChanged;
            }
        }

        private void SaleItemGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SaleItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 18, 0);
        }

        private void SaleItemGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaleItemGrid.CurrentCell.Style.Padding = new Padding(0, 0, 0, 0);
        }

        private void SaleItemGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        //private void SaleItemGrid_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (SaleItemGrid.CurrentCell.RowIndex == SaleItemGrid.Rows.Count - 1)
        //        {
        //            e.SuppressKeyPress = true;
        //            SaleItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}

        //private void SaleItemGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //    {
        //        if (SaleItemGrid.CurrentCell.RowIndex == SaleItemGrid.Rows.Count - 1)
        //        {
        //            SaleItemGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //        }
        //    }
        //}
    }
}
