namespace ManagementSystem.Stock
{
    partial class SaleForm
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
            System.Windows.Forms.Label FilterProductLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FilterIDLabel = new System.Windows.Forms.Label();
            this.FilterCustomerNameLabel = new System.Windows.Forms.Label();
            this.FilterSoldFromLabel = new System.Windows.Forms.Label();
            this.SaleRibbon = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ApproveButton = new System.Windows.Forms.ToolStripButton();
            this.SaleTabControl = new System.Windows.Forms.TabControl();
            this.ListingTab = new System.Windows.Forms.TabPage();
            this.SaleGrid = new System.Windows.Forms.DataGridView();
            this.SaleGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleGrid_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleGrid_CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleGrid_IsApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.FilterIDTextBox = new System.Windows.Forms.TextBox();
            this.FilterCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.FilterProductDropDown = new System.Windows.Forms.ComboBox();
            this.FilterSoldFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterSoldToLabel = new System.Windows.Forms.Label();
            this.FilterSoldToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterIsNotApprovedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.SaleItemGrid = new System.Windows.Forms.DataGridView();
            this.SaleItemGrid_SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemGrid_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemGrid_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemGrid_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemGrid_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleItemGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleItemRibbon = new System.Windows.Forms.ToolStrip();
            this.AddSaleItemButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveSaleItemButton = new System.Windows.Forms.ToolStripButton();
            this.SaveSaleItemButton = new System.Windows.Forms.ToolStripButton();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SoldLabel = new System.Windows.Forms.Label();
            this.SoldDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.SaleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            FilterProductLabel = new System.Windows.Forms.Label();
            this.SaleRibbon.SuspendLayout();
            this.SaleTabControl.SuspendLayout();
            this.ListingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleGrid)).BeginInit();
            this.Filter.SuspendLayout();
            this.DetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemGrid)).BeginInit();
            this.SaleItemGridContextMenu.SuspendLayout();
            this.SaleItemRibbon.SuspendLayout();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterProductLabel
            // 
            FilterProductLabel.AutoSize = true;
            FilterProductLabel.Location = new System.Drawing.Point(290, 20);
            FilterProductLabel.Name = "FilterProductLabel";
            FilterProductLabel.Size = new System.Drawing.Size(47, 13);
            FilterProductLabel.TabIndex = 24;
            FilterProductLabel.Text = "Product:";
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
            // FilterCustomerNameLabel
            // 
            this.FilterCustomerNameLabel.AutoSize = true;
            this.FilterCustomerNameLabel.Location = new System.Drawing.Point(123, 21);
            this.FilterCustomerNameLabel.Name = "FilterCustomerNameLabel";
            this.FilterCustomerNameLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterCustomerNameLabel.TabIndex = 13;
            this.FilterCustomerNameLabel.Text = "Zákazník:";
            // 
            // FilterSoldFromLabel
            // 
            this.FilterSoldFromLabel.AutoSize = true;
            this.FilterSoldFromLabel.Location = new System.Drawing.Point(6, 61);
            this.FilterSoldFromLabel.Name = "FilterSoldFromLabel";
            this.FilterSoldFromLabel.Size = new System.Drawing.Size(65, 13);
            this.FilterSoldFromLabel.TabIndex = 15;
            this.FilterSoldFromLabel.Text = "Prodáno od:";
            // 
            // SaleRibbon
            // 
            this.SaleRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.SaleRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SaleRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterButton,
            this.Separator1,
            this.NewButton,
            this.EditButton,
            this.SaveButton,
            this.CancelButton,
            this.Separator2,
            this.ApproveButton});
            this.SaleRibbon.Location = new System.Drawing.Point(0, 0);
            this.SaleRibbon.Name = "SaleRibbon";
            this.SaleRibbon.Size = new System.Drawing.Size(471, 38);
            this.SaleRibbon.TabIndex = 10;
            this.SaleRibbon.Text = "Menu";
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
            // SaleTabControl
            // 
            this.SaleTabControl.Controls.Add(this.ListingTab);
            this.SaleTabControl.Controls.Add(this.DetailTab);
            this.SaleTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleTabControl.Location = new System.Drawing.Point(0, 49);
            this.SaleTabControl.Name = "SaleTabControl";
            this.SaleTabControl.SelectedIndex = 0;
            this.SaleTabControl.Size = new System.Drawing.Size(471, 392);
            this.SaleTabControl.TabIndex = 0;
            this.SaleTabControl.SelectedIndexChanged += new System.EventHandler(this.SaleTabControl_SelectedIndexChanged);
            this.SaleTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SaleTabControl_Selecting);
            // 
            // ListingTab
            // 
            this.ListingTab.Controls.Add(this.SaleGrid);
            this.ListingTab.Controls.Add(this.Filter);
            this.ListingTab.Location = new System.Drawing.Point(4, 22);
            this.ListingTab.Name = "ListingTab";
            this.ListingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListingTab.Size = new System.Drawing.Size(463, 366);
            this.ListingTab.TabIndex = 0;
            this.ListingTab.Text = "Seznam";
            this.ListingTab.UseVisualStyleBackColor = true;
            // 
            // SaleGrid
            // 
            this.SaleGrid.AllowUserToAddRows = false;
            this.SaleGrid.AllowUserToDeleteRows = false;
            this.SaleGrid.AllowUserToOrderColumns = true;
            this.SaleGrid.AllowUserToResizeRows = false;
            this.SaleGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SaleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleGrid_ID,
            this.SaleGrid_Sold,
            this.SaleGrid_CustomerName,
            this.SaleGrid_IsApproved});
            this.SaleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SaleGrid.Location = new System.Drawing.Point(3, 113);
            this.SaleGrid.MultiSelect = false;
            this.SaleGrid.Name = "SaleGrid";
            this.SaleGrid.ReadOnly = true;
            this.SaleGrid.RowHeadersVisible = false;
            this.SaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleGrid.ShowCellToolTips = false;
            this.SaleGrid.Size = new System.Drawing.Size(457, 250);
            this.SaleGrid.TabIndex = 1;
            this.SaleGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleGrid_CellClick);
            // 
            // SaleGrid_ID
            // 
            this.SaleGrid_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleGrid_ID.DataPropertyName = "ID";
            this.SaleGrid_ID.HeaderText = "Číslo";
            this.SaleGrid_ID.MinimumWidth = 60;
            this.SaleGrid_ID.Name = "SaleGrid_ID";
            this.SaleGrid_ID.ReadOnly = true;
            this.SaleGrid_ID.Width = 60;
            // 
            // SaleGrid_Sold
            // 
            this.SaleGrid_Sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleGrid_Sold.DataPropertyName = "Sold";
            this.SaleGrid_Sold.HeaderText = "Datum";
            this.SaleGrid_Sold.MinimumWidth = 80;
            this.SaleGrid_Sold.Name = "SaleGrid_Sold";
            this.SaleGrid_Sold.ReadOnly = true;
            this.SaleGrid_Sold.Width = 80;
            // 
            // SaleGrid_CustomerName
            // 
            this.SaleGrid_CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleGrid_CustomerName.DataPropertyName = "CustomerName";
            this.SaleGrid_CustomerName.HeaderText = "Zákazník";
            this.SaleGrid_CustomerName.MinimumWidth = 150;
            this.SaleGrid_CustomerName.Name = "SaleGrid_CustomerName";
            this.SaleGrid_CustomerName.ReadOnly = true;
            this.SaleGrid_CustomerName.Width = 150;
            // 
            // SaleGrid_IsApproved
            // 
            this.SaleGrid_IsApproved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleGrid_IsApproved.DataPropertyName = "IsApproved";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SaleGrid_IsApproved.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaleGrid_IsApproved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaleGrid_IsApproved.HeaderText = "Schváleno";
            this.SaleGrid_IsApproved.Name = "SaleGrid_IsApproved";
            this.SaleGrid_IsApproved.ReadOnly = true;
            this.SaleGrid_IsApproved.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleGrid_IsApproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.FilterIDLabel);
            this.Filter.Controls.Add(this.FilterIDTextBox);
            this.Filter.Controls.Add(this.FilterCustomerNameLabel);
            this.Filter.Controls.Add(this.FilterCustomerNameTextBox);
            this.Filter.Controls.Add(FilterProductLabel);
            this.Filter.Controls.Add(this.FilterProductDropDown);
            this.Filter.Controls.Add(this.FilterSoldFromLabel);
            this.Filter.Controls.Add(this.FilterSoldFromDatePicker);
            this.Filter.Controls.Add(this.FilterSoldToLabel);
            this.Filter.Controls.Add(this.FilterSoldToDatePicker);
            this.Filter.Controls.Add(this.FilterIsNotApprovedOnlyCheckBox);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(457, 110);
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
            // FilterCustomerNameTextBox
            // 
            this.FilterCustomerNameTextBox.Location = new System.Drawing.Point(126, 37);
            this.FilterCustomerNameTextBox.Name = "FilterCustomerNameTextBox";
            this.FilterCustomerNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FilterCustomerNameTextBox.TabIndex = 1;
            // 
            // FilterProductDropDown
            // 
            this.FilterProductDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FilterProductDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterProductDropDown.DisplayMember = "Value";
            this.FilterProductDropDown.FormattingEnabled = true;
            this.FilterProductDropDown.Location = new System.Drawing.Point(293, 36);
            this.FilterProductDropDown.Name = "FilterProductDropDown";
            this.FilterProductDropDown.Size = new System.Drawing.Size(150, 21);
            this.FilterProductDropDown.TabIndex = 2;
            this.FilterProductDropDown.ValueMember = "Key";
            // 
            // FilterSoldFromDatePicker
            // 
            this.FilterSoldFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterSoldFromDatePicker.Location = new System.Drawing.Point(9, 77);
            this.FilterSoldFromDatePicker.Name = "FilterSoldFromDatePicker";
            this.FilterSoldFromDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterSoldFromDatePicker.TabIndex = 3;
            // 
            // FilterSoldToLabel
            // 
            this.FilterSoldToLabel.AutoSize = true;
            this.FilterSoldToLabel.Location = new System.Drawing.Point(123, 61);
            this.FilterSoldToLabel.Name = "FilterSoldToLabel";
            this.FilterSoldToLabel.Size = new System.Drawing.Size(65, 13);
            this.FilterSoldToLabel.TabIndex = 17;
            this.FilterSoldToLabel.Text = "Prodáno do:";
            // 
            // FilterSoldToDatePicker
            // 
            this.FilterSoldToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FilterSoldToDatePicker.Location = new System.Drawing.Point(126, 77);
            this.FilterSoldToDatePicker.Name = "FilterSoldToDatePicker";
            this.FilterSoldToDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FilterSoldToDatePicker.TabIndex = 4;
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
            // DetailTab
            // 
            this.DetailTab.AutoScroll = true;
            this.DetailTab.Controls.Add(this.SaleItemGrid);
            this.DetailTab.Controls.Add(this.SaleItemRibbon);
            this.DetailTab.Controls.Add(this.Detail);
            this.DetailTab.Location = new System.Drawing.Point(4, 22);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(463, 366);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // SaleItemGrid
            // 
            this.SaleItemGrid.AllowUserToAddRows = false;
            this.SaleItemGrid.AllowUserToDeleteRows = false;
            this.SaleItemGrid.AllowUserToOrderColumns = true;
            this.SaleItemGrid.AllowUserToResizeRows = false;
            this.SaleItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SaleItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleItemGrid_SaleID,
            this.SaleItemGrid_Order,
            this.SaleItemGrid_ProductID,
            this.SaleItemGrid_ProductName,
            this.SaleItemGrid_Quantity});
            this.SaleItemGrid.ContextMenuStrip = this.SaleItemGridContextMenu;
            this.SaleItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleItemGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SaleItemGrid.Location = new System.Drawing.Point(3, 98);
            this.SaleItemGrid.Name = "SaleItemGrid";
            this.SaleItemGrid.RowHeadersVisible = false;
            this.SaleItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleItemGrid.ShowCellToolTips = false;
            this.SaleItemGrid.Size = new System.Drawing.Size(457, 265);
            this.SaleItemGrid.TabIndex = 1;
            this.SaleItemGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SaleItemGrid_CellBeginEdit);
            this.SaleItemGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleItemGrid_CellEndEdit);
            this.SaleItemGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SaleItemGrid_CellPainting);
            this.SaleItemGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SaleItemGrid_CellValidating);
            this.SaleItemGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SaleItemGrid_EditingControlShowing);
            this.SaleItemGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.SaleItemGrid_RowStateChanged);
            // 
            // SaleItemGrid_SaleID
            // 
            this.SaleItemGrid_SaleID.DataPropertyName = "SaleID";
            this.SaleItemGrid_SaleID.HeaderText = "SaleID";
            this.SaleItemGrid_SaleID.Name = "SaleItemGrid_SaleID";
            this.SaleItemGrid_SaleID.Visible = false;
            // 
            // SaleItemGrid_Order
            // 
            this.SaleItemGrid_Order.DataPropertyName = "Order";
            this.SaleItemGrid_Order.HeaderText = "Order";
            this.SaleItemGrid_Order.Name = "SaleItemGrid_Order";
            this.SaleItemGrid_Order.Visible = false;
            // 
            // SaleItemGrid_ProductID
            // 
            this.SaleItemGrid_ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleItemGrid_ProductID.DataPropertyName = "ProductID";
            this.SaleItemGrid_ProductID.HeaderText = "Produkt";
            this.SaleItemGrid_ProductID.MinimumWidth = 70;
            this.SaleItemGrid_ProductID.Name = "SaleItemGrid_ProductID";
            this.SaleItemGrid_ProductID.ReadOnly = true;
            this.SaleItemGrid_ProductID.Width = 70;
            // 
            // SaleItemGrid_ProductName
            // 
            this.SaleItemGrid_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleItemGrid_ProductName.DataPropertyName = "ProductName";
            this.SaleItemGrid_ProductName.HeaderText = "Název produktu";
            this.SaleItemGrid_ProductName.MinimumWidth = 150;
            this.SaleItemGrid_ProductName.Name = "SaleItemGrid_ProductName";
            this.SaleItemGrid_ProductName.ReadOnly = true;
            this.SaleItemGrid_ProductName.Width = 150;
            // 
            // SaleItemGrid_Quantity
            // 
            this.SaleItemGrid_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleItemGrid_Quantity.DataPropertyName = "Quantity";
            this.SaleItemGrid_Quantity.HeaderText = "Množství";
            this.SaleItemGrid_Quantity.MinimumWidth = 40;
            this.SaleItemGrid_Quantity.Name = "SaleItemGrid_Quantity";
            // 
            // SaleItemGridContextMenu
            // 
            this.SaleItemGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllContextMenuItem});
            this.SaleItemGridContextMenu.Name = "SaleItemGridContextMenu";
            this.SaleItemGridContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // SelectAllContextMenuItem
            // 
            this.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem";
            this.SelectAllContextMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SelectAllContextMenuItem.Text = "Vybrat vše";
            this.SelectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // SaleItemRibbon
            // 
            this.SaleItemRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.SaleItemRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SaleItemRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSaleItemButton,
            this.RemoveSaleItemButton,
            this.SaveSaleItemButton});
            this.SaleItemRibbon.Location = new System.Drawing.Point(3, 73);
            this.SaleItemRibbon.Name = "SaleItemRibbon";
            this.SaleItemRibbon.Size = new System.Drawing.Size(457, 25);
            this.SaleItemRibbon.TabIndex = 16;
            this.SaleItemRibbon.Text = "SubMenu";
            // 
            // AddSaleItemButton
            // 
            this.AddSaleItemButton.AutoToolTip = false;
            this.AddSaleItemButton.Enabled = false;
            this.AddSaleItemButton.Image = global::ManagementSystem.Properties.Resources.AddSmall;
            this.AddSaleItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSaleItemButton.Name = "AddSaleItemButton";
            this.AddSaleItemButton.Size = new System.Drawing.Size(103, 22);
            this.AddSaleItemButton.Text = "Přidat položku";
            this.AddSaleItemButton.Click += new System.EventHandler(this.AddSaleItemButton_Click);
            // 
            // RemoveSaleItemButton
            // 
            this.RemoveSaleItemButton.AutoToolTip = false;
            this.RemoveSaleItemButton.Enabled = false;
            this.RemoveSaleItemButton.Image = global::ManagementSystem.Properties.Resources.RemoveSmall;
            this.RemoveSaleItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveSaleItemButton.Name = "RemoveSaleItemButton";
            this.RemoveSaleItemButton.Size = new System.Drawing.Size(115, 22);
            this.RemoveSaleItemButton.Text = "Odebrat položku";
            this.RemoveSaleItemButton.Click += new System.EventHandler(this.RemoveSaleItemButton_Click);
            // 
            // SaveSaleItemButton
            // 
            this.SaveSaleItemButton.AutoToolTip = false;
            this.SaveSaleItemButton.Enabled = false;
            this.SaveSaleItemButton.Image = global::ManagementSystem.Properties.Resources.SaveSmall;
            this.SaveSaleItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSaleItemButton.Name = "SaveSaleItemButton";
            this.SaveSaleItemButton.Size = new System.Drawing.Size(95, 22);
            this.SaveSaleItemButton.Text = "Uložit změny";
            this.SaveSaleItemButton.Click += new System.EventHandler(this.SaveSaleItemButton_Click);
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.IDLabel);
            this.Detail.Controls.Add(this.IDTextBox);
            this.Detail.Controls.Add(this.SoldLabel);
            this.Detail.Controls.Add(this.SoldDatePicker);
            this.Detail.Controls.Add(this.CustomerNameLabel);
            this.Detail.Controls.Add(this.CustomerNameTextBox);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail.Location = new System.Drawing.Point(3, 3);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(457, 70);
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
            // SoldLabel
            // 
            this.SoldLabel.AutoSize = true;
            this.SoldLabel.Location = new System.Drawing.Point(123, 21);
            this.SoldLabel.Name = "SoldLabel";
            this.SoldLabel.Size = new System.Drawing.Size(50, 13);
            this.SoldLabel.TabIndex = 15;
            this.SoldLabel.Text = "Prodáno:";
            // 
            // SoldDatePicker
            // 
            this.SoldDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SoldDatePicker.Location = new System.Drawing.Point(126, 37);
            this.SoldDatePicker.Name = "SoldDatePicker";
            this.SoldDatePicker.Size = new System.Drawing.Size(100, 20);
            this.SoldDatePicker.TabIndex = 1;
            this.SoldDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.SoldDatePicker_Validating);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(240, 21);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(56, 13);
            this.CustomerNameLabel.TabIndex = 13;
            this.CustomerNameLabel.Text = "Zákazník:";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(243, 37);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.CustomerNameTextBox.TabIndex = 2;
            this.CustomerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameTextBox_Validating);
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(471, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // SaleErrorProvider
            // 
            this.SaleErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.SaleErrorProvider.ContainerControl = this;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(471, 441);
            this.Controls.Add(this.SaleTabControl);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.SaleRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleForm";
            this.ShowIcon = false;
            this.Text = "Příjemky";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SaleForm_VisibleChanged);
            this.SaleRibbon.ResumeLayout(false);
            this.SaleRibbon.PerformLayout();
            this.SaleTabControl.ResumeLayout(false);
            this.ListingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleGrid)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemGrid)).EndInit();
            this.SaleItemGridContextMenu.ResumeLayout(false);
            this.SaleItemRibbon.ResumeLayout(false);
            this.SaleItemRibbon.PerformLayout();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip SaleRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.TabControl SaleTabControl;
        private System.Windows.Forms.TabPage ListingTab;
        private System.Windows.Forms.DataGridView SaleGrid;
        private System.Windows.Forms.TabPage DetailTab;
        private System.Windows.Forms.ToolStripButton FilterButton;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox FilterIDTextBox;
        private System.Windows.Forms.TextBox FilterCustomerNameTextBox;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.DataGridView SaleItemGrid;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.ToolStrip SaleItemRibbon;
        private System.Windows.Forms.ToolStripButton AddSaleItemButton;
        private System.Windows.Forms.ToolStripButton RemoveSaleItemButton;
        private System.Windows.Forms.Label FilterIDLabel;
        private System.Windows.Forms.Label FilterCustomerNameLabel;
        private System.Windows.Forms.Label FilterSoldFromLabel;
        private System.Windows.Forms.ErrorProvider SaleErrorProvider;
        private System.Windows.Forms.Label FilterSoldToLabel;
        private System.Windows.Forms.ComboBox FilterProductDropDown;
        private System.Windows.Forms.DateTimePicker FilterSoldToDatePicker;
        private System.Windows.Forms.DateTimePicker FilterSoldFromDatePicker;
        private System.Windows.Forms.DateTimePicker SoldDatePicker;
        private System.Windows.Forms.Label SoldLabel;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripButton ApproveButton;
        private System.Windows.Forms.CheckBox FilterIsNotApprovedOnlyCheckBox;
        private System.Windows.Forms.ContextMenuStrip SaleItemGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContextMenuItem;
        private System.Windows.Forms.ToolStripButton SaveSaleItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleGrid_Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleGrid_CustomerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SaleGrid_IsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemGrid_SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemGrid_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemGrid_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemGrid_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleItemGrid_Quantity;
    }
}

