using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace Service
{
    public class DishService
    {
        DishDao dishDao;
        public DishService()
        {
            dishDao = new DishDao();
        }
        List<Dish> GetAllDishes()
        {
            return dishDao.GetAllDishes();
        }

        Dish GetDishById(int id)
        {
            return dishDao.GetDishById(id);
        }

        List<Dish> GetLunchDishes()
        {
            return dishDao.GetLunchDishes();
        }

        List<Dish> GetDinnerDishes()
        {
            return dishDao.GetDinnerDishes();
        }

        List<Dish> GetStartersFromDishes(List<Dish> dishes)
        {
            return dishes.Where(a => a.Subcategory == 0).ToList();
        }

        List<Dish> GetMainsFromDishes(List<Dish> dishes)
        {
            return dishes.Where(a => a.Subcategory == 1).ToList();
        }

        List<Dish> GetDinnersFromDishes(List<Dish> dishes)
        {
            return dishes.Where(a => a.Subcategory == 2).ToList();
        }

        List<Dish> GetEntremetsFromDishes(List<Dish> dishes)
        {
            return dishes.Where(a => a.Subcategory == 3).ToList();
        }
    } 
}
