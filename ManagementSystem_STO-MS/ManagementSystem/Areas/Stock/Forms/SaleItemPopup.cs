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
    public partial class SaleItemPopup : Form, IForm
    {
        private RibbonMode _ribbonMode;
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

        public SaleItemPopup(int saleID, Form main)
        {
            this.saleID = saleID;
            MainForm = main as MainForm;

            InitializeComponent();
        }

        private void SaleItemPopup_Load(object sender, EventArgs e)
        {
            Left = MainForm.Location.X + (MainForm.Width / 2 - Width / 2);
            Top = MainForm.Location.Y + (MainForm.Height / 2 - Height / 2);

            FilterButton_Click(sender, e);

            ProductGrid.ClearSelection();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            RibbonMode = RibbonMode.Listing;

            var filter = new ProductFilter
            {
                ID = FilterIDTextBox.Text.AsInt(),
                Name = FilterNameTextBox.Text
            };

            using (var repository = new SaleRepository())
            {
                ProductGrid.DataSource = repository.GetProductsForPopup(saleID, filter);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var productIDs = ProductGrid.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => (int)x.Cells[ProductGrid_ID.Name].Value.AsInt())
                .ToList();

            using (var repository = new SaleRepository())
            {
                repository.AddSaleItems(saleID, productIDs);
                repository.Commit();
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            if (ProductGrid.SelectedRows.Count > 0)
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
            ProductGrid.SelectAll();
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
