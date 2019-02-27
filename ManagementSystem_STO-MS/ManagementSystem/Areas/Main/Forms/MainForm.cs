using System;
using System.Windows.Forms;
using ManagementSystem.Catalog;
using ManagementSystem.Properties;
//using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
//using ManagementSystem.Shared.Interfaces;
using ManagementSystem.Shared.NavigationMenu;
using ManagementSystem.Stock;

namespace ManagementSystem.Main
{
    public partial class MainForm : Form
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private new NavigationMenu Menu;
        private Form ProductForm;
        private Form ComponentForm;
        private Form SupplyForm;
        private Form InventoryForm;
        private Form SaleForm;

        public MainForm()
        {
            ProductForm = new ProductForm(this);

            ComponentForm = new ComponentForm(this);

            SupplyForm = new SupplyForm(this);

            InventoryForm = new InventoryForm(this);

            SaleForm = new SaleForm(this);

            InitializeComponent();
            CustomInitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            Icon = Resources.AppIcon;

            Menu = new NavigationMenu(
                    new MenuButton(MenuTopLevelButtons.Catalog, ProductMenu, ComponentMenu),
                    new MenuButton(MenuTopLevelButtons.Stock, SupplyMenu, InventoryMenu, SaleMenu)
                );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Location = Settings.Default.MainFormLocation;
            Size = Settings.Default.MainFormSize;
            WindowState = Settings.Default.MainFormWindowState;

            _logger.Debug("Application started. Location: x={0}, y={1}; Size: w={2}, h={3}; WindowState: {4}", Location.X, Location.Y, Size.Width, Size.Height, WindowState.ToString());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.MainFormLocation = Location;
                Settings.Default.MainFormSize = Size;
                Settings.Default.MainFormWindowState = WindowState;
            }
            else
            {
                Settings.Default.MainFormLocation = RestoreBounds.Location;
                Settings.Default.MainFormSize = RestoreBounds.Size;
                Settings.Default.MainFormWindowState = (WindowState == FormWindowState.Minimized) ? FormWindowState.Normal : WindowState;
            }

            Settings.Default.Save();

            e.Cancel = false;
        }

        private void CatalogMenu_Click(object sender, EventArgs e)
        {
            Menu.ShowSubMenu(MenuTopLevelButtons.Catalog);
        }

        private void StockMenu_Click(object sender, EventArgs e)
        {
            Menu.ShowSubMenu(MenuTopLevelButtons.Stock);
        }

        private void ProductMenu_Click(object sender, EventArgs e)
        {
            ViewForm(ProductForm);
        }

        private void ComponentMenu_Click(object sender, EventArgs e)
        {
            ViewForm(ComponentForm);
        }

        private void SupplyMenu_Click(object sender, EventArgs e)
        {
            ViewForm(SupplyForm);
        }

        private void InventoryMenu_Click(object sender, EventArgs e)
        {
            ViewForm(InventoryForm);
        }

        private void SaleMenu_Click(object sender, EventArgs e)
        {
            ViewForm(SaleForm);
        }

        private void ViewForm(Form form)
        {
            //if (Container.Controls.Count > 0)
            //{
            //    IForm currentForm = Container.Controls[0] as IForm;

            //    if (currentForm.HasUnsavedWork())
            //    {
            //        DialogResult result = MessageBox.Show(Resources.UnsavedDataWarning, Resources.UnsavedData, MessageBoxButtons.YesNo);

            //        if (result == DialogResult.Yes)
            //        {
            //            currentForm.DiscardUnsavedWork();
            //        }
            //        else
            //        {
            //            return;
            //        }
            //    }
            //}

            Container.Controls.Clear();
            form.TopLevel = false;
            Container.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }
    }
}
