using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementSystem.Common
{
    public static class DatePicker
    {
        public static void InitializeDatePickers(List<DateTimePicker> datePickers)
        {
            foreach (var datePicker in datePickers)
            {
                datePicker.ValueChanged += new EventHandler(DatePickerValueChanged);
                datePicker.KeyDown += new KeyEventHandler(DatePickerKeyDown);
                datePicker.DropDown += new EventHandler(DatePickerDropDown);
                datePicker.CloseUp += new EventHandler(DatePickerCloseUp);
            }
        }

        private static void DatePickerValueChanged(object sender, EventArgs e)
        {
            var datePicker = sender as DateTimePicker;

            if (datePicker.Value == DateTimePicker.MinimumDateTime)
            {
                datePicker.Value = DateTime.Today;
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = " ";
            }
            else
            {
                datePicker.Format = DateTimePickerFormat.Short;
            }
        }

        private static void DatePickerKeyDown(object sender, KeyEventArgs e)
        {
            var datePicker = sender as DateTimePicker;

            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                ClearDatePicker(datePicker);
            }
        }

        private static void DatePickerDropDown(object sender, EventArgs e)
        {
            var datePicker = sender as DateTimePicker;

            datePicker.ValueChanged -= DatePickerValueChanged;
        }

        private static void DatePickerCloseUp(object sender, EventArgs e)
        {
            var datePicker = sender as DateTimePicker;

            datePicker.ValueChanged += DatePickerValueChanged;
            DatePickerValueChanged(sender, e);
        }

        public static void ClearDatePicker(this DateTimePicker datePicker)
        {
            datePicker.ResetMinDate();
            datePicker.Value = DateTimePicker.MinimumDateTime;
        }

        public static void ResetMinDate(this DateTimePicker datePicker)
        {
            datePicker.MinDate = DateTimePicker.MinimumDateTime;
        }
    }
}
