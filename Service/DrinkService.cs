using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    class DrinkService
    {
        DrinksDao drinksDao;
        public DrinkService()
        {
            drinksDao = new DrinksDao();
        }

        public List<Drinks> GetAllDrinks()
        {
            return drinksDao.GetAllDrinks();
        }

        public Drinks GetDrinkById(int id)
        {
            return drinksDao.GetDrinkById(id);
        }

        public List<Drinks> GetSoftDrinksFromDrinks(List<Drinks> drinks)
        {
            return drinks.Where(a => a.Drink_Type == 0).ToList();
        }

        public List<Drinks> GetBeersFromDrinks(List<Drinks> drinks)
        {
            return drinks.Where(a => a.Drink_Type == 1).ToList();
        }

        public List<Drinks> GetWinesFromDrinks(List<Drinks> drinks)
        {
            return drinks.Where(a => a.Drink_Type == 2).ToList();
        }

        public List<Drinks> GetSpiritsFromDrinks(List<Drinks> drinks)
        {
            return drinks.Where(a => a.Drink_Type == 3).ToList();
        }

        public List<Drinks> GetWarmDrinksFromDrinks(List<Drinks> drinks)
        {
            return drinks.Where(a => a.Drink_Type == 4).ToList();
        }
    }
}
