using System;
using System.Windows.Forms;
using ManagementSystem.Common;
using ManagementSystem.Database;
using ManagementSystem.BusinessLogic.Catalog;
using ManagementSystem.Shared.Interfaces;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;
using ManagementSystem.Main;
using ManagementSystem.Properties;

namespace ManagementSystem.Catalog
{
    public partial class ComponentTypePopup : Form, IForm
    {
        private RibbonMode _ribbonMode;
        private ComponentTypeRepository ComponentTypeRepository;

        private bool IsWork { get; set; }
        private MainForm MainForm;

        public byte ComponentTypeID { get; private set; }

        public RibbonMode RibbonMode
        {
            get { return _ribbonMode; }
            set
            {
                _ribbonMode = value;
                SetRibbonButtons(_ribbonMode);
            }
        }

        public ComponentTypePopup(Form main)
        {
            ComponentTypeRepository = new ComponentTypeRepository();
            MainForm = main as MainForm;

            InitializeComponent();
        }

        private void ComponentTypePopup_Load(object sender, EventArgs e)
        {
            Left = MainForm.Location.X + (MainForm.Width / 2 - Width / 2);
            Top = MainForm.Location.Y + (MainForm.Height / 2 - Height / 2);

            RibbonMode = RibbonMode.Listing;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (!Validation.IsAllValid(Detail.Controls))
                return;

            var componentType = new ComponentType
            {
                Name = NameTextBox.Text,
                IsVisible = true
            };

            ComponentTypeRepository.InsertComponentType(componentType);
            ComponentTypeRepository.Commit();

            ComponentTypeID = componentType.ID;

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
        }

        public bool HasUnsavedWork()
        {
            return IsWork;
        }

        public void DiscardUnsavedWork()
        {
            throw new NotImplementedException();
        }

        private void FilterNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (NameTextBox.Text.IsNullOrWhiteSpace())
            {
                ComponentTypeErrorProvider.SetError(NameTextBox, Resources.ValidationMandatory);
                e.Cancel = true;
            }
            else if (NameTextBox.Text.Length > 50)
            {
                ComponentTypeErrorProvider.SetError(NameTextBox, Resources.ValidationLength.FormatWith(50));
                e.Cancel = true;
            }
            else
            {
                ComponentTypeErrorProvider.SetError(NameTextBox, "");
            }
        }
    }
}
