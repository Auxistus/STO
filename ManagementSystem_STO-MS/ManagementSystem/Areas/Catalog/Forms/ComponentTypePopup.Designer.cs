namespace ManagementSystem.Catalog
{
    partial class ComponentTypePopup
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
            System.Windows.Forms.Label NameLabel;
            this.ComponentTypeRibbon = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            this.FillingPanel = new System.Windows.Forms.Panel();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ComponentTypeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            NameLabel = new System.Windows.Forms.Label();
            this.ComponentTypeRibbon.SuspendLayout();
            this.Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(6, 21);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(41, 13);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Název:";
            // 
            // ComponentTypeRibbon
            // 
            this.ComponentTypeRibbon.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentTypeRibbon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentTypeRibbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.CancelButton});
            this.ComponentTypeRibbon.Location = new System.Drawing.Point(0, 0);
            this.ComponentTypeRibbon.Name = "ComponentTypeRibbon";
            this.ComponentTypeRibbon.Size = new System.Drawing.Size(180, 38);
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
            this.NewButton.Text = "Založit";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
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
            this.FillingPanel.Size = new System.Drawing.Size(180, 11);
            this.FillingPanel.TabIndex = 19;
            // 
            // Detail
            // 
            this.Detail.Controls.Add(NameLabel);
            this.Detail.Controls.Add(this.NameTextBox);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detail.Location = new System.Drawing.Point(0, 49);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(180, 75);
            this.Detail.TabIndex = 0;
            this.Detail.TabStop = false;
            this.Detail.Text = "Typ komponenty";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(9, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FilterNameTextBox_Validating);
            // 
            // ComponentTypeErrorProvider
            // 
            this.ComponentTypeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ComponentTypeErrorProvider.ContainerControl = this;
            // 
            // ComponentTypePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(180, 124);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.FillingPanel);
            this.Controls.Add(this.ComponentTypeRibbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentTypePopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nový typ komponenty";
            this.Load += new System.EventHandler(this.ComponentTypePopup_Load);
            this.ComponentTypeRibbon.ResumeLayout(false);
            this.ComponentTypeRibbon.PerformLayout();
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentTypeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ComponentTypeRibbon;
        private System.Windows.Forms.Panel FillingPanel;
        private System.Windows.Forms.ToolStripButton NewButton;
        private new System.Windows.Forms.ToolStripButton CancelButton;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider ComponentTypeErrorProvider;
    }
}

