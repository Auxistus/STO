namespace ManagementSystem.Stock
{
    partial class SaleItemPopup
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label FilterNameLabel;
            this.ProductRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.ProductGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.FilterIDTextBox = new System.Windows.Forms.TextBox();
            this.FilterNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_ScaleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FilterNameLabel = new System.Windows.Forms.Label();
            this.ProductRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.ProductGridContextMenu.SuspendLayout();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterNameLabel
            // 
            FilterNameLabel.AutoSize = true;
            FilterNameLabel.Location = new System.Drawing.Point(123, 21);
            FilterNameLabel.Name = "FilterNameLabel";
            FilterNameLabel.Size = new System.Drawing.Size(41, 13);
            FilterNameLabel.TabIndex = 13;
            FilterNameLabel.Text = "Název:";
            // 
            // ProductRibbon
            // 
            this.ProductRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ProductRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ProductRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.AddButton,
            this.CancelButton});
            this.ProductRibbon.Location = new System.Drawing.Point(0, 0);
            this.ProductRibbon.Name = "ProductRibbon";
            this.ProductRibbon.Size = new System.Drawing.Size(335, 38);
            this.ProductRibbon.TabIndex = 10;
            this.ProductRibbon.Text = "Menu";
            // 
            // FilterButton
            // 
            this.FilterButton.AutoSize = false;
            this.FilterButton.AutoToolTip = false;
            this.FilterButton.Image = global::ManagementSystem.Properties.Resources.FilterSmall;
            this.FilterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(50, 35);
            this.FilterButton.Text = "Filtr";
            this.FilterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FilterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 38);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = false;
            this.AddButton.AutoToolTip = false;
            this.AddButton.Enabled = false;
            this.AddButton.Image = global::ManagementSystem.Properties.Resources.AddSmall;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 35);
            this.AddButton.Text = "Přidat";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = false;
            this.CancelButton.AutoToolTip = false;
            this.CancelButton.Image = global::ManagementSystem.Properties.Resources.CancelSmall;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(50, 35);
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(335, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AllowUserToOrderColumns = true;
            this.ProductGrid.AllowUserToResizeRows = false;
            this.ProductGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductGrid_ID,
            this.ProductGrid_Name,
            this.ProductGrid_Scale,
            this.ProductGrid_ScaleString});
            this.ProductGrid.ContextMenuStrip = this.ProductGridContextMenu;
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductGrid.Location = new System.Drawing.Point(0, 119);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.ShowCellToolTips = false;
            this.ProductGrid.Size = new System.Drawing.Size(335, 342);
            this.ProductGrid.TabIndex = 1;
            this.ProductGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ProductGrid_RowStateChanged);
            // 
            // ProductGridContextMenu
            // 
            this.ProductGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllContextMenuItem});
            this.ProductGridContextMenu.Name = "ComponentGridContextMenu";
            this.ProductGridContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // SelectAllContextMenuItem
            // 
            this.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem";
            this.SelectAllContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SelectAllContextMenuItem.Text = "Vybrat vše";
            this.SelectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIDLabel);
            this.Filter.Controls.Add(this.FilterIDTextBox);
            this.Filter.Controls.Add(FilterNameLabel);
            this.Filter.Controls.Add(this.FilterNameTextBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(0, 49);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(335, 70);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtr";
            // 
            // FilterIDLabel
            // 
            this.FilterIDLabel.AutoSize = true;
            this.FilterIDLabel.Location = new System.Drawing.Point(6, 21);
            this.FilterIDLabel.Name = "FilterIDLabel";
            this.FilterIDLabel.Size = new System.Drawing.Size(34, 13);
            this.FilterIDLabel.TabIndex = 24;
            this.FilterIDLabel.Text = "Číslo:";
            // 
            // FilterIDTextBox
            // 
            this.FilterIDTextBox.Location = new System.Drawing.Point(9, 37);
            this.FilterIDTextBox.Name = "FilterIDTextBox";
            this.FilterIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterIDTextBox.TabIndex = 23;
            // 
            // FilterNameTextBox
            // 
            this.FilterNameTextBox.Location = new System.Drawing.Point(126, 37);
            this.FilterNameTextBox.Name = "FilterNameTextBox";
            this.FilterNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FilterNameTextBox.TabIndex = 1;
            // 
            // ProductGrid_ID
            // 
            this.ProductGrid_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductGrid_ID.DataPropertyName = "ID";
            this.ProductGrid_ID.HeaderText = "Číslo";
            this.ProductGrid_ID.MinimumWidth = 60;
            this.ProductGrid_ID.Name = "ProductGrid_ID";
            this.ProductGrid_ID.ReadOnly = true;
            this.ProductGrid_ID.Width = 60;
            // 
            // ProductGrid_Name
            // 
            this.ProductGrid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductGrid_Name.DataPropertyName = "Name";
            this.ProductGrid_Name.HeaderText = "Název";
            this.ProductGrid_Name.MinimumWidth = 150;
            this.ProductGrid_Name.Name = "ProductGrid_Name";
            this.ProductGrid_Name.ReadOnly = true;
            // 
            // ProductGrid_Scale
            // 
            this.ProductGrid_Scale.DataPropertyName = "Scale";
            this.ProductGrid_Scale.HeaderText = "Scale";
            this.ProductGrid_Scale.Name = "ProductGrid_Scale";
            this.ProductGrid_Scale.ReadOnly = true;
            this.ProductGrid_Scale.Visible = false;
            // 
            // ProductGrid_ScaleString
            // 
            this.ProductGrid_ScaleString.DataPropertyName = "ScaleString";
            this.ProductGrid_ScaleString.HeaderText = "ScaleString";
            this.ProductGrid_ScaleString.Name = "ProductGrid_ScaleString";
            this.ProductGrid_ScaleString.ReadOnly = true;
            this.ProductGrid_ScaleString.Visible = false;
            // 
            // SaleItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(335, 461);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ProductRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleItemPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidání položek";
            this.Load += new System.EventHandler(this.SaleItemPopup_Load);
            this.ProductRibbon.ResumeLayout(false);
            this.ProductRibbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.ProductGridContextMenu.ResumeLayout(false);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ProductRibbon;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.ToolStripButton AddButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterNameTextBox;
        private System.Windows.Forms.ContextMenuStrip ProductGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.TextBox FilterIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ScaleString;
    }
}

