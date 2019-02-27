using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Common;
using ManagementSystem.Main;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Shared.Interfaces;

namespace ManagementSystem.Catalog
{
    public partial class ComponentPopup : Form, IForm
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

        public ComponentPopup(int productID, Form main)
        {
            this.productID = productID;
            ProductRepository = new ProductRepository();
            MainForm = main as MainForm;

            InitializeComponent();
        }

        private void ComponentPopup_Load(object sender, EventArgs e)
        {
            Left = MainForm.Location.X + (MainForm.Width / 2 - Width / 2);
            Top = MainForm.Location.Y + (MainForm.Height / 2 - Height / 2);

            using (var repository = new ComponentTypeRepository())
            {
                var dropDown = repository.GetComponentTypeForDropDown();
                dropDown.Insert(0, new KeyValuePair<byte, string>());

                FilterComponentTypeDropDown.DataSource = dropDown;
            }
            using (var repository = new ProductRepository())
            {
                var dropDown = repository.GetProductsForDropDown(productID);
                dropDown.Insert(0, new KeyValuePair<int, string>());

                FilterProductDropDown.DataSource = dropDown;
            }

            FilterButton_Click(sender, e);

            ComponentGrid.ClearSelection();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            RibbonMode = RibbonMode.Listing;

            var filter = new ComponentFilter
            {
                ComponentTypeID = (FilterComponentTypeDropDown.SelectedValue.AsByte() == 0) ? null : FilterComponentTypeDropDown.SelectedValue.AsByte(),
                Name = FilterNameTextBox.Text,
                ProductID = (FilterProductDropDown.SelectedValue.AsInt() == 0) ? null : FilterProductDropDown.SelectedValue.AsInt(),
                IsNotAssignedOnly = FilterIsNotAssignedOnlyCheckBox.Checked
            };

            ComponentGrid.DataSource = ProductRepository.GetComponentsForPopup(productID, filter);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var componentIDs = ComponentGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (int)x.Cells[ComponentGrid_ID.Name].Value.AsInt())
                .ToList();

            ProductRepository.AddComponents(productID, componentIDs);
            ProductRepository.Commit();

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComponentGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (ComponentGrid.SelectedRows.Count > 0)
            {
                RibbonMode = RibbonMode.Edit;
            }
            else
            {
                RibbonMode = RibbonMode.Listing;
            }
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e)
        {
            ComponentGrid.SelectAll();
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            switch (mode)
            {
                case RibbonMode.Listing:
                    AddButton.Enabled = false;
                    break;
                case RibbonMode.Edit:
                    AddButton.Enabled = true;
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
    }
}
