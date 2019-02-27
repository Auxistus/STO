namespace ManagementSystem.Catalog
{
    partial class AbandonedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComponentTypeRibbon = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.ComponentTypeGrid = new System.Windows.Forms.DataGridView();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.ComponentTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComponentTypeGrid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentTypeGrid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentTypeGrid_IsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ComponentTypeRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ComponentTypeRibbon
            // 
            this.ComponentTypeRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentTypeRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentTypeRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.SaveButton,
            this.DeleteButton});
            this.ComponentTypeRibbon.Location = new System.Drawing.Point(0, 0);
            this.ComponentTypeRibbon.Name = "ComponentTypeRibbon";
            this.ComponentTypeRibbon.Size = new System.Drawing.Size(400, 38);
            this.ComponentTypeRibbon.TabIndex = 10;
            this.ComponentTypeRibbon.Text = "Menu";
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
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Image = global::ManagementSystem.Properties.Resources.RemoveSmall;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 35);
            this.DeleteButton.Text = "Smazat";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ComponentTypeGrid
            // 
            this.ComponentTypeGrid.AllowUserToAddRows = false;
            this.ComponentTypeGrid.AllowUserToDeleteRows = false;
            this.ComponentTypeGrid.AllowUserToOrderColumns = true;
            this.ComponentTypeGrid.AllowUserToResizeRows = false;
            this.ComponentTypeGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ComponentTypeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComponentTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentTypeGrid_ID,
            this.ComponentTypeGrid_Name,
            this.ComponentTypeGrid_IsVisible});
            this.ComponentTypeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentTypeGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ComponentTypeGrid.Location = new System.Drawing.Point(0, 49);
            this.ComponentTypeGrid.MultiSelect = false;
            this.ComponentTypeGrid.Name = "ComponentTypeGrid";
            this.ComponentTypeGrid.RowHeadersVisible = false;
            this.ComponentTypeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentTypeGrid.ShowCellToolTips = false;
            this.ComponentTypeGrid.Size = new System.Drawing.Size(400, 344);
            this.ComponentTypeGrid.TabIndex = 12;
            // 
            // FillingPanel
            // 
            this.FillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillingPanel.Location = new System.Drawing.Point(0, 38);
            this.FillingPanel.Name = "FillingPanel";
            this.FillingPanel.Size = new System.Drawing.Size(400, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // ComponentTypeErrorProvider
            // 
            this.ComponentTypeErrorProvider.ContainerControl = this;
            // 
            // ComponentTypeGrid_ID
            // 
            this.ComponentTypeGrid_ID.DataPropertyName = "ID";
            this.ComponentTypeGrid_ID.HeaderText = "ID";
            this.ComponentTypeGrid_ID.Name = "ComponentTypeGrid_ID";
            this.ComponentTypeGrid_ID.Visible = false;
            // 
            // ComponentTypeGrid_Name
            // 
            this.ComponentTypeGrid_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ComponentTypeGrid_Name.DataPropertyName = "Name";
            this.ComponentTypeGrid_Name.HeaderText = "Název";
            this.ComponentTypeGrid_Name.MinimumWidth = 150;
            this.ComponentTypeGrid_Name.Name = "ComponentTypeGrid_Name";
            this.ComponentTypeGrid_Name.ReadOnly = true;
            this.ComponentTypeGrid_Name.Width = 150;
            // 
            // ComponentTypeGrid_IsVisible
            // 
            this.ComponentTypeGrid_IsVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentTypeGrid_IsVisible.DataPropertyName = "IsVisible";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ComponentTypeGrid_IsVisible.DefaultCellStyle = dataGridViewCellStyle2;
            this.ComponentTypeGrid_IsVisible.HeaderText = "Zobrazit";
            this.ComponentTypeGrid_IsVisible.Name = "ComponentTypeGrid_IsVisible";
            this.ComponentTypeGrid_IsVisible.ReadOnly = true;
            this.ComponentTypeGrid_IsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ComponentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 393);
            this.Controls.Add(this.ComponentTypeGrid);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ComponentTypeRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentTypeForm";
            this.ShowIcon = false;
            this.Text = "Produkty";
            this.ComponentTypeRibbon.ResumeLayout(false);
            this.ComponentTypeRibbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ComponentTypeRibbon;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.DataGridView ComponentTypeGrid;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ErrorProvider ComponentTypeErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentTypeGrid_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentTypeGrid_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ComponentTypeGrid_IsVisible;
    }
}

