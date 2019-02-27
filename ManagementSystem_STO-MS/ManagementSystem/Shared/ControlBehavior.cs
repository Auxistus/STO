using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using ManagementSystem.Common;

namespace ManagementSystem.Shared.ControlBehavior
{
    public static class ControlBehavior
    {
        public enum RibbonMode
        {
            Listing,
            Detail,
            Edit
        }

        public static void ClearControl(Control control)
        {
            if (control is TextBox)
            {
                control.Text = string.Empty;
            }
            else if (control is ComboBox)
            {
                (control as ComboBox).SelectedIndex = -1;
            }
            else if (control is DateTimePicker)
            {
                DatePicker.ClearDatePicker(control as DateTimePicker);
            }
            else if (control is DataGridView)
            {
                (control as DataGridView).Rows.Clear();
            }
        }

        public static void ChangeControlsEnabled(ControlCollection controls, bool enabled, bool clear)
        {
            foreach (Control control in controls)
            {
                control.CausesValidation = false;

                if (control is TextBox || control is ComboBox || control is DateTimePicker)
                {
                    control.Enabled = enabled;
                }

                if (clear)
                {
                    ClearControl(control);
                }

                if (control.Controls.Count > 0 && !(control is DataGridView))
                {
                    ChangeControlsEnabled(control.Controls, enabled, clear);
                }

                control.CausesValidation = true;
            }
        }
    }
}
