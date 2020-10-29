using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> menuItems { get; set; }
        public DateTime LastUpdated { get; set; }
        public Menu(List<MenuItem> item)
        {
            menuItems = item;
            LastUpdated = DateTime.Today;
        }

        public Menu(List<MenuItem> item, DateTime updateTime)
        {
            menuItems = item;
            LastUpdated = updateTime;
        }

    }
}
