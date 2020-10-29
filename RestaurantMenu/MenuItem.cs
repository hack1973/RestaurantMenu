using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public List<string> categoryList = new List<string> { "Appetizer", "Main Course", "Dessert", "Drink" };

        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            //this.categoryList = categoryList;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }
    }
}
