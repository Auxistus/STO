using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementSystem.Shared.NavigationMenu
{
    public enum MenuTopLevelButtons
    {
        Catalog,
        Stock
    }

    public class MenuButton
    {
        public MenuTopLevelButtons Key { get; private set; }
        public List<Button> SubMenuButtons = new List<Button>();
        public bool IsSubMenuOpened;

        public MenuButton(MenuTopLevelButtons key, params Button[] buttons)
        {
            Key = key;
            foreach (var button in buttons)
            {
                SubMenuButtons.Add(button);
            }
            IsSubMenuOpened = false;
        }
    }

    public class NavigationMenu
    {
        private List<MenuButton> MenuButtons = new List<MenuButton>();

        public NavigationMenu(params MenuButton[] buttons)
        {
            foreach (var button in buttons)
            {
                MenuButtons.Add(button);
            }
        }

        public void ShowSubMenu(MenuTopLevelButtons key)
        {
            foreach (var menu in MenuButtons)
            {
                if (menu.Key == key && !menu.IsSubMenuOpened)
                {
                    foreach (var subMenu in menu.SubMenuButtons)
                    {
                        subMenu.Visible = true;
                    }

                    menu.IsSubMenuOpened = true;
                }
                else
                {
                    foreach (var subMenu in menu.SubMenuButtons)
                    {
                        subMenu.Visible = false;
                    }

                    menu.IsSubMenuOpened = false;
                }
            }
        }
    }
}
