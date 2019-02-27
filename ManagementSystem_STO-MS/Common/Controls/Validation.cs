using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace ManagementSystem.Common
{
    public class Validation
    {
        public static bool IsAllValid(System.Windows.Forms.Control.ControlCollection controls)
        {
            bool isValid = true;

            foreach (Control control in controls)
            {
                if (!IsValid(control))
                    isValid = false;

                if (control.HasChildren)
                {
                    if (IsAllValid(control.Controls))
                        isValid = false;
                }
            }
            return isValid;
        }

        private static bool IsValid(object eventSource)
        {
            string name = "EventValidating";

            Type targetType = eventSource.GetType();

            do
            {
                FieldInfo[] fields = targetType.GetFields(
                     BindingFlags.Static |
                     BindingFlags.Instance |
                     BindingFlags.NonPublic);

                foreach (FieldInfo field in fields)
                {
                    if (field.Name == name)
                    {
                        EventHandlerList eventHandlers = ((EventHandlerList)(eventSource.GetType().GetProperty("Events",
                            (BindingFlags.FlattenHierarchy |
                            (BindingFlags.NonPublic | BindingFlags.Instance))).GetValue(eventSource, null)));

                        Delegate d = eventHandlers[field.GetValue(eventSource)];

                        if (d != null)
                        {
                            Delegate[] subscribers = d.GetInvocationList();

                            foreach (Delegate s in subscribers)
                            {
                                object sender = eventSource;
                                CancelEventArgs eventArgs = new CancelEventArgs();
                                eventArgs.Cancel = false;
                                object[] parameters = new object[2];
                                parameters[0] = sender;
                                parameters[1] = eventArgs;

                                s.DynamicInvoke(parameters);

                                if (eventArgs.Cancel)
                                    return false;
                                else
                                    return true;
                            }
                        }
                    }
                }

                targetType = targetType.BaseType;

            } while (targetType != null);

            return true;
        }

    }
}
