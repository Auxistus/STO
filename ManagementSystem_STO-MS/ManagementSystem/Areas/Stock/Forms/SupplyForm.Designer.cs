namespace ManagementSystem.Stock
{
    partial class SupplyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.FilterSupplierNameLabel = new System.Windows.Forms.Label();
            this.FilterDeliveredFromLabel = new System.Windows.Forms.Label();
            this.SupplyRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ApproveButton = new System.Windows.Forms.ToolStripButton();
            this.SupplyTabControl = new System.Windows.Forms.TabControl();
            this.ListingTab = new System.Windows.Forms.TabPage();
            this.SupplyGrid = new System.Windows.Forms.DataGridView();
            this.SupplyGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyGrid_Delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyGrid_SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyGrid_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyGrid_IsApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIsNotApprovedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterIDTextBox = new System.Windows.Forms.TextBox();
            this.FilterSupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.FilterComponentDropDown = new System.Windows.Forms.ComboBox();
            this.FilterDeliveredFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterDeliveredToLabel = new System.Windows.Forms.Label();
            this.FilterDeliveredToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.SupplyItemGrid = new System.Windows.Forms.DataGridView();
            this.SupplyItemGrid_SupplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyItemGrid_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyItemGrid_ComponentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyItemGrid_ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyItemGrid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyItemGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupplyItemRibbon = new System.Windows.Forms.ToolStrip();
            this.AddSupplyItemButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveSupplyItemButton = new System.Windows.Forms.ToolStripButton();
            this.SaveSupplyItemButton = new System.Windows.Forms.ToolStripButton();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DeliveredLabel = new System.Windows.Forms.Label();
            this.DeliveredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.SupplyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            FilterComponentLabel = new System.Windows.Forms.Label();
            this.SupplyRibbon.SuspendLayout();
            this.SupplyTabControl.SuspendLayout();
            this.ListingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.DetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyItemGrid)).BeginInit();
            this.SupplyItemGridContextMenu.SuspendLayout();
            this.SupplyItemRibbon.SuspendLayout();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterComponentLabel
            // 
            FilterComponentLabel.AutoSize = true;
            FilterComponentLabel.Location = new System.Drawing.Point(290, 20);
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
            // FilterSupplierNameLabel
            // 
            this.FilterSupplierNameLabel.AutoSize = true;
            this.FilterSupplierNameLabel.Location = new System.Drawing.Point(123, 21);
            this.FilterSupplierNameLabel.Name = "FilterSupplierNameLabel";
            this.FilterSupplierNameLabel.Size = new System.Drawing.Size(59, 13);
            this.FilterSupplierNameLabel.TabIndex = 13;
            this.FilterSupplierNameLabel.Text = "Dodavatel:";
            // 
            // FilterDeliveredFromLabel
            // 
            this.FilterDeliveredFromLabel.AutoSize = true;
            this.FilterDeliveredFromLabel.Location = new System.Drawing.Point(6, 61);
            this.FilterDeliveredFromLabel.Name = "FilterDeliveredFromLabel";
            this.FilterDeliveredFromLabel.Size = new System.Drawing.Size(63, 13);
            this.FilterDeliveredFromLabel.TabIndex = 15;
            this.FilterDeliveredFromLabel.Text = "Dodáno od:";
            // 
            // SupplyRibbon
            // 
            this.SupplyRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.SupplyRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SupplyRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.NewButton,
            this.EditButton,
            this.SaveButton,
            this.CancelButton,
            this.Separator2,
            this.ApproveButton});
            this.SupplyRibbon.Location = new System.Drawing.Point(0, 0);
            this.SupplyRibbon.Name = "SupplyRibbon";
            this.SupplyRibbon.Size = new System.Drawing.Size(477, 38);
            this.SupplyRibbon.TabIndex = 10;
            this.SupplyRibbon.Text = "Menu";
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
            // SupplyTabControl
            // 
            this.SupplyTabControl.Controls.Add(this.ListingTab);
            this.SupplyTabControl.Controls.Add(this.DetailTab);
            this.SupplyTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplyTabControl.Location = new System.Drawing.Point(0, 49);
            this.SupplyTabControl.Name = "SupplyTabControl";
            this.SupplyTabControl.SelectedIndex = 0;
            this.SupplyTabControl.Size = new System.Drawing.Size(477, 392);
            this.SupplyTabControl.TabIndex = 0;
            this.SupplyTabControl.SelectedIndexChanged += new System.EventHandler(this.SupplyTabControl_SelectedIndexChanged);
            this.SupplyTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SupplyTabControl_Selecting);
            // 
            // ListingTab
            // 
            this.ListingTab.Controls.Add(this.SupplyGrid);
            this.ListingTab.Controls.Add(this.Filter);
            this.ListingTab.Location = new System.Drawing.Point(4, 22);
            this.ListingTab.Name = "ListingTab";
            this.ListingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListingTab.Size = new System.Drawing.Size(469, 366);
            this.ListingTab.TabIndex = 0;
            this.ListingTab.Text = "Seznam";
            this.ListingTab.UseVisualStyleBackColor = true;
            // 
            // SupplyGrid
            // 
            this.SupplyGrid.AllowUserToAddRows = false;
            this.SupplyGrid.AllowUserToDeleteRows = false;
            this.SupplyGrid.AllowUserToOrderColumns = true;
            this.SupplyGrid.AllowUserToResizeRows = false;
            this.SupplyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SupplyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyGrid_ID,
            this.SupplyGrid_Delivered,
            this.SupplyGrid_SupplierName,
            this.SupplyGrid_Description,
            this.SupplyGrid_IsApproved});
            this.SupplyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplyGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SupplyGrid.Location = new System.Drawing.Point(3, 113);
            this.SupplyGrid.MultiSelect = false;
            this.SupplyGrid.Name = "SupplyGrid";
            this.SupplyGrid.ReadOnly = true;
            this.SupplyGrid.RowHeadersVisible = false;
            this.SupplyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplyGrid.ShowCellToolTips = false;
            this.SupplyGrid.Size = new System.Drawing.Size(463, 250);
            this.SupplyGrid.TabIndex = 1;
            this.SupplyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyGrid_CellClick);
            // 
            // SupplyGrid_ID
            // 
            this.SupplyGrid_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplyGrid_ID.DataPropertyName = "ID";
            this.SupplyGrid_ID.HeaderText = "Číslo";
            this.SupplyGrid_ID.MinimumWidth = 60;
            this.SupplyGrid_ID.Name = "SupplyGrid_ID";
            this.SupplyGrid_ID.ReadOnly = true;
            this.SupplyGrid_ID.Width = 60;
            // 
            // SupplyGrid_Delivered
            // 
            this.SupplyGrid_Delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplyGrid_Delivered.DataPropertyName = "Delivered";
            this.SupplyGrid_Delivered.HeaderText = "Datum";
            this.SupplyGrid_Delivered.MinimumWidth = 80;
            this.SupplyGrid_Delivered.Name = "SupplyGrid_Delivered";
            this.SupplyGrid_Delivered.ReadOnly = true;
            this.SupplyGrid_Delivered.Width = 80;
            // 
            // SupplyGrid_SupplierName
            // 
            this.SupplyGrid_SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplyGrid_SupplierName.DataPropertyName = "SupplierName";
            this.SupplyGrid_SupplierName.HeaderText = "Dodavatel";
            this.SupplyGrid_SupplierName.MinimumWidth = 150;
            this.SupplyGrid_SupplierName.Name = "SupplyGrid_SupplierName";
            this.SupplyGrid_SupplierName.ReadOnly = true;
            this.SupplyGrid_SupplierName.Width = 150;
            // 
            // SupplyGrid_Description
            // 
            this.SupplyGrid_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SupplyGrid_Description.DataPropertyName = "Description";
            this.SupplyGrid_Description.HeaderText = "Popis";
            this.SupplyGrid_Description.MinimumWidth = 100;
            this.SupplyGrid_Description.Name = "SupplyGrid_Description";
            this.SupplyGrid_Description.ReadOnly = true;
            // 
            // SupplyGrid_IsApproved
            // 
            this.SupplyGrid_IsApproved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplyGrid_IsApproved.DataPropertyName = "IsApproved";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SupplyGrid_IsApproved.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplyGrid_IsApproved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SupplyGrid_IsApproved.HeaderText = "Schváleno";
            this.SupplyGrid_IsApproved.Name = "SupplyGrid_IsApproved";
            this.SupplyGrid_IsApproved.ReadOnly = true;
            this.SupplyGrid_IsApproved.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplyGrid_IsApproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIDLabel);
            this.Filter.Controls.Add(this.FilterIDTextBox);
            this.Filter.Controls.Add(this.FilterSupplierNameLabel);
            this.Filter.Controls.Add(this.FilterSupplierNameTextBox);
            this.Filter.Controls.Add(FilterComponentLabel);
            this.Filter.Controls.Add(this.FilterComponentDropDown);
            this.Filter.Controls.Add(this.FilterDeliveredFromLabel);
            this.Filter.Controls.Add(this.FilterDeliveredFromDatePicker);
            this.Filter.Controls.Add(this.FilterDeliveredToLabel);
            this.Filter.Controls.Add(this.FilterDeliveredToDatePicker);
            this.Filter.Controls.Add(this.FilterIsNotApprovedOnlyCheckBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(463, 110);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtr";
            // 
            // FilterIsNotApprovedOnlyCheckBox
            // 
            this.FilterIsNotApprovedOnlyCheckBox.AutoSize = true;
            this.FilterIsNotApprovedOnlyCheckBox.Location = new System.Drawing.Point(293, 77);
            this.FilterIsNotApprovedOnlyCheckBox.Name = "FilterIsNotApprovedOnlyCheckBox";
            this.FilterIsNotApprovedOnlyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.FilterIsNotApprovedOnlyCheckBox.TabIndex = 5;
            this.FilterIsNotApprovedOnlyCheckBox.Text = "Jen neschválené";
            this.FilterIsNotApprovedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterIDTextBox
            // 
            this.FilterIDTextBox.Location = new System.Drawing.Point(9, 37);
            this.FilterIDTextBox.Name = "FilterIDTextBox";
            this.FilterIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterIDTextBox.TabIndex = 0;
            // 
            // FilterSupplierNameTextBox
            // 
            this.FilterSupplierNameTextBox.Location = new System.Drawing.Point(126, 37);
            this.FilterSupplierNameTextBox.Name = "FilterSupplierNameTextBox";
            this.FilterSupplierNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FilterSupplierNameTextBox.TabIndex = 1;
            // 
            // FilterComponentDropDown
            // 
            this.FilterComponentDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterComponentDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterComponentDropDown.DisplayMember = "Value";
            this.FilterComponentDropDown.FormattingEnabled = true;
            this.FilterComponentDropDown.Location = new System.Drawing.Point(293, 36);
            this.FilterComponentDropDown.Name = "FilterComponentDropDown";
            this.FilterComponentDropDown.Size = new System.Drawing.Size(150, 21);
            this.FilterComponentDropDown.TabIndex = 2;
            this.FilterComponentDropDown.ValueMember = "Key";
            // 
            // FilterDeliveredFromDatePicker
            // 
            this.FilterDeliveredFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterDeliveredFromDatePicker.Location = new System.Drawing.Point(9, 77);
            this.FilterDeliveredFromDatePicker.Name = "FilterDeliveredFromDatePicker";
            this.FilterDeliveredFromDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterDeliveredFromDatePicker.TabIndex = 3;
            // 
            // FilterDeliveredToLabel
            // 
            this.FilterDeliveredToLabel.AutoSize = true;
            this.FilterDeliveredToLabel.Location = new System.Drawing.Point(123, 61);
            this.FilterDeliveredToLabel.Name = "FilterDeliveredToLabel";
            this.FilterDeliveredToLabel.Size = new System.Drawing.Size(63, 13);
            this.FilterDeliveredToLabel.TabIndex = 17;
            this.FilterDeliveredToLabel.Text = "Dodáno do:";
            // 
            // FilterDeliveredToDatePicker
            // 
            this.FilterDeliveredToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterDeliveredToDatePicker.Location = new System.Drawing.Point(126, 77);
            this.FilterDeliveredToDatePicker.Name = "FilterDeliveredToDatePicker";
            this.FilterDeliveredToDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterDeliveredToDatePicker.TabIndex = 4;
            // 
            // DetailTab
            // 
            this.DetailTab.AutoScroll = true;
            this.DetailTab.Controls.Add(this.SupplyItemGrid);
            this.DetailTab.Controls.Add(this.SupplyItemRibbon);
            this.DetailTab.Controls.Add(this.Detail);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(469, 366);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // SupplyItemGrid
            // 
            this.SupplyItemGrid.AllowUserToAddRows = false;
            this.SupplyItemGrid.AllowUserToDeleteRows = false;
            this.SupplyItemGrid.AllowUserToOrderColumns = true;
            this.SupplyItemGrid.AllowUserToResizeRows = false;
            this.SupplyItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SupplyItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplyItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyItemGrid_SupplyID,
            this.SupplyItemGrid_Order,
            this.SupplyItemGrid_ComponentTypeName,
            this.SupplyItemGrid_ComponentName,
            this.SupplyItemGrid_Quantity});
            this.SupplyItemGrid.ContextMenuStrip = this.SupplyItemGridContextMenu;
            this.SupplyItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplyItemGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SupplyItemGrid.Location = new System.Drawing.Point(3, 138);
            this.SupplyItemGrid.Name = "SupplyItemGrid";
            this.SupplyItemGrid.RowHeadersVisible = false;
            this.SupplyItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplyItemGrid.ShowCellToolTips = false;
            this.SupplyItemGrid.Size = new System.Drawing.Size(463, 225);
            this.SupplyItemGrid.TabIndex = 1;
            this.SupplyItemGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SupplyItemGrid_CellBeginEdit);
            this.SupplyItemGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyItemGrid_CellEndEdit);
            this.SupplyItemGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SupplyItemGrid_CellPainting);
            this.SupplyItemGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SupplyItemGrid_CellValidating);
            this.SupplyItemGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SupplyItemGrid_EditingControlShowing);
            this.SupplyItemGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.SupplyItemGrid_RowStateChanged);
            // 
            // SupplyItemGrid_SupplyID
            // 
            this.SupplyItemGrid_SupplyID.DataPropertyName = "SupplyID";
            this.SupplyItemGrid_SupplyID.HeaderText = "SupplyID";
            this.SupplyItemGrid_SupplyID.Name = "SupplyItemGrid_SupplyID";
            this.SupplyItemGrid_SupplyID.Visible = false;
            // 
            // SupplyItemGrid_Order
            // 
            this.SupplyItemGrid_Order.DataPropertyName = "Order";
            this.SupplyItemGrid_Order.HeaderText = "Order";
            this.SupplyItemGrid_Order.Name = "SupplyItemGrid_Order";
            this.SupplyItemGrid_Order.Visible = false;
            // 
            // SupplyItemGrid_ComponentTypeName
            // 
            this.SupplyItemGrid_ComponentTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplyItemGrid_ComponentTypeName.DataPropertyName = "ComponentTypeName";
            this.SupplyItemGrid_ComponentTypeName.HeaderText = "Typ komponenty";
            this.SupplyItemGrid_ComponentTypeName.MinimumWidth = 110;
            this.SupplyItemGrid_ComponentTypeName.Name = "SupplyItemGrid_ComponentTypeName";
            this.SupplyItemGrid_ComponentTypeName.ReadOnly = true;
            this.SupplyItemGrid_ComponentTypeName.Width = 110;
            // 
            // SupplyItemGrid_ComponentName
            // 
            this.SupplyItemGrid_ComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplyItemGrid_ComponentName.DataPropertyName = "ComponentName";
            this.SupplyItemGrid_ComponentName.HeaderText = "Komponenta";
            this.SupplyItemGrid_ComponentName.MinimumWidth = 150;
            this.SupplyItemGrid_ComponentName.Name = "SupplyItemGrid_ComponentName";
            this.SupplyItemGrid_ComponentName.ReadOnly = true;
            this.SupplyItemGrid_ComponentName.Width = 150;
            // 
            // SupplyItemGrid_Quantity
            // 
            this.SupplyItemGrid_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplyItemGrid_Quantity.DataPropertyName = "Quantity";
            this.SupplyItemGrid_Quantity.HeaderText = "Množství";
            this.SupplyItemGrid_Quantity.MinimumWidth = 40;
            this.SupplyItemGrid_Quantity.Name = "SupplyItemGrid_Quantity";
            // 
            // SupplyItemGridContextMenu
            // 
            this.SupplyItemGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllContextMenuItem});
            this.SupplyItemGridContextMenu.Name = "SupplyItemGridContextMenu";
            this.SupplyItemGridContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // SelectAllContextMenuItem
            // 
            this.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem";
            this.SelectAllContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SelectAllContextMenuItem.Text = "Vybrat vše";
            this.SelectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // SupplyItemRibbon
            // 
            this.SupplyItemRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.SupplyItemRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SupplyItemRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSupplyItemButton,
            this.RemoveSupplyItemButton,
            this.SaveSupplyItemButton});
            this.SupplyItemRibbon.Location = new System.Drawing.Point(3, 113);
            this.SupplyItemRibbon.Name = "SupplyItemRibbon";
            this.SupplyItemRibbon.Size = new System.Drawing.Size(463, 25);
            this.SupplyItemRibbon.TabIndex = 16;
            this.SupplyItemRibbon.Text = "SubMenu";
            // 
            // AddSupplyItemButton
            // 
            this.AddSupplyItemButton.AutoToolTip = false;
            this.AddSupplyItemButton.Enabled = false;
            this.AddSupplyItemButton.Image = global::ManagementSystem.Properties.Resources.AddSmall;
            this.AddSupplyItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSupplyItemButton.Name = "AddSupplyItemButton";
            this.AddSupplyItemButton.Size = new System.Drawing.Size(103, 22);
            this.AddSupplyItemButton.Text = "Přidat položku";
            this.AddSupplyItemButton.Click += new System.EventHandler(this.AddSupplyItemButton_Click);
            // 
            // RemoveSupplyItemButton
            // 
            this.RemoveSupplyItemButton.AutoToolTip = false;
            this.RemoveSupplyItemButton.Enabled = false;
            this.RemoveSupplyItemButton.Image = global::ManagementSystem.Properties.Resources.RemoveSmall;
            this.RemoveSupplyItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveSupplyItemButton.Name = "RemoveSupplyItemButton";
            this.RemoveSupplyItemButton.Size = new System.Drawing.Size(115, 22);
            this.RemoveSupplyItemButton.Text = "Odebrat položku";
            this.RemoveSupplyItemButton.Click += new System.EventHandler(this.RemoveSupplyItemButton_Click);
            // 
            // SaveSupplyItemButton
            // 
            this.SaveSupplyItemButton.AutoToolTip = false;
            this.SaveSupplyItemButton.Enabled = false;
            this.SaveSupplyItemButton.Image = global::ManagementSystem.Properties.Resources.SaveSmall;
            this.SaveSupplyItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSupplyItemButton.Name = "SaveSupplyItemButton";
            this.SaveSupplyItemButton.Size = new System.Drawing.Size(95, 22);
            this.SaveSupplyItemButton.Text = "Uložit změny";
            this.SaveSupplyItemButton.Click += new System.EventHandler(this.SaveSupplyItemButton_Click);
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.IDLabel);
            this.Detail.Controls.Add(this.IDTextBox);
            this.Detail.Controls.Add(this.DeliveredLabel);
            this.Detail.Controls.Add(this.DeliveredDatePicker);
            this.Detail.Controls.Add(this.SupplierNameLabel);
            this.Detail.Controls.Add(this.SupplierNameTextBox);
            this.Detail.Controls.Add(this.DescriptionLabel);
            this.Detail.Controls.Add(this.DescriptionTextBox);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail.Location = new System.Drawing.Point(3, 3);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(463, 110);
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
            // DeliveredLabel
            // 
            this.DeliveredLabel.AutoSize = true;
            this.DeliveredLabel.Location = new System.Drawing.Point(123, 21);
            this.DeliveredLabel.Name = "DeliveredLabel";
            this.DeliveredLabel.Size = new System.Drawing.Size(48, 13);
            this.DeliveredLabel.TabIndex = 15;
            this.DeliveredLabel.Text = "Dodáno:";
            // 
            // DeliveredDatePicker
            // 
            this.DeliveredDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeliveredDatePicker.Location = new System.Drawing.Point(126, 37);
            this.DeliveredDatePicker.Name = "DeliveredDatePicker";
            this.DeliveredDatePicker.Size = new System.Drawing.Size(100, 20);
            this.DeliveredDatePicker.TabIndex = 1;
            this.DeliveredDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DeliveredDatePicker_Validating);
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Location = new System.Drawing.Point(240, 21);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(59, 13);
            this.SupplierNameLabel.TabIndex = 13;
            this.SupplierNameLabel.Text = "Dodavatel:";
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Location = new System.Drawing.Point(243, 37);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.SupplierNameTextBox.TabIndex = 2;
            this.SupplierNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SupplierNameTextBox_Validating);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 61);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(36, 13);
            this.DescriptionLabel.TabIndex = 30;
            this.DescriptionLabel.Text = "Popis:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(9, 77);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(384, 20);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(477, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // SupplyErrorProvider
            // 
            this.SupplyErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.SupplyErrorProvider.ContainerControl = this;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 441);
            this.Controls.Add(this.SupplyTabControl);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.SupplyRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplyForm";
            this.ShowIcon = false;
            this.Text = "Příjemky";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SupplyForm_VisibleChanged);
            this.SupplyRibbon.ResumeLayout(false);
            this.SupplyRibbon.PerformLayout();
            this.SupplyTabControl.ResumeLayout(false);
            this.ListingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplyGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyItemGrid)).EndInit();
            this.SupplyItemGridContextMenu.ResumeLayout(false);
            this.SupplyItemRibbon.ResumeLayout(false);
            this.SupplyItemRibbon.PerformLayout();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip SupplyRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.TabControl SupplyTabControl;
        private System.Windows.Forms.TabPage ListingTab;
        private System.Windows.Forms.DataGridView SupplyGrid;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterIDTextBox;
        private System.Windows.Forms.TextBox FilterSupplierNameTextBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.DataGridView SupplyItemGrid;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.ToolStrip SupplyItemRibbon;
        private System.Windows.Forms.ToolStripButton AddSupplyItemButton;
        private System.Windows.Forms.ToolStripButton RemoveSupplyItemButton;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.Label FilterSupplierNameLabel;
        private System.Windows.Forms.Label FilterDeliveredFromLabel;
        private System.Windows.Forms.ErrorProvider SupplyErrorProvider;
        private System.Windows.Forms.Label FilterDeliveredToLabel;
        private System.Windows.Forms.ComboBox FilterComponentDropDown;
        private System.Windows.Forms.DateTimePicker FilterDeliveredToDatePicker;
        private System.Windows.Forms.DateTimePicker FilterDeliveredFromDatePicker;
        private System.Windows.Forms.DateTimePicker DeliveredDatePicker;
        private System.Windows.Forms.Label DeliveredLabel;
        private System.Windows.Forms.TextBox SupplierNameTextBox;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripButton ApproveButton;
        private System.Windows.Forms.CheckBox FilterIsNotApprovedOnlyCheckBox;
        private System.Windows.Forms.ContextMenuStrip SupplyItemGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.ToolStripButton SaveSupplyItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyGrid_Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyGrid_SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyGrid_Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SupplyGrid_IsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyItemGrid_SupplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyItemGrid_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyItemGrid_ComponentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyItemGrid_ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyItemGrid_Quantity;
    }
}

