using System.Windows.Forms;
using static ManagementSystem.Shared.ControlBehavior.ControlBehavior;

namespace ManagementSystem.Shared.Interfaces
{
    public interface IForm
    {
        RibbonMode RibbonMode { get; set; }

        bool HasUnsavedWork();

        void DiscardUnsavedWork();
    }
}
