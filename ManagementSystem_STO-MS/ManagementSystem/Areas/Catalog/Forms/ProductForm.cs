using System;
using System.Linq;
using System.Windows.Forms;
using ManagementSystem.Common;
using ManagementSystem.Database;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Shared.Interfaces;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Main;
using ManagementSystem.Properties;

namespace ManagementSystem.Catalog
{
    public partial class ProductForm : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private int productID;
        private ProductRepository ProductRepository;

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

        public ProductForm(Form main)
        {
            productID = -1;
            ProductRepository = new ProductRepository();
            MainForm = main as MainForm;

            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ViewProductListingTab();
        }

        private void ProductForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && productID == -1)
            {
                ProductGrid.ClearSelection();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new ProductFilter
            {
                ID = FilterIDTextBox.Text.AsInt(),
                Name = FilterNameTextBox.Text,
                Scale = FilterScaleTextBox.Text.AsShort()
            };

            ProductGrid.DataSource = ProductRepository.GetProducts(filter);
            ProductGrid.ClearSelection();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ViewProductDetailTab(productID = 0);
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

            if (productID > 0)
            {
                var product = ProductRepository.GetProduct(productID);

                product.Name = NameTextBox.Text;
                product.Scale = (short)ScaleTextBox.Text.AsShort();

                ProductRepository.UpdateProduct(product);
                ProductRepository.Commit();
            }
            else
            {
                var product = new Product
                {
                    ID = (int)IDTextBox.Text.AsInt(),
                    Name = NameTextBox.Text,
                    Scale = (short)ScaleTextBox.Text.AsShort()
                };

                ProductRepository.InsertProduct(product);
                ProductRepository.Commit();

                productID = product.ID;
            }

            ViewProductDetailTab(productID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProductErrorProvider.Clear();

            if (productID > 0)
            {
                ViewProductDetailTab(productID);
            }
            else
            {
                ViewProductListingTab();

                productID = -1;

                ProductGrid.ClearSelection();
            }
        }

        private void AddComponentButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ComponentPopup>().Count() < 1)
            {
                ComponentPopup ComponentPopup = new ComponentPopup(productID, MainForm);
                ComponentPopup.FormClosed += new FormClosedEventHandler(ComponentPopupClosed);
                ComponentPopup.ShowDialog();
            }
        }

        private void RemoveComponentButton_Click(object sender, EventArgs e)
        {
            var componentIDs = ComponentGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (int)x.Cells[ComponentGrid_ID.Name].Value.AsInt())
                .ToList();

            ProductRepository.RemoveComponents(productID, componentIDs);
            ProductRepository.Commit();

            ViewProductDetailTab(productID);
        }

        private void ComponentPopupClosed(object sender, FormClosedEventArgs e)
        {
            ViewProductDetailTab(productID);
        }

        private void ProductGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                productID = (ProductGrid.CurrentRow.DataBoundItem as ProductData).ID;

                ViewProductDetailTab(productID);
            }
        }

        private void ProductTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == DetailTab && productID == -1)
            {
                e.Cancel = true;
            }

        }

        private void ProductTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductErrorProvider.Clear();

            if (ProductTabControl.SelectedTab == ListingTab)
            {
                RibbonMode = RibbonMode.Listing;
            }
            else if (ProductTabControl.SelectedTab == DetailTab)
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

        private void ComponentGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (ComponentGrid.SelectedRows.Count > 0 && !IsWork)
            {
                RemoveComponentButton.Enabled = true;
            }
            else
            {
                RemoveComponentButton.Enabled = false;
            }
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            ComponentGrid.SelectAll();
        }

        private void ViewProductListingTab()
        {
            IsWork = false;

            ChangeControlsEnabled(DetailTab.Controls, false, true);

            ProductTabControl.SelectedTab = ListingTab;
        }

        private void ViewProductDetailTab(int id)
        {
            if (id > 0)
            {
                IsWork = false;
                RibbonMode = RibbonMode.Detail;

                ChangeControlsEnabled(DetailTab.Controls, false, false);

                var product = ProductRepository.GetProduct(id);

                IDTextBox.Text = product.ID.ToString();
                NameTextBox.Text = product.Name.ToString();
                ScaleTextBox.Text = product.Scale.ToString();

                ComponentGrid.DataSource = ProductRepository.GetComponents(id);

                ProductTabControl.SelectedTab = DetailTab;

                ComponentGrid.ClearSelection();
            }
            else
            {
                IsWork = true;
                RibbonMode = RibbonMode.Edit;

                ChangeControlsEnabled(DetailTab.Controls, true, true);

                ProductTabControl.SelectedTab = DetailTab;
            }
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            switch (mode)
            {
                case RibbonMode.Listing:
                    FilterButton.Enabled = true;
                    NewButton.Enabled = true;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    AddComponentButton.Enabled = false;
                    break;
                case RibbonMode.Detail:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = true;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    AddComponentButton.Enabled = true;
                    break;
                case RibbonMode.Edit:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = true;
                    CancelButton.Enabled = true;
                    AddComponentButton.Enabled = false;
                    RemoveComponentButton.Enabled = false;
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

        private void IDTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IDTextBox.Enabled)
            {
                using (var repository = new ProductRepository())
                {
                    if (IDTextBox.Text.IsNullOrWhiteSpace())
                    {
                        ProductErrorProvider.SetError(IDTextBox, Resources.ValidationMandatory);
                        e.Cancel = true;
                    }
                    else if (IDTextBox.Text.AsInt() == null)
                    {
                        ProductErrorProvider.SetError(IDTextBox, Resources.ValidationInteger);
                        e.Cancel = true;
                    }
                    else if (repository.GetProduct((int)IDTextBox.Text.AsInt()) != null)
                    {
                        ProductErrorProvider.SetError(IDTextBox, Resources.ValidationNumberExists.FormatWith(IDTextBox.Text));
                        e.Cancel = true;
                    }
                    else
                    {
                        ProductErrorProvider.SetError(IDTextBox, "");
                    }
                }
            }
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (NameTextBox.Text.IsNullOrWhiteSpace())
            {
                ProductErrorProvider.SetError(NameTextBox, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else if (NameTextBox.Text.Length > 50)
            {
                ProductErrorProvider.SetError(NameTextBox, Resources.ValidationLength.FormatWith(50));
                e.Cancel = true;
            }
            else
            {
                ProductErrorProvider.SetError(NameTextBox, "");
            }
        }

        private void ScaleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ScaleTextBox.Text.IsNullOrWhiteSpace())
            {
                ProductErrorProvider.SetError(ScaleTextBox, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else if (ScaleTextBox.Text.AsShort() == null)
            {
                ProductErrorProvider.SetError(ScaleTextBox, Resources.ValidationShort);
                e.Cancel = true;
            }
            else
            {
                ProductErrorProvider.SetError(ScaleTextBox, "");
            }
        }
    }
}
