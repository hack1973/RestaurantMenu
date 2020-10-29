using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testMenu = new Menu(AddMenu);
            //Console.WriteLine("Menu:\n" + testMenu.PrintMenu());//(should be empty list for now)

            var testDate = new DateTime(2020, 03, 21);//gets user input
            var test = new MenuItem(1.99, "Salad", "Appetizer", true);
            Console.WriteLine("Sanity Check:\n" + "Price: " + test.Price + "\nDescription: " + test.Description + "\nCategory: " + test.Category + "\nNew item(True or False): " + test.IsNew);//check content (sanity check)
            //check if menu item input is included already in menu
            //add the menu item to the list
            //testMenu.AddMenu(test);
        }
    }
}
