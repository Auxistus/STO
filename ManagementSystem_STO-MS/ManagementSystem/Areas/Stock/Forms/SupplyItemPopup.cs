﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.BusinessLogic.Stock;
using ManagementSystem.Common;
using ManagementSystem.Database;
using ManagementSystem.Main;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Shared.Interfaces;

namespace ManagementSystem.Stock
{
    public partial class SupplyItemPopup : Form, IForm
    {
        private RibbonMode _ribbonMode;
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

        public SupplyItemPopup(int supplyID, Form main)
        {
            this.supplyID = supplyID;
            MainForm = main as MainForm;

            InitializeComponent();
        }

        private void SupplyItemPopup_Load(object sender, EventArgs e)
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
                var dropDown = repository.GetProductsForDropDown(supplyID);
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
                ProductID = (FilterProductDropDown.SelectedValue.AsInt() == 0) ? null : FilterProductDropDown.SelectedValue.AsInt()
            };

            using (var repository = new SupplyRepository())
            {
                ComponentGrid.DataSource = repository.GetComponentsForPopup(supplyID, filter);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var componentIDs = ComponentGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (int)x.Cells[ComponentGrid_ID.Name].Value.AsInt())
                .ToList();

            using (var repository = new SupplyRepository())
            {
                repository.AddSupplyItems(supplyID, componentIDs);
                repository.Commit();
            }

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