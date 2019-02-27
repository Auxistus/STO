namespace ManagementSystem.Catalog
{
    partial class ComponentForm
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
            System.Windows.Forms.Label FilterComponentTypeLabel;
            System.Windows.Forms.Label FilterNameLabel;
            System.Windows.Forms.Label ComponentTypeLabel;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label FilterProductLabel;
            this.ComponentRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.ComponentTabControl = new System.Windows.Forms.TabControl();
            this.ListingTab = new System.Windows.Forms.TabPage();
            this.ComponentGrid = new System.Windows.Forms.DataGridView();
            this.ComponentGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_ComponentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrip_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIsNotAssignedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterProductDropDown = new System.Windows.Forms.ComboBox();
            this.FilterComponentTypeDropDown = new System.Windows.Forms.ComboBox();
            this.FilterNameTextBox = new System.Windows.Forms.TextBox();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.ProductGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_ScaleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.ComponentTypeDropDown = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.ComponentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            FilterComponentTypeLabel = new System.Windows.Forms.Label();
            FilterNameLabel = new System.Windows.Forms.Label();
            ComponentTypeLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            FilterProductLabel = new System.Windows.Forms.Label();
            this.ComponentRibbon.SuspendLayout();
            this.ComponentTabControl.SuspendLayout();
            this.ListingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.DetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterComponentTypeLabel
            // 
            FilterComponentTypeLabel.AutoSize = true;
            FilterComponentTypeLabel.Location = new System.Drawing.Point(6, 21);
            FilterComponentTypeLabel.Name = "FilterComponentTypeLabel";
            FilterComponentTypeLabel.Size = new System.Drawing.Size(89, 13);
            FilterComponentTypeLabel.TabIndex = 9;
            FilterComponentTypeLabel.Text = "Typ komponenty:";
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
            // ComponentTypeLabel
            // 
            ComponentTypeLabel.AutoSize = true;
            ComponentTypeLabel.Location = new System.Drawing.Point(6, 21);
            ComponentTypeLabel.Name = "ComponentTypeLabel";
            ComponentTypeLabel.Size = new System.Drawing.Size(89, 13);
            ComponentTypeLabel.TabIndex = 21;
            ComponentTypeLabel.Text = "Typ komponenty:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(144, 21);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(41, 13);
            NameLabel.TabIndex = 22;
            NameLabel.Text = "Název:";
            // 
            // FilterProductLabel
            // 
            FilterProductLabel.AutoSize = true;
            FilterProductLabel.Location = new System.Drawing.Point(311, 20);
            FilterProductLabel.Name = "FilterProductLabel";
            FilterProductLabel.Size = new System.Drawing.Size(47, 13);
            FilterProductLabel.TabIndex = 20;
            FilterProductLabel.Text = "Produkt:";
            // 
            // ComponentRibbon
            // 
            this.ComponentRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.NewButton,
            this.EditButton,
            this.SaveButton,
            this.CancelButton});
            this.ComponentRibbon.Location = new System.Drawing.Point(0, 0);
            this.ComponentRibbon.Name = "ComponentRibbon";
            this.ComponentRibbon.Size = new System.Drawing.Size(496, 38);
            this.ComponentRibbon.TabIndex = 10;
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
            // NewButton
            // 
            this.NewButton.AutoSize = false;
            this.NewButton.AutoToolTip = false;
            this.NewButton.Image = global::ManagementSystem.Properties.Resources.NewSmall;
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(50, 35);
            this.NewButton.Text = "Nový";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = false;
            this.EditButton.AutoToolTip = false;
            this.EditButton.Enabled = false;
            this.EditButton.Image = global::ManagementSystem.Properties.Resources.EditSmall;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 35);
            this.EditButton.Text = "Upravit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = false;
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = global::ManagementSystem.Properties.Resources.SaveSmall;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(50, 35);
            this.SaveButton.Text = "Uložit";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = false;
            this.CancelButton.AutoToolTip = false;
            this.CancelButton.Enabled = false;
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
            // ComponentTabControl
            // 
            this.ComponentTabControl.Controls.Add(this.ListingTab);
            this.ComponentTabControl.Controls.Add(this.DetailTab);
            this.ComponentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentTabControl.Location = new System.Drawing.Point(0, 49);
            this.ComponentTabControl.Name = "ComponentTabControl";
            this.ComponentTabControl.SelectedIndex = 0;
            this.ComponentTabControl.Size = new System.Drawing.Size(496, 363);
            this.ComponentTabControl.TabIndex = 0;
            this.ComponentTabControl.SelectedIndexChanged += new System.EventHandler(this.ComponentTabControl_SelectedIndexChanged);
            this.ComponentTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ComponentTabControl_Selecting);
            // 
            // ListingTab
            // 
            this.ListingTab.Controls.Add(this.ComponentGrid);
            this.ListingTab.Controls.Add(this.Filter);
            this.ListingTab.Location = new System.Drawing.Point(4, 22);
            this.ListingTab.Name = "ListingTab";
            this.ListingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListingTab.Size = new System.Drawing.Size(488, 337);
            this.ListingTab.TabIndex = 0;
            this.ListingTab.Text = "Seznam";
            this.ListingTab.UseVisualStyleBackColor = true;
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
            this.ComponentGrip_Name,
            this.ComponentGrid_Quantity});
            this.ComponentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ComponentGrid.Location = new System.Drawing.Point(3, 113);
            this.ComponentGrid.MultiSelect = false;
            this.ComponentGrid.Name = "ComponentGrid";
            this.ComponentGrid.ReadOnly = true;
            this.ComponentGrid.RowHeadersVisible = false;
            this.ComponentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentGrid.ShowCellToolTips = false;
            this.ComponentGrid.Size = new System.Drawing.Size(482, 221);
            this.ComponentGrid.TabIndex = 1;
            this.ComponentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComponentGrid_CellClick);
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
            // ComponentGrip_Name
            // 
            this.ComponentGrip_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ComponentGrip_Name.DataPropertyName = "Name";
            this.ComponentGrip_Name.HeaderText = "Název";
            this.ComponentGrip_Name.MinimumWidth = 150;
            this.ComponentGrip_Name.Name = "ComponentGrip_Name";
            this.ComponentGrip_Name.ReadOnly = true;
            this.ComponentGrip_Name.Width = 150;
            // 
            // ComponentGrid_Quantity
            // 
            this.ComponentGrid_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentGrid_Quantity.DataPropertyName = "Quantity";
            this.ComponentGrid_Quantity.HeaderText = "Množství";
            this.ComponentGrid_Quantity.MinimumWidth = 60;
            this.ComponentGrid_Quantity.Name = "ComponentGrid_Quantity";
            this.ComponentGrid_Quantity.ReadOnly = true;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIsNotAssignedOnlyCheckBox);
            this.Filter.Controls.Add(this.FilterProductDropDown);
            this.Filter.Controls.Add(FilterProductLabel);
            this.Filter.Controls.Add(this.FilterComponentTypeDropDown);
            this.Filter.Controls.Add(FilterComponentTypeLabel);
            this.Filter.Controls.Add(FilterNameLabel);
            this.Filter.Controls.Add(this.FilterNameTextBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(482, 110);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtr";
            // 
            // FilterIsNotAssignedOnlyCheckBox
            // 
            this.FilterIsNotAssignedOnlyCheckBox.AutoSize = true;
            this.FilterIsNotAssignedOnlyCheckBox.Location = new System.Drawing.Point(9, 77);
            this.FilterIsNotAssignedOnlyCheckBox.Name = "FilterIsNotAssignedOnlyCheckBox";
            this.FilterIsNotAssignedOnlyCheckBox.Size = new System.Drawing.Size(103, 17);
            this.FilterIsNotAssignedOnlyCheckBox.TabIndex = 3;
            this.FilterIsNotAssignedOnlyCheckBox.Text = "Jen nepřiřazené";
            this.FilterIsNotAssignedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterProductDropDown
            // 
            this.FilterProductDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterProductDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterProductDropDown.DisplayMember = "Value";
            this.FilterProductDropDown.FormattingEnabled = true;
            this.FilterProductDropDown.Location = new System.Drawing.Point(314, 36);
            this.FilterProductDropDown.Name = "FilterProductDropDown";
            this.FilterProductDropDown.Size = new System.Drawing.Size(150, 21);
            this.FilterProductDropDown.TabIndex = 2;
            this.FilterProductDropDown.ValueMember = "Key";
            // 
            // FilterComponentTypeDropDown
            // 
            this.FilterComponentTypeDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterComponentTypeDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            // DetailTab
            // 
            this.DetailTab.AutoScroll = true;
            this.DetailTab.Controls.Add(this.ProductGrid);
            this.DetailTab.Controls.Add(this.Detail);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(488, 337);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
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
            this.ProductGrid_ScaleString});
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.Location = new System.Drawing.Point(3, 73);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.ShowCellToolTips = false;
            this.ProductGrid.Size = new System.Drawing.Size(482, 261);
            this.ProductGrid.TabIndex = 1;
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
            this.ProductGrid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductGrid_Name.DataPropertyName = "Name";
            this.ProductGrid_Name.HeaderText = "Název";
            this.ProductGrid_Name.MinimumWidth = 150;
            this.ProductGrid_Name.Name = "ProductGrid_Name";
            this.ProductGrid_Name.ReadOnly = true;
            this.ProductGrid_Name.Width = 150;
            // 
            // ProductGrid_ScaleString
            // 
            this.ProductGrid_ScaleString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductGrid_ScaleString.DataPropertyName = "ScaleString";
            this.ProductGrid_ScaleString.HeaderText = "Měřítko";
            this.ProductGrid_ScaleString.MinimumWidth = 40;
            this.ProductGrid_ScaleString.Name = "ProductGrid_ScaleString";
            this.ProductGrid_ScaleString.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.ComponentTypeDropDown);
            this.Detail.Controls.Add(ComponentTypeLabel);
            this.Detail.Controls.Add(NameLabel);
            this.Detail.Controls.Add(this.NameTextBox);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail.Location = new System.Drawing.Point(3, 3);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(482, 70);
            this.Detail.TabIndex = 0;
            this.Detail.TabStop = false;
            this.Detail.Text = "Komponenta";
            // 
            // ComponentTypeDropDown
            // 
            this.ComponentTypeDropDown.DisplayMember = "Value";
            this.ComponentTypeDropDown.FormattingEnabled = true;
            this.ComponentTypeDropDown.Location = new System.Drawing.Point(9, 37);
            this.ComponentTypeDropDown.Name = "ComponentTypeDropDown";
            this.ComponentTypeDropDown.Size = new System.Drawing.Size(121, 21);
            this.ComponentTypeDropDown.TabIndex = 0;
            this.ComponentTypeDropDown.ValueMember = "Key";
            this.ComponentTypeDropDown.SelectionChangeCommitted += new System.EventHandler(this.ComponentTypeDropDown_SelectionChangeCommitted);
            this.ComponentTypeDropDown.Validating += new System.ComponentModel.CancelEventHandler(this.ComponentTypeDropDown_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(147, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(496, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // ComponentErrorProvider
            // 
            this.ComponentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ComponentErrorProvider.ContainerControl = this;
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 412);
            this.Controls.Add(this.ComponentTabControl);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ComponentRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentForm";
            this.ShowIcon = false;
            this.Text = "Komponenty";
            this.Load += new System.EventHandler(this.ComponentForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ComponentForm_VisibleChanged);
            this.ComponentRibbon.ResumeLayout(false);
            this.ComponentRibbon.PerformLayout();
            this.ComponentTabControl.ResumeLayout(false);
            this.ListingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.DetailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ComponentRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.TabControl ComponentTabControl;
        private System.Windows.Forms.TabPage ListingTab;
        private System.Windows.Forms.DataGridView ComponentGrid;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterNameTextBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.ComboBox FilterComponentTypeDropDown;
        private System.Windows.Forms.ComboBox ComponentTypeDropDown;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox FilterProductDropDown;
        private System.Windows.Forms.CheckBox FilterIsNotAssignedOnlyCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ComponentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrip_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_Quantity;
        private System.Windows.Forms.ErrorProvider ComponentErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ScaleString;
    }
}

