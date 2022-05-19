using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Dish : Item
    {
        public string Dish_Name { get; set; }
        public int Type_Of_Dish { get; set; } //0 - Lunch, 1 - Dinner
        public int Subcategory { get; set; } //0 - Starter, 1 - Main, 2 - Dessert, 3 - Entremets
    }
}
