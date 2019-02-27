namespace ManagementSystem.Stock
{
    partial class InventoryForm
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
            System.Windows.Forms.Label FilterComponentLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.FilterEnteredFromLabel = new System.Windows.Forms.Label();
            this.InventoryRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ApproveButton = new System.Windows.Forms.ToolStripButton();
            this.InventoryTabControl = new System.Windows.Forms.TabControl();
            this.ListingTab = new System.Windows.Forms.TabPage();
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.InventoryGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryGrid_Entered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryGrid_IsApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIDTextBox = new System.Windows.Forms.TextBox();
            this.FilterComponentDropDown = new System.Windows.Forms.ComboBox();
            this.FilterEnteredFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterEnteredToLabel = new System.Windows.Forms.Label();
            this.FilterEnteredToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterIsNotApprovedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.InventoryItemGrid = new System.Windows.Forms.DataGridView();
            this.InventoryItemGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryItemRibbon = new System.Windows.Forms.ToolStrip();
            this.AddInventoryItemButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveInventoryItemButton = new System.Windows.Forms.ToolStripButton();
            this.SaveInventoryItemButton = new System.Windows.Forms.ToolStripButton();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EnteredLabel = new System.Windows.Forms.Label();
            this.EnteredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.InventoryErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.InventoryItemGrid_InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_ComponentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_ActualQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItemGrid_TotalDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FilterComponentLabel = new System.Windows.Forms.Label();
            this.InventoryRibbon.SuspendLayout();
            this.InventoryTabControl.SuspendLayout();
            this.ListingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.DetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryItemGrid)).BeginInit();
            this.InventoryItemGridContextMenu.SuspendLayout();
            this.InventoryItemRibbon.SuspendLayout();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterComponentLabel
            // 
            FilterComponentLabel.AutoSize = true;
            FilterComponentLabel.Location = new System.Drawing.Point(123, 21);
            FilterComponentLabel.Name = "FilterComponentLabel";
            FilterComponentLabel.Size = new System.Drawing.Size(70, 13);
            FilterComponentLabel.TabIndex = 24;
            FilterComponentLabel.Text = "Komponenta:";
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
            // FilterEnteredFromLabel
            // 
            this.FilterEnteredFromLabel.AutoSize = true;
            this.FilterEnteredFromLabel.Location = new System.Drawing.Point(6, 61);
            this.FilterEnteredFromLabel.Name = "FilterEnteredFromLabel";
            this.FilterEnteredFromLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterEnteredFromLabel.TabIndex = 15;
            this.FilterEnteredFromLabel.Text = "Datum od:";
            // 
            // InventoryRibbon
            // 
            this.InventoryRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.InventoryRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.InventoryRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.NewButton,
            this.EditButton,
            this.SaveButton,
            this.CancelButton,
            this.Separator2,
            this.ApproveButton});
            this.InventoryRibbon.Location = new System.Drawing.Point(0, 0);
            this.InventoryRibbon.Name = "InventoryRibbon";
            this.InventoryRibbon.Size = new System.Drawing.Size(565, 38);
            this.InventoryRibbon.TabIndex = 10;
            this.InventoryRibbon.Text = "Menu";
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
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 38);
            // 
            // ApproveButton
            // 
            this.ApproveButton.AutoSize = false;
            this.ApproveButton.AutoToolTip = false;
            this.ApproveButton.Enabled = false;
            this.ApproveButton.Image = global::ManagementSystem.Properties.Resources.ApproveSmall;
            this.ApproveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ApproveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(50, 35);
            this.ApproveButton.Text = "Schválit";
            this.ApproveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ApproveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // InventoryTabControl
            // 
            this.InventoryTabControl.Controls.Add(this.ListingTab);
            this.InventoryTabControl.Controls.Add(this.DetailTab);
            this.InventoryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryTabControl.Location = new System.Drawing.Point(0, 49);
            this.InventoryTabControl.Name = "InventoryTabControl";
            this.InventoryTabControl.SelectedIndex = 0;
            this.InventoryTabControl.Size = new System.Drawing.Size(565, 417);
            this.InventoryTabControl.TabIndex = 0;
            this.InventoryTabControl.SelectedIndexChanged += new System.EventHandler(this.InventoryTabControl_SelectedIndexChanged);
            this.InventoryTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.InventoryTabControl_Selecting);
            // 
            // ListingTab
            // 
            this.ListingTab.Controls.Add(this.InventoryGrid);
            this.ListingTab.Controls.Add(this.Filter);
            this.ListingTab.Location = new System.Drawing.Point(4, 22);
            this.ListingTab.Name = "ListingTab";
            this.ListingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListingTab.Size = new System.Drawing.Size(424, 366);
            this.ListingTab.TabIndex = 0;
            this.ListingTab.Text = "Seznam";
            this.ListingTab.UseVisualStyleBackColor = true;
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToAddRows = false;
            this.InventoryGrid.AllowUserToDeleteRows = false;
            this.InventoryGrid.AllowUserToOrderColumns = true;
            this.InventoryGrid.AllowUserToResizeRows = false;
            this.InventoryGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryGrid_ID,
            this.InventoryGrid_Entered,
            this.InventoryGrid_IsApproved});
            this.InventoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryGrid.Location = new System.Drawing.Point(3, 113);
            this.InventoryGrid.MultiSelect = false;
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersVisible = false;
            this.InventoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGrid.ShowCellToolTips = false;
            this.InventoryGrid.Size = new System.Drawing.Size(418, 250);
            this.InventoryGrid.TabIndex = 1;
            this.InventoryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGrid_CellClick);
            // 
            // InventoryGrid_ID
            // 
            this.InventoryGrid_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryGrid_ID.DataPropertyName = "ID";
            this.InventoryGrid_ID.HeaderText = "Číslo";
            this.InventoryGrid_ID.MinimumWidth = 60;
            this.InventoryGrid_ID.Name = "InventoryGrid_ID";
            this.InventoryGrid_ID.ReadOnly = true;
            this.InventoryGrid_ID.Width = 60;
            // 
            // InventoryGrid_Entered
            // 
            this.InventoryGrid_Entered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryGrid_Entered.DataPropertyName = "Entered";
            this.InventoryGrid_Entered.HeaderText = "Datum";
            this.InventoryGrid_Entered.MinimumWidth = 80;
            this.InventoryGrid_Entered.Name = "InventoryGrid_Entered";
            this.InventoryGrid_Entered.ReadOnly = true;
            this.InventoryGrid_Entered.Width = 80;
            // 
            // InventoryGrid_IsApproved
            // 
            this.InventoryGrid_IsApproved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InventoryGrid_IsApproved.DataPropertyName = "IsApproved";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.InventoryGrid_IsApproved.DefaultCellStyle = dataGridViewCellStyle3;
            this.InventoryGrid_IsApproved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InventoryGrid_IsApproved.HeaderText = "Schváleno";
            this.InventoryGrid_IsApproved.Name = "InventoryGrid_IsApproved";
            this.InventoryGrid_IsApproved.ReadOnly = true;
            this.InventoryGrid_IsApproved.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGrid_IsApproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIDLabel);
            this.Filter.Controls.Add(this.FilterIDTextBox);
            this.Filter.Controls.Add(FilterComponentLabel);
            this.Filter.Controls.Add(this.FilterComponentDropDown);
            this.Filter.Controls.Add(this.FilterEnteredFromLabel);
            this.Filter.Controls.Add(this.FilterEnteredFromDatePicker);
            this.Filter.Controls.Add(this.FilterEnteredToLabel);
            this.Filter.Controls.Add(this.FilterEnteredToDatePicker);
            this.Filter.Controls.Add(this.FilterIsNotApprovedOnlyCheckBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(418, 110);
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
            // FilterComponentDropDown
            // 
            this.FilterComponentDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterComponentDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterComponentDropDown.DisplayMember = "Value";
            this.FilterComponentDropDown.FormattingEnabled = true;
            this.FilterComponentDropDown.Location = new System.Drawing.Point(126, 37);
            this.FilterComponentDropDown.Name = "FilterComponentDropDown";
            this.FilterComponentDropDown.Size = new System.Drawing.Size(150, 21);
            this.FilterComponentDropDown.TabIndex = 1;
            this.FilterComponentDropDown.ValueMember = "Key";
            // 
            // FilterEnteredFromDatePicker
            // 
            this.FilterEnteredFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterEnteredFromDatePicker.Location = new System.Drawing.Point(9, 77);
            this.FilterEnteredFromDatePicker.Name = "FilterEnteredFromDatePicker";
            this.FilterEnteredFromDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterEnteredFromDatePicker.TabIndex = 3;
            // 
            // FilterEnteredToLabel
            // 
            this.FilterEnteredToLabel.AutoSize = true;
            this.FilterEnteredToLabel.Location = new System.Drawing.Point(123, 61);
            this.FilterEnteredToLabel.Name = "FilterEnteredToLabel";
            this.FilterEnteredToLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterEnteredToLabel.TabIndex = 17;
            this.FilterEnteredToLabel.Text = "Datum do:";
            // 
            // FilterEnteredToDatePicker
            // 
            this.FilterEnteredToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterEnteredToDatePicker.Location = new System.Drawing.Point(126, 77);
            this.FilterEnteredToDatePicker.Name = "FilterEnteredToDatePicker";
            this.FilterEnteredToDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterEnteredToDatePicker.TabIndex = 4;
            // 
            // FilterIsNotApprovedOnlyCheckBox
            // 
            this.FilterIsNotApprovedOnlyCheckBox.AutoSize = true;
            this.FilterIsNotApprovedOnlyCheckBox.Location = new System.Drawing.Point(293, 37);
            this.FilterIsNotApprovedOnlyCheckBox.Name = "FilterIsNotApprovedOnlyCheckBox";
            this.FilterIsNotApprovedOnlyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.FilterIsNotApprovedOnlyCheckBox.TabIndex = 2;
            this.FilterIsNotApprovedOnlyCheckBox.Text = "Jen neschválené";
            this.FilterIsNotApprovedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // DetailTab
            // 
            this.DetailTab.AutoScroll = true;
            this.DetailTab.Controls.Add(this.InventoryItemGrid);
            this.DetailTab.Controls.Add(this.InventoryItemRibbon);
            this.DetailTab.Controls.Add(this.Detail);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(557, 391);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // InventoryItemGrid
            // 
            this.InventoryItemGrid.AllowUserToAddRows = false;
            this.InventoryItemGrid.AllowUserToDeleteRows = false;
            this.InventoryItemGrid.AllowUserToOrderColumns = true;
            this.InventoryItemGrid.AllowUserToResizeRows = false;
            this.InventoryItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InventoryItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryItemGrid_InventoryID,
            this.InventoryItemGrid_Order,
            this.InventoryItemGrid_ComponentTypeName,
            this.InventoryItemGrid_ComponentName,
            this.InventoryItemGrid_StockQuantity,
            this.InventoryItemGrid_ActualQuantity,
            this.InventoryItemGrid_TotalDifference});
            this.InventoryItemGrid.ContextMenuStrip = this.InventoryItemGridContextMenu;
            this.InventoryItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryItemGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.InventoryItemGrid.Location = new System.Drawing.Point(3, 98);
            this.InventoryItemGrid.Name = "InventoryItemGrid";
            this.InventoryItemGrid.RowHeadersVisible = false;
            this.InventoryItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryItemGrid.ShowCellToolTips = false;
            this.InventoryItemGrid.Size = new System.Drawing.Size(551, 290);
            this.InventoryItemGrid.TabIndex = 1;
            this.InventoryItemGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.InventoryItemGrid_CellBeginEdit);
            this.InventoryItemGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryItemGrid_CellEndEdit);
            this.InventoryItemGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.InventoryItemGrid_CellPainting);
            this.InventoryItemGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryItemGrid_CellValidated);
            this.InventoryItemGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.InventoryItemGrid_CellValidating);
            this.InventoryItemGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InventoryItemGrid_EditingControlShowing);
            this.InventoryItemGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.InventoryItemGrid_RowStateChanged);
            // 
            // InventoryItemGridContextMenu
            // 
            this.InventoryItemGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllContextMenuItem});
            this.InventoryItemGridContextMenu.Name = "InventoryItemGridContextMenu";
            this.InventoryItemGridContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // SelectAllContextMenuItem
            // 
            this.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem";
            this.SelectAllContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SelectAllContextMenuItem.Text = "Vybrat vše";
            this.SelectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // InventoryItemRibbon
            // 
            this.InventoryItemRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.InventoryItemRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.InventoryItemRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInventoryItemButton,
            this.RemoveInventoryItemButton,
            this.SaveInventoryItemButton});
            this.InventoryItemRibbon.Location = new System.Drawing.Point(3, 73);
            this.InventoryItemRibbon.Name = "InventoryItemRibbon";
            this.InventoryItemRibbon.Size = new System.Drawing.Size(551, 25);
            this.InventoryItemRibbon.TabIndex = 16;
            this.InventoryItemRibbon.Text = "SubMenu";
            // 
            // AddInventoryItemButton
            // 
            this.AddInventoryItemButton.AutoToolTip = false;
            this.AddInventoryItemButton.Enabled = false;
            this.AddInventoryItemButton.Image = global::ManagementSystem.Properties.Resources.AddSmall;
            this.AddInventoryItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddInventoryItemButton.Name = "AddInventoryItemButton";
            this.AddInventoryItemButton.Size = new System.Drawing.Size(103, 22);
            this.AddInventoryItemButton.Text = "Přidat položku";
            this.AddInventoryItemButton.Click += new System.EventHandler(this.AddInventoryItemButton_Click);
            // 
            // RemoveInventoryItemButton
            // 
            this.RemoveInventoryItemButton.AutoToolTip = false;
            this.RemoveInventoryItemButton.Enabled = false;
            this.RemoveInventoryItemButton.Image = global::ManagementSystem.Properties.Resources.RemoveSmall;
            this.RemoveInventoryItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveInventoryItemButton.Name = "RemoveInventoryItemButton";
            this.RemoveInventoryItemButton.Size = new System.Drawing.Size(115, 22);
            this.RemoveInventoryItemButton.Text = "Odebrat položku";
            this.RemoveInventoryItemButton.Click += new System.EventHandler(this.RemoveInventoryItemButton_Click);
            // 
            // SaveInventoryItemButton
            // 
            this.SaveInventoryItemButton.AutoToolTip = false;
            this.SaveInventoryItemButton.Enabled = false;
            this.SaveInventoryItemButton.Image = global::ManagementSystem.Properties.Resources.SaveSmall;
            this.SaveInventoryItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveInventoryItemButton.Name = "SaveInventoryItemButton";
            this.SaveInventoryItemButton.Size = new System.Drawing.Size(95, 22);
            this.SaveInventoryItemButton.Text = "Uložit změny";
            this.SaveInventoryItemButton.Click += new System.EventHandler(this.SaveInventoryItemButton_Click);
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.IDLabel);
            this.Detail.Controls.Add(this.IDTextBox);
            this.Detail.Controls.Add(this.EnteredLabel);
            this.Detail.Controls.Add(this.EnteredDatePicker);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail.Location = new System.Drawing.Point(3, 3);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(551, 70);
            this.Detail.TabIndex = 0;
            this.Detail.TabStop = false;
            this.Detail.Text = "Příjemka";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(34, 13);
            this.IDLabel.TabIndex = 28;
            this.IDLabel.Text = "Číslo:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(9, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 0;
            // 
            // EnteredLabel
            // 
            this.EnteredLabel.AutoSize = true;
            this.EnteredLabel.Location = new System.Drawing.Point(123, 21);
            this.EnteredLabel.Name = "EnteredLabel";
            this.EnteredLabel.Size = new System.Drawing.Size(41, 13);
            this.EnteredLabel.TabIndex = 15;
            this.EnteredLabel.Text = "Datum:";
            // 
            // EnteredDatePicker
            // 
            this.EnteredDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnteredDatePicker.Location = new System.Drawing.Point(126, 37);
            this.EnteredDatePicker.Name = "EnteredDatePicker";
            this.EnteredDatePicker.Size = new System.Drawing.Size(100, 20);
            this.EnteredDatePicker.TabIndex = 1;
            this.EnteredDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.EnteredDatePicker_Validating);
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(565, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // InventoryErrorProvider
            // 
            this.InventoryErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.InventoryErrorProvider.ContainerControl = this;
            // 
            // InventoryItemGrid_InventoryID
            // 
            this.InventoryItemGrid_InventoryID.DataPropertyName = "InventoryID";
            this.InventoryItemGrid_InventoryID.HeaderText = "InventoryID";
            this.InventoryItemGrid_InventoryID.Name = "InventoryItemGrid_InventoryID";
            this.InventoryItemGrid_InventoryID.Visible = false;
            // 
            // InventoryItemGrid_Order
            // 
            this.InventoryItemGrid_Order.DataPropertyName = "Order";
            this.InventoryItemGrid_Order.HeaderText = "Order";
            this.InventoryItemGrid_Order.Name = "InventoryItemGrid_Order";
            this.InventoryItemGrid_Order.Visible = false;
            // 
            // InventoryItemGrid_ComponentTypeName
            // 
            this.InventoryItemGrid_ComponentTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryItemGrid_ComponentTypeName.DataPropertyName = "ComponentTypeName";
            this.InventoryItemGrid_ComponentTypeName.HeaderText = "Typ komponenty";
            this.InventoryItemGrid_ComponentTypeName.MinimumWidth = 110;
            this.InventoryItemGrid_ComponentTypeName.Name = "InventoryItemGrid_ComponentTypeName";
            this.InventoryItemGrid_ComponentTypeName.ReadOnly = true;
            this.InventoryItemGrid_ComponentTypeName.Width = 110;
            // 
            // InventoryItemGrid_ComponentName
            // 
            this.InventoryItemGrid_ComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryItemGrid_ComponentName.DataPropertyName = "ComponentName";
            this.InventoryItemGrid_ComponentName.HeaderText = "Komponenta";
            this.InventoryItemGrid_ComponentName.MinimumWidth = 150;
            this.InventoryItemGrid_ComponentName.Name = "InventoryItemGrid_ComponentName";
            this.InventoryItemGrid_ComponentName.ReadOnly = true;
            this.InventoryItemGrid_ComponentName.Width = 150;
            // 
            // InventoryItemGrid_StockQuantity
            // 
            this.InventoryItemGrid_StockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryItemGrid_StockQuantity.DataPropertyName = "StockQuantity";
            this.InventoryItemGrid_StockQuantity.HeaderText = "Skladové mn.";
            this.InventoryItemGrid_StockQuantity.MinimumWidth = 100;
            this.InventoryItemGrid_StockQuantity.Name = "InventoryItemGrid_StockQuantity";
            this.InventoryItemGrid_StockQuantity.ReadOnly = true;
            // 
            // InventoryItemGrid_ActualQuantity
            // 
            this.InventoryItemGrid_ActualQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryItemGrid_ActualQuantity.DataPropertyName = "ActualQuantity";
            this.InventoryItemGrid_ActualQuantity.HeaderText = "Skutečné mn.";
            this.InventoryItemGrid_ActualQuantity.MinimumWidth = 100;
            this.InventoryItemGrid_ActualQuantity.Name = "InventoryItemGrid_ActualQuantity";
            // 
            // InventoryItemGrid_TotalDifference
            // 
            this.InventoryItemGrid_TotalDifference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InventoryItemGrid_TotalDifference.DataPropertyName = "TotalDifference";
            this.InventoryItemGrid_TotalDifference.HeaderText = "Rozdíl";
            this.InventoryItemGrid_TotalDifference.MinimumWidth = 50;
            this.InventoryItemGrid_TotalDifference.Name = "InventoryItemGrid_TotalDifference";
            this.InventoryItemGrid_TotalDifference.ReadOnly = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 466);
            this.Controls.Add(this.InventoryTabControl);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.InventoryRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.ShowIcon = false;
            this.Text = "Inventury";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.VisibleChanged += new System.EventHandler(this.InventoryForm_VisibleChanged);
            this.InventoryRibbon.ResumeLayout(false);
            this.InventoryRibbon.PerformLayout();
            this.InventoryTabControl.ResumeLayout(false);
            this.ListingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryItemGrid)).EndInit();
            this.InventoryItemGridContextMenu.ResumeLayout(false);
            this.InventoryItemRibbon.ResumeLayout(false);
            this.InventoryItemRibbon.PerformLayout();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip InventoryRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.TabControl InventoryTabControl;
        private System.Windows.Forms.TabPage ListingTab;
        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterIDTextBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.DataGridView InventoryItemGrid;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.ToolStrip InventoryItemRibbon;
        private System.Windows.Forms.ToolStripButton AddInventoryItemButton;
        private System.Windows.Forms.ToolStripButton RemoveInventoryItemButton;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.Label FilterEnteredFromLabel;
        private System.Windows.Forms.ErrorProvider InventoryErrorProvider;
        private System.Windows.Forms.Label FilterEnteredToLabel;
        private System.Windows.Forms.ComboBox FilterComponentDropDown;
        private System.Windows.Forms.DateTimePicker FilterEnteredToDatePicker;
        private System.Windows.Forms.DateTimePicker FilterEnteredFromDatePicker;
        private System.Windows.Forms.DateTimePicker EnteredDatePicker;
        private System.Windows.Forms.Label EnteredLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripButton ApproveButton;
        private System.Windows.Forms.CheckBox FilterIsNotApprovedOnlyCheckBox;
        private System.Windows.Forms.ContextMenuStrip InventoryItemGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.ToolStripButton SaveInventoryItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryGrid_Entered;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InventoryGrid_IsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_ComponentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_StockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_ActualQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemGrid_TotalDifference;
    }
}

