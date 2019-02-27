namespace ManagementSystem.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.NavigationMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.CatalogMenu = new System.Windows.Forms.Button();
            this.ProductMenu = new System.Windows.Forms.Button();
            this.ComponentMenu = new System.Windows.Forms.Button();
            this.StockMenu = new System.Windows.Forms.Button();
            this.SupplyMenu = new System.Windows.Forms.Button();
            this.InventoryMenu = new System.Windows.Forms.Button();
            this.SaleMenu = new System.Windows.Forms.Button();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.Container = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            this.NavigationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.NavigationMenu);
            this.NavigationPanel.Controls.Add(this.LogoImage);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(120, 474);
            this.NavigationPanel.TabIndex = 2;
            // 
            // NavigationMenu
            // 
            this.NavigationMenu.AutoScroll = true;
            this.NavigationMenu.AutoSize = true;
            this.NavigationMenu.Controls.Add(this.CatalogMenu);
            this.NavigationMenu.Controls.Add(this.ProductMenu);
            this.NavigationMenu.Controls.Add(this.ComponentMenu);
            this.NavigationMenu.Controls.Add(this.StockMenu);
            this.NavigationMenu.Controls.Add(this.SupplyMenu);
            this.NavigationMenu.Controls.Add(this.InventoryMenu);
            this.NavigationMenu.Controls.Add(this.SaleMenu);
            this.NavigationMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NavigationMenu.Location = new System.Drawing.Point(0, 65);
            this.NavigationMenu.Name = "NavigationMenu";
            this.NavigationMenu.Size = new System.Drawing.Size(120, 409);
            this.NavigationMenu.TabIndex = 3;
            this.NavigationMenu.WrapContents = false;
            // 
            // CatalogMenu
            // 
            this.CatalogMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CatalogMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CatalogMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatalogMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.CatalogMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CatalogMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatalogMenu.Location = new System.Drawing.Point(0, 0);
            this.CatalogMenu.Margin = new System.Windows.Forms.Padding(0);
            this.CatalogMenu.Name = "CatalogMenu";
            this.CatalogMenu.Size = new System.Drawing.Size(120, 30);
            this.CatalogMenu.TabIndex = 0;
            this.CatalogMenu.Text = "Katalog";
            this.CatalogMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CatalogMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CatalogMenu.UseVisualStyleBackColor = false;
            this.CatalogMenu.Click += new System.EventHandler(this.CatalogMenu_Click);
            // 
            // ProductMenu
            // 
            this.ProductMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ProductMenu.FlatAppearance.BorderSize = 0;
            this.ProductMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.ProductMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.ProductMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductMenu.Location = new System.Drawing.Point(0, 30);
            this.ProductMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ProductMenu.Name = "ProductMenu";
            this.ProductMenu.Size = new System.Drawing.Size(120, 30);
            this.ProductMenu.TabIndex = 1;
            this.ProductMenu.Text = "Produkty";
            this.ProductMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductMenu.UseVisualStyleBackColor = false;
            this.ProductMenu.Visible = false;
            this.ProductMenu.Click += new System.EventHandler(this.ProductMenu_Click);
            // 
            // ComponentMenu
            // 
            this.ComponentMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComponentMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ComponentMenu.FlatAppearance.BorderSize = 0;
            this.ComponentMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.ComponentMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComponentMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.ComponentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComponentMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComponentMenu.Location = new System.Drawing.Point(0, 60);
            this.ComponentMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ComponentMenu.Name = "ComponentMenu";
            this.ComponentMenu.Size = new System.Drawing.Size(120, 30);
            this.ComponentMenu.TabIndex = 2;
            this.ComponentMenu.Text = "Komponenty";
            this.ComponentMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComponentMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ComponentMenu.UseVisualStyleBackColor = false;
            this.ComponentMenu.Visible = false;
            this.ComponentMenu.Click += new System.EventHandler(this.ComponentMenu_Click);
            // 
            // StockMenu
            // 
            this.StockMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StockMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StockMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.StockMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.StockMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockMenu.Location = new System.Drawing.Point(0, 90);
            this.StockMenu.Margin = new System.Windows.Forms.Padding(0);
            this.StockMenu.Name = "StockMenu";
            this.StockMenu.Size = new System.Drawing.Size(120, 30);
            this.StockMenu.TabIndex = 3;
            this.StockMenu.Text = "Sklad";
            this.StockMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StockMenu.UseVisualStyleBackColor = false;
            this.StockMenu.Click += new System.EventHandler(this.StockMenu_Click);
            // 
            // SupplyMenu
            // 
            this.SupplyMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SupplyMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SupplyMenu.FlatAppearance.BorderSize = 0;
            this.SupplyMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.SupplyMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SupplyMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.SupplyMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplyMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplyMenu.Location = new System.Drawing.Point(0, 120);
            this.SupplyMenu.Margin = new System.Windows.Forms.Padding(0);
            this.SupplyMenu.Name = "SupplyMenu";
            this.SupplyMenu.Size = new System.Drawing.Size(120, 30);
            this.SupplyMenu.TabIndex = 4;
            this.SupplyMenu.Text = "Příjemky";
            this.SupplyMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplyMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SupplyMenu.UseVisualStyleBackColor = false;
            this.SupplyMenu.Visible = false;
            this.SupplyMenu.Click += new System.EventHandler(this.SupplyMenu_Click);
            // 
            // InventoryMenu
            // 
            this.InventoryMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InventoryMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InventoryMenu.FlatAppearance.BorderSize = 0;
            this.InventoryMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.InventoryMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InventoryMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.InventoryMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryMenu.Location = new System.Drawing.Point(0, 150);
            this.InventoryMenu.Margin = new System.Windows.Forms.Padding(0);
            this.InventoryMenu.Name = "InventoryMenu";
            this.InventoryMenu.Size = new System.Drawing.Size(120, 30);
            this.InventoryMenu.TabIndex = 5;
            this.InventoryMenu.Text = "Inventury";
            this.InventoryMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InventoryMenu.UseVisualStyleBackColor = false;
            this.InventoryMenu.Visible = false;
            this.InventoryMenu.Click += new System.EventHandler(this.InventoryMenu_Click);
            // 
            // SaleMenu
            // 
            this.SaleMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaleMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaleMenu.FlatAppearance.BorderSize = 0;
            this.SaleMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.SaleMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaleMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.SaleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaleMenu.Location = new System.Drawing.Point(0, 180);
            this.SaleMenu.Margin = new System.Windows.Forms.Padding(0);
            this.SaleMenu.Name = "SaleMenu";
            this.SaleMenu.Size = new System.Drawing.Size(120, 30);
            this.SaleMenu.TabIndex = 5;
            this.SaleMenu.Text = "Prodeje";
            this.SaleMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaleMenu.UseVisualStyleBackColor = false;
            this.SaleMenu.Visible = false;
            this.SaleMenu.Click += new System.EventHandler(this.SaleMenu_Click);
            // 
            // LogoImage
            // 
            this.LogoImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoImage.Image = global::ManagementSystem.Properties.Resources.logo;
            this.LogoImage.Location = new System.Drawing.Point(0, 0);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(120, 65);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImage.TabIndex = 2;
            this.LogoImage.TabStop = false;
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(120, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(500, 474);
            this.Container.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 474);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladové hospodářství";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.NavigationMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.FlowLayoutPanel NavigationMenu;
        private System.Windows.Forms.Button CatalogMenu;
        private System.Windows.Forms.Button ProductMenu;
        private System.Windows.Forms.Button ComponentMenu;
        private System.Windows.Forms.Button StockMenu;
        private System.Windows.Forms.Button SupplyMenu;
        private System.Windows.Forms.PictureBox LogoImage;
        private new System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button InventoryMenu;
        private System.Windows.Forms.Button SaleMenu;
    }
}