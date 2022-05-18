using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DishDao : BaseDao
    {
        public List<Dish> GetAllDishes()
        {
            string query = "SELECT Item_ID, Dish_Name, Type_Of_Dish, Subcategory FROM dbo.Dish";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Dish GetDishById(int dishId)
        {
            string query = "SELECT Item_ID, Dish_Name, Type_Of_Dish, Subcategory FROM dbo.Dish WHERE Item_ID = @Dish_ID";
            SqlParameter[] sqlParameters = { new SqlParameter("@Dish_ID",dishId)};
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Dish> GetLunchDishes()
        {
            string query = "SELECT Item_ID, Dish_Name, Type_Of_Dish, Subcategory FROM dbo.Dish WHERE Type_Of_Dish = @Type_Of_Dish";
            SqlParameter[] sqlParameters = { new SqlParameter("@Type_Of_Dish", 0) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDinnerDishes()
        {
            string query = "SELECT Item_ID, Dish_Name, Type_Of_Dish, Subcategory FROM dbo.Dish WHERE Type_Of_Dish = @Type_Of_Dish";
            SqlParameter[] sqlParameters = { new SqlParameter("@Type_Of_Dish", 1) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Dish> ReadTables(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Dish dish = new Dish()
                {
                    Item_ID = (int)dr["Item_ID"],
                    Dish_Name = (string)dr["Dish_Name"],
                    Type_Of_Dish = (int)dr["Type_Of_Dish"],
                    Subcategory = (int)dr["Subcategory"]
                };
                dish = ExtractItemInfo(dish);
                dishes.Add(dish);
            }
            return dishes;
        }

        private Dish ExtractItemInfo(Dish dish)
        {
            ItemDao itemDao = new ItemDao();
            Item item = itemDao.GetItemById(dish.Item_ID);
            Dish dishNew = new Dish()
            {
                Item_ID = dish.Item_ID,
                Dish_Name = dish.Dish_Name,
                Type_Of_Dish = dish.Type_Of_Dish,
                Subcategory = dish.Subcategory,
                Price = item.Price,
                Stock = item.Stock
            };
            return dish;
        }


    }
}
