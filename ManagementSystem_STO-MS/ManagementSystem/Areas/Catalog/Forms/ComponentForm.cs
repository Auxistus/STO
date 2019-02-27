using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManagementSystem.Common;
using ManagementSystem.Database;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Shared.Interfaces;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Properties;
using ManagementSystem.Main;

namespace ManagementSystem.Catalog
{
    public partial class ComponentForm : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private int componentID;
        private ComponentRepository ComponentRepository;

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

        public ComponentForm(Form main)
        {
            componentID = -1;
            ComponentRepository = new ComponentRepository();
            MainForm = main as MainForm;

            InitializeComponent();
            ProductGrid.AutoGenerateColumns = false;
        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            ViewComponentListingTab();
        }

        private void ComponentForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && componentID == -1)
            {
                ComponentGrid.ClearSelection();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new ComponentFilter
            {
                ComponentTypeID = (FilterComponentTypeDropDown.SelectedValue.AsByte() == 0) ? null : FilterComponentTypeDropDown.SelectedValue.AsByte(),
                Name = FilterNameTextBox.Text,
                ProductID = (FilterProductDropDown.SelectedValue.AsInt() == 0) ? null : FilterProductDropDown.SelectedValue.AsInt(),
                IsNotAssignedOnly = FilterIsNotAssignedOnlyCheckBox.Checked
            };

            ComponentGrid.DataSource = ComponentRepository.GetComponents(filter);
            ComponentGrid.ClearSelection();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ViewComponentDetailTab(componentID = 0);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IsWork = true;
            RibbonMode = RibbonMode.Edit;

            ChangeControlsEnabled(DetailTab.Controls, true, false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Validation.IsAllValid(Detail.Controls))
                return;

            if (componentID > 0)
            {
                var component = ComponentRepository.GetComponent(componentID);

                component.ComponentTypeID = (byte)ComponentTypeDropDown.SelectedValue.AsByte();
                component.Name = NameTextBox.Text;

                ComponentRepository.UpdateComponent(component);
                ComponentRepository.Commit();
            }
            else
            {
                var component = new Component
                {
                    ComponentTypeID = (byte)ComponentTypeDropDown.SelectedValue.AsByte(),
                    Name = NameTextBox.Text
                };

                ComponentRepository.InsertComponent(component);
                ComponentRepository.Commit();

                componentID = component.ID;
            }

            ViewComponentDetailTab(componentID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ComponentErrorProvider.Clear();

            if (componentID > 0)
            {
                ViewComponentDetailTab(componentID);
            }
            else
            {
                ViewComponentListingTab();

                componentID = -1;

                ComponentGrid.ClearSelection();
            }
        }

        private void ComponentTypeDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ComponentTypeDropDown.SelectedValue.AsByte() > 0)
                return;

            if (Application.OpenForms.OfType<ComponentTypePopup>().Count() < 1)
            {
                using (ComponentTypePopup popup = new ComponentTypePopup(MainForm))
                {
                    var result = popup.ShowDialog();

                    if (popup.ComponentTypeID > 0)
                    {
                        using (var repository = new ComponentTypeRepository())
                        {
                            var dropDown = repository.GetComponentTypeForDropDown();
                            dropDown.Insert(0, new KeyValuePair<byte, string>(0, "<Vytvořit nový typ...>"));

                            ComponentTypeDropDown.DataSource = dropDown;
                            ComponentTypeDropDown.SelectedValue = popup.ComponentTypeID;
                        }
                    }
                }
            }
        }

        private void ComponentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                componentID = (ComponentGrid.CurrentRow.DataBoundItem as ComponentData).ID;

                ViewComponentDetailTab(componentID);
            }
        }

        private void ComponentTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == DetailTab && componentID == -1)
            {
                e.Cancel = true;
            }

        }

        private void ComponentTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentErrorProvider.Clear();

            if (ComponentTabControl.SelectedTab == ListingTab)
            {
                RibbonMode = RibbonMode.Listing;
            }
            else if (ComponentTabControl.SelectedTab == DetailTab)
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

        private void ViewComponentListingTab()
        {
            IsWork = false;

            using (var repository = new ComponentTypeRepository())
            {
                var dropDown = repository.GetComponentTypeForDropDown();
                dropDown.Insert(0, new KeyValuePair<byte, string>());

                FilterComponentTypeDropDown.DataSource = dropDown;
            }
            using (var repository = new ProductRepository())
            {
                var dropDown = repository.GetProductsForDropDown();
                dropDown.Insert(0, new KeyValuePair<int, string>());

                FilterProductDropDown.DataSource = dropDown;
            }

            ChangeControlsEnabled(DetailTab.Controls, false, true);

            ComponentTabControl.SelectedTab = ListingTab;
        }

        private void ViewComponentDetailTab(int id)
        {
            using (var repository = new ComponentTypeRepository())
            {
                var dropDown = repository.GetComponentTypeForDropDown();
                dropDown.Insert(0, new KeyValuePair<byte, string>(0, "<Vytvořit nový typ...>"));

                ComponentTypeDropDown.DataSource = dropDown;
            }

            if (id > 0)
            {
                IsWork = false;
                RibbonMode = RibbonMode.Detail;

                ChangeControlsEnabled(DetailTab.Controls, false, false);

                var component = ComponentRepository.GetComponent(componentID);

                ComponentTypeDropDown.SelectedValue = component.ComponentTypeID;
                NameTextBox.Text = component.Name.ToString();

                ProductGrid.DataSource = ComponentRepository.GetProducts(componentID);

                ComponentTabControl.SelectedTab = DetailTab;

                ProductGrid.ClearSelection();
            }
            else
            {
                IsWork = true;
                RibbonMode = RibbonMode.Edit;

                ChangeControlsEnabled(DetailTab.Controls, true, true);

                ComponentTabControl.SelectedTab = DetailTab;
            }
        }

        private void SetRibbonButtons(RibbonMode state)
        {
            switch (state)
            {
                case RibbonMode.Listing:
                    FilterButton.Enabled = true;
                    NewButton.Enabled = true;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    break;
                case RibbonMode.Detail:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = true;
                    SaveButton.Enabled = false;
                    CancelButton.Enabled = false;
                    break;
                case RibbonMode.Edit:
                    FilterButton.Enabled = false;
                    NewButton.Enabled = false;
                    EditButton.Enabled = false;
                    SaveButton.Enabled = true;
                    CancelButton.Enabled = true;
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

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (NameTextBox.Text.IsNullOrWhiteSpace())
            {
                ComponentErrorProvider.SetError(NameTextBox, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else if (NameTextBox.Text.Length > 100)
            {
                ComponentErrorProvider.SetError(NameTextBox, Resources.ValidationLength.FormatWith(100));
                e.Cancel = true;
            }
            else
            {
                ComponentErrorProvider.SetError(NameTextBox, "");
            }
        }

        private void ComponentTypeDropDown_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ComponentTypeDropDown.SelectedIndex == -1)
            {
                ComponentErrorProvider.SetError(ComponentTypeDropDown, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else
            {
                ComponentErrorProvider.SetError(ComponentTypeDropDown, "");
            }
        }
    }
}
