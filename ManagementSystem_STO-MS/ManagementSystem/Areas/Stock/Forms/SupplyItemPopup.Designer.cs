namespace ManagementSystem.Stock
{
    partial class SupplyItemPopup
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
            System.Windows.Forms.Label FilterProductLabel;
            this.ComponentRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.ComponentGrid = new System.Windows.Forms.DataGridView();
            this.ComponentGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_ComponentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterComponentTypeLabel = new System.Windows.Forms.Label();
            this.FilterComponentTypeDropDown = new System.Windows.Forms.ComboBox();
            this.FilterNameTextBox = new System.Windows.Forms.TextBox();
            this.FilterProductDropDown = new System.Windows.Forms.ComboBox();
            FilterNameLabel = new System.Windows.Forms.Label();
            FilterProductLabel = new System.Windows.Forms.Label();
            this.ComponentRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).BeginInit();
            this.ComponentGridContextMenu.SuspendLayout();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterNameLabel
            // 
            FilterNameLabel.AutoSize = true;
            FilterNameLabel.Location = new System.Drawing.Point(144, 21);
            FilterNameLabel.Name = "FilterNameLabel";
            FilterNameLabel.Size = new System.Drawing.Size(41, 13);
            FilterNameLabel.TabIndex = 13;
            FilterNameLabel.Text = "Název:";
            // 
            // FilterProductLabel
            // 
            FilterProductLabel.AutoSize = true;
            FilterProductLabel.Location = new System.Drawing.Point(311, 21);
            FilterProductLabel.Name = "FilterProductLabel";
            FilterProductLabel.Size = new System.Drawing.Size(47, 13);
            FilterProductLabel.TabIndex = 22;
            FilterProductLabel.Text = "Produkt:";
            // 
            // ComponentRibbon
            // 
            this.ComponentRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.AddButton,
            this.CancelButton});
            this.ComponentRibbon.Location = new System.Drawing.Point(0, 0);
            this.ComponentRibbon.Name = "ComponentRibbon";
            this.ComponentRibbon.Size = new System.Drawing.Size(476, 38);
            this.ComponentRibbon.TabIndex = 10;
            this.ComponentRibbon.Text = "Menu";
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
            this.FillingPanel.Size = new System.Drawing.Size(476, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // ComponentGrid
            // 
            this.ComponentGrid.AllowUserToAddRows = false;
            this.ComponentGrid.AllowUserToDeleteRows = false;
            this.ComponentGrid.AllowUserToOrderColumns = true;
            this.ComponentGrid.AllowUserToResizeRows = false;
            this.ComponentGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ComponentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComponentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentGrid_ID,
            this.ComponentGrid_ComponentTypeName,
            this.ComponentGrid_Name,
            this.ComponentGrid_Quantity});
            this.ComponentGrid.ContextMenuStrip = this.ComponentGridContextMenu;
            this.ComponentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ComponentGrid.Location = new System.Drawing.Point(0, 119);
            this.ComponentGrid.Name = "ComponentGrid";
            this.ComponentGrid.ReadOnly = true;
            this.ComponentGrid.RowHeadersVisible = false;
            this.ComponentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentGrid.ShowCellToolTips = false;
            this.ComponentGrid.Size = new System.Drawing.Size(476, 342);
            this.ComponentGrid.TabIndex = 1;
            this.ComponentGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ComponentGrid_RowStateChanged);
            // 
            // ComponentGrid_ID
            // 
            this.ComponentGrid_ID.DataPropertyName = "ID";
            this.ComponentGrid_ID.HeaderText = "ID";
            this.ComponentGrid_ID.Name = "ComponentGrid_ID";
            this.ComponentGrid_ID.ReadOnly = true;
            this.ComponentGrid_ID.Visible = false;
            // 
            // ComponentGrid_ComponentTypeName
            // 
            this.ComponentGrid_ComponentTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ComponentGrid_ComponentTypeName.DataPropertyName = "ComponentTypeName";
            this.ComponentGrid_ComponentTypeName.HeaderText = "Typ komponenty";
            this.ComponentGrid_ComponentTypeName.MinimumWidth = 110;
            this.ComponentGrid_ComponentTypeName.Name = "ComponentGrid_ComponentTypeName";
            this.ComponentGrid_ComponentTypeName.ReadOnly = true;
            this.ComponentGrid_ComponentTypeName.Width = 110;
            // 
            // ComponentGrid_Name
            // 
            this.ComponentGrid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentGrid_Name.DataPropertyName = "Name";
            this.ComponentGrid_Name.HeaderText = "Název";
            this.ComponentGrid_Name.MinimumWidth = 150;
            this.ComponentGrid_Name.Name = "ComponentGrid_Name";
            this.ComponentGrid_Name.ReadOnly = true;
            // 
            // ComponentGrid_Quantity
            // 
            this.ComponentGrid_Quantity.DataPropertyName = "Quantity";
            this.ComponentGrid_Quantity.HeaderText = "Quantity";
            this.ComponentGrid_Quantity.Name = "ComponentGrid_Quantity";
            this.ComponentGrid_Quantity.ReadOnly = true;
            this.ComponentGrid_Quantity.Visible = false;
            // 
            // ComponentGridContextMenu
            // 
            this.ComponentGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllContextMenuItem});
            this.ComponentGridContextMenu.Name = "ComponentGridContextMenu";
            this.ComponentGridContextMenu.Size = new System.Drawing.Size(129, 26);
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
            this.Filter.Controls.Add(this.FilterComponentTypeLabel);
            this.Filter.Controls.Add(this.FilterComponentTypeDropDown);
            this.Filter.Controls.Add(FilterNameLabel);
            this.Filter.Controls.Add(this.FilterNameTextBox);
            this.Filter.Controls.Add(FilterProductLabel);
            this.Filter.Controls.Add(this.FilterProductDropDown);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(0, 49);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(476, 70);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtr";
            // 
            // FilterComponentTypeLabel
            // 
            this.FilterComponentTypeLabel.AutoSize = true;
            this.FilterComponentTypeLabel.Location = new System.Drawing.Point(6, 21);
            this.FilterComponentTypeLabel.Name = "FilterComponentTypeLabel";
            this.FilterComponentTypeLabel.Size = new System.Drawing.Size(86, 13);
            this.FilterComponentTypeLabel.TabIndex = 14;
            this.FilterComponentTypeLabel.Text = "Typ komponenty";
            // 
            // FilterComponentTypeDropDown
            // 
            this.FilterComponentTypeDropDown.DisplayMember = "Value";
            this.FilterComponentTypeDropDown.FormattingEnabled = true;
            this.FilterComponentTypeDropDown.Location = new System.Drawing.Point(9, 37);
            this.FilterComponentTypeDropDown.Name = "FilterComponentTypeDropDown";
            this.FilterComponentTypeDropDown.Size = new System.Drawing.Size(120, 21);
            this.FilterComponentTypeDropDown.TabIndex = 0;
            this.FilterComponentTypeDropDown.ValueMember = "Key";
            // 
            // FilterNameTextBox
            // 
            this.FilterNameTextBox.Location = new System.Drawing.Point(147, 37);
            this.FilterNameTextBox.Name = "FilterNameTextBox";
            this.FilterNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FilterNameTextBox.TabIndex = 1;
            // 
            // FilterProductDropDown
            // 
            this.FilterProductDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterProductDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterProductDropDown.DisplayMember = "Value";
            this.FilterProductDropDown.FormattingEnabled = true;
            this.FilterProductDropDown.Location = new System.Drawing.Point(314, 37);
            this.FilterProductDropDown.Name = "FilterProductDropDown";
            this.FilterProductDropDown.Size = new System.Drawing.Size(150, 21);
            this.FilterProductDropDown.TabIndex = 2;
            this.FilterProductDropDown.ValueMember = "Key";
            // 
            // SupplyItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(476, 461);
            this.Controls.Add(this.ComponentGrid);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ComponentRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplyItemPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přidání položek";
            this.Load += new System.EventHandler(this.SupplyItemPopup_Load);
            this.ComponentRibbon.ResumeLayout(false);
            this.ComponentRibbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).EndInit();
            this.ComponentGridContextMenu.ResumeLayout(false);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ComponentRibbon;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.ToolStripButton AddButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.DataGridView ComponentGrid;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.ComboBox FilterComponentTypeDropDown;
        private System.Windows.Forms.Label FilterComponentTypeLabel;
        private System.Windows.Forms.TextBox FilterNameTextBox;
        private System.Windows.Forms.ComboBox FilterProductDropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ComponentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_Quantity;
        private System.Windows.Forms.ContextMenuStrip ComponentGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
    }
}

