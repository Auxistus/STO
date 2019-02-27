namespace ManagementSystem.Catalog
{
    partial class ProductForm
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
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.FilterNameLabel = new System.Windows.Forms.Label();
            this.FilterScaleLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.ProductRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.ProductTabControl = new System.Windows.Forms.TabControl();
            this.ListingTab = new System.Windows.Forms.TabPage();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.ProductGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_ScaleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGrid_Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIDTextBox = new System.Windows.Forms.TextBox();
            this.FilterNameTextBox = new System.Windows.Forms.TextBox();
            this.FilterScaleNumeratorLabel = new System.Windows.Forms.Label();
            this.FilterScaleTextBox = new System.Windows.Forms.TextBox();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.ComponentGrid = new System.Windows.Forms.DataGridView();
            this.ComponentGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_ComponentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGrid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentRibbon = new System.Windows.Forms.ToolStrip();
            this.AddComponentButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveComponentButton = new System.Windows.Forms.ToolStripButton();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ScaleNumeratorLabel = new System.Windows.Forms.Label();
            this.ScaleTextBox = new System.Windows.Forms.TextBox();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.ProductErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductRibbon.SuspendLayout();
            this.ProductTabControl.SuspendLayout();
            this.ListingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.DetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).BeginInit();
            this.ComponentGridContextMenu.SuspendLayout();
            this.ComponentRibbon.SuspendLayout();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterIDLabel
            // 
            this.FilterIDLabel.AutoSize = true;
            this.FilterIDLabel.Location = new System.Drawing.Point(6, 21);
            this.FilterIDLabel.Name = "FilterIDLabel";
            this.FilterIDLabel.Size = new System.Drawing.Size(34, 13);
            this.FilterIDLabel.TabIndex = 9;
            this.FilterIDLabel.Text = "Číslo:";
            // 
            // FilterNameLabel
            // 
            this.FilterNameLabel.AutoSize = true;
            this.FilterNameLabel.Location = new System.Drawing.Point(123, 21);
            this.FilterNameLabel.Name = "FilterNameLabel";
            this.FilterNameLabel.Size = new System.Drawing.Size(41, 13);
            this.FilterNameLabel.TabIndex = 13;
            this.FilterNameLabel.Text = "Název:";
            // 
            // FilterScaleLabel
            // 
            this.FilterScaleLabel.AutoSize = true;
            this.FilterScaleLabel.Location = new System.Drawing.Point(290, 21);
            this.FilterScaleLabel.Name = "FilterScaleLabel";
            this.FilterScaleLabel.Size = new System.Drawing.Size(48, 13);
            this.FilterScaleLabel.TabIndex = 15;
            this.FilterScaleLabel.Text = "Měřítko:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(34, 13);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "Číslo:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(123, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Název:";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(290, 21);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(48, 13);
            this.ScaleLabel.TabIndex = 15;
            this.ScaleLabel.Text = "Měřítko:";
            // 
            // ProductRibbon
            // 
            this.ProductRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ProductRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ProductRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.NewButton,
            this.EditButton,
            this.SaveButton,
            this.CancelButton});
            this.ProductRibbon.Location = new System.Drawing.Point(0, 0);
            this.ProductRibbon.Name = "ProductRibbon";
            this.ProductRibbon.Size = new System.Drawing.Size(400, 38);
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
            // ProductTabControl
            // 
            this.ProductTabControl.Controls.Add(this.ListingTab);
            this.ProductTabControl.Controls.Add(this.DetailTab);
            this.ProductTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductTabControl.Location = new System.Drawing.Point(0, 49);
            this.ProductTabControl.Name = "ProductTabControl";
            this.ProductTabControl.SelectedIndex = 0;
            this.ProductTabControl.Size = new System.Drawing.Size(400, 344);
            this.ProductTabControl.TabIndex = 0;
            this.ProductTabControl.SelectedIndexChanged += new System.EventHandler(this.ProductTabControl_SelectedIndexChanged);
            this.ProductTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ProductTabControl_Selecting);
            // 
            // ListingTab
            // 
            this.ListingTab.Controls.Add(this.ProductGrid);
            this.ListingTab.Controls.Add(this.Filter);
            this.ListingTab.Location = new System.Drawing.Point(4, 22);
            this.ListingTab.Name = "ListingTab";
            this.ListingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListingTab.Size = new System.Drawing.Size(392, 318);
            this.ListingTab.TabIndex = 0;
            this.ListingTab.Text = "Seznam";
            this.ListingTab.UseVisualStyleBackColor = true;
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
            this.ProductGrid_ScaleString,
            this.ProductGrid_Scale});
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductGrid.Location = new System.Drawing.Point(3, 73);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.ShowCellToolTips = false;
            this.ProductGrid.Size = new System.Drawing.Size(386, 242);
            this.ProductGrid.TabIndex = 1;
            this.ProductGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGrid_CellClick);
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
            // ProductGrid_Scale
            // 
            this.ProductGrid_Scale.DataPropertyName = "Scale";
            this.ProductGrid_Scale.HeaderText = "Scale";
            this.ProductGrid_Scale.Name = "ProductGrid_Scale";
            this.ProductGrid_Scale.ReadOnly = true;
            this.ProductGrid_Scale.Visible = false;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIDLabel);
            this.Filter.Controls.Add(this.FilterIDTextBox);
            this.Filter.Controls.Add(this.FilterNameLabel);
            this.Filter.Controls.Add(this.FilterNameTextBox);
            this.Filter.Controls.Add(this.FilterScaleLabel);
            this.Filter.Controls.Add(this.FilterScaleNumeratorLabel);
            this.Filter.Controls.Add(this.FilterScaleTextBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(386, 70);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtr";
            // 
            // FilterIDTextBox
            // 
            this.FilterIDTextBox.Location = new System.Drawing.Point(9, 37);
            this.FilterIDTextBox.Name = "FilterIDTextBox";
            this.FilterIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterIDTextBox.TabIndex = 0;
            // 
            // FilterNameTextBox
            // 
            this.FilterNameTextBox.Location = new System.Drawing.Point(126, 37);
            this.FilterNameTextBox.Name = "FilterNameTextBox";
            this.FilterNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FilterNameTextBox.TabIndex = 1;
            // 
            // FilterScaleNumeratorLabel
            // 
            this.FilterScaleNumeratorLabel.Location = new System.Drawing.Point(293, 37);
            this.FilterScaleNumeratorLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.FilterScaleNumeratorLabel.Name = "FilterScaleNumeratorLabel";
            this.FilterScaleNumeratorLabel.Size = new System.Drawing.Size(19, 20);
            this.FilterScaleNumeratorLabel.TabIndex = 18;
            this.FilterScaleNumeratorLabel.Text = "1 :";
            this.FilterScaleNumeratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterScaleTextBox
            // 
            this.FilterScaleTextBox.Location = new System.Drawing.Point(312, 37);
            this.FilterScaleTextBox.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.FilterScaleTextBox.Name = "FilterScaleTextBox";
            this.FilterScaleTextBox.Size = new System.Drawing.Size(26, 20);
            this.FilterScaleTextBox.TabIndex = 2;
            // 
            // DetailTab
            // 
            this.DetailTab.AutoScroll = true;
            this.DetailTab.Controls.Add(this.ComponentGrid);
            this.DetailTab.Controls.Add(this.ComponentRibbon);
            this.DetailTab.Controls.Add(this.Detail);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(392, 318);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
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
            this.ComponentGrid.Location = new System.Drawing.Point(3, 98);
            this.ComponentGrid.Name = "ComponentGrid";
            this.ComponentGrid.ReadOnly = true;
            this.ComponentGrid.RowHeadersVisible = false;
            this.ComponentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentGrid.ShowCellToolTips = false;
            this.ComponentGrid.Size = new System.Drawing.Size(386, 217);
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
            this.ComponentGrid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ComponentGrid_Name.DataPropertyName = "Name";
            this.ComponentGrid_Name.HeaderText = "Název";
            this.ComponentGrid_Name.MinimumWidth = 150;
            this.ComponentGrid_Name.Name = "ComponentGrid_Name";
            this.ComponentGrid_Name.ReadOnly = true;
            this.ComponentGrid_Name.Width = 150;
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
            // ComponentRibbon
            // 
            this.ComponentRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddComponentButton,
            this.RemoveComponentButton});
            this.ComponentRibbon.Location = new System.Drawing.Point(3, 73);
            this.ComponentRibbon.Name = "ComponentRibbon";
            this.ComponentRibbon.Size = new System.Drawing.Size(386, 25);
            this.ComponentRibbon.TabIndex = 16;
            this.ComponentRibbon.Text = "SubMenu";
            // 
            // AddComponentButton
            // 
            this.AddComponentButton.AutoToolTip = false;
            this.AddComponentButton.Enabled = false;
            this.AddComponentButton.Image = global::ManagementSystem.Properties.Resources.AddSmall;
            this.AddComponentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddComponentButton.Name = "AddComponentButton";
            this.AddComponentButton.Size = new System.Drawing.Size(130, 22);
            this.AddComponentButton.Text = "Přidat komponentu";
            this.AddComponentButton.Click += new System.EventHandler(this.AddComponentButton_Click);
            // 
            // RemoveComponentButton
            // 
            this.RemoveComponentButton.AutoToolTip = false;
            this.RemoveComponentButton.Enabled = false;
            this.RemoveComponentButton.Image = global::ManagementSystem.Properties.Resources.RemoveSmall;
            this.RemoveComponentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveComponentButton.Name = "RemoveComponentButton";
            this.RemoveComponentButton.Size = new System.Drawing.Size(142, 22);
            this.RemoveComponentButton.Text = "Odebrat komponentu";
            this.RemoveComponentButton.Click += new System.EventHandler(this.RemoveComponentButton_Click);
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.IDLabel);
            this.Detail.Controls.Add(this.IDTextBox);
            this.Detail.Controls.Add(this.NameLabel);
            this.Detail.Controls.Add(this.NameTextBox);
            this.Detail.Controls.Add(this.ScaleLabel);
            this.Detail.Controls.Add(this.ScaleNumeratorLabel);
            this.Detail.Controls.Add(this.ScaleTextBox);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail.Location = new System.Drawing.Point(3, 3);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(386, 70);
            this.Detail.TabIndex = 0;
            this.Detail.TabStop = false;
            this.Detail.Text = "Produkt";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(9, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IDTextBox_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(126, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // ScaleNumeratorLabel
            // 
            this.ScaleNumeratorLabel.Location = new System.Drawing.Point(293, 37);
            this.ScaleNumeratorLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ScaleNumeratorLabel.Name = "ScaleNumeratorLabel";
            this.ScaleNumeratorLabel.Size = new System.Drawing.Size(19, 20);
            this.ScaleNumeratorLabel.TabIndex = 18;
            this.ScaleNumeratorLabel.Text = "1 :";
            this.ScaleNumeratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScaleTextBox
            // 
            this.ScaleTextBox.Location = new System.Drawing.Point(312, 37);
            this.ScaleTextBox.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.ScaleTextBox.Name = "ScaleTextBox";
            this.ScaleTextBox.Size = new System.Drawing.Size(26, 20);
            this.ScaleTextBox.TabIndex = 2;
            this.ScaleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ScaleTextBox_Validating);
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(400, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // ProductErrorProvider
            // 
            this.ProductErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ProductErrorProvider.ContainerControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 393);
            this.Controls.Add(this.ProductTabControl);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ProductRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.ShowIcon = false;
            this.Text = "Produkty";
            this.VisibleChanged += new System.EventHandler(this.ProductForm_VisibleChanged);
            this.ProductRibbon.ResumeLayout(false);
            this.ProductRibbon.PerformLayout();
            this.ProductTabControl.ResumeLayout(false);
            this.ListingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentGrid)).EndInit();
            this.ComponentGridContextMenu.ResumeLayout(false);
            this.ComponentRibbon.ResumeLayout(false);
            this.ComponentRibbon.PerformLayout();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ProductRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.TabControl ProductTabControl;
        private System.Windows.Forms.TabPage ListingTab;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterIDTextBox;
        private System.Windows.Forms.TextBox FilterNameTextBox;
        private System.Windows.Forms.Label FilterScaleNumeratorLabel;
        private System.Windows.Forms.TextBox FilterScaleTextBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ScaleNumeratorLabel;
        private System.Windows.Forms.TextBox ScaleTextBox;
        private System.Windows.Forms.DataGridView ComponentGrid;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.ToolStrip ComponentRibbon;
        private System.Windows.Forms.ToolStripButton AddComponentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_ScaleString;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGrid_Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_ComponentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentGrid_Quantity;
        private System.Windows.Forms.ToolStripButton RemoveComponentButton;
        private System.Windows.Forms.ContextMenuStrip ComponentGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.Label FilterNameLabel;
        private System.Windows.Forms.Label FilterScaleLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.ErrorProvider ProductErrorProvider;
    }
}

