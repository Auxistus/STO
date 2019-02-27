using System;
using System.Linq;
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
    public partial class AbandonedForm : Form, IForm
    {
        private RibbonMode _ribbonMode;

        private bool IsWork { get; set; }

        public RibbonMode RibbonMode
        {
            get { return _ribbonMode; }
            set
            {
                _ribbonMode = value;
                SetRibbonButtons(_ribbonMode);
            }
        }

        public AbandonedForm(Form main)
        {
            InitializeComponent();
        }

        private void SetRibbonButtons(RibbonMode mode)
        {
            switch (mode)
            {
                case RibbonMode.Listing:
                    NewButton.Enabled = true;
                    SaveButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    break;
                    //case RibbonMode.Detail:
                    //    NewButton.Enabled = false;
                    //    SaveButton.Enabled = false;
                    //    DeleteButton.Enabled = false;
                    //    break;
                    //case RibbonMode.Edit:
                    //    NewButton.Enabled = false;
                    //    SaveButton.Enabled = true;
                    //    DeleteButton.Enabled = true;
                    //    break;
            }
        }

        public bool HasUnsavedWork()
        {
            return IsWork;
        }

        public void DiscardUnsavedWork()
        {
            throw new NotImplementedException();
        }
    }
}
