
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {
            string query = "SELECT Item_ID, Drink_Name, Drink_Type, Subcategory FROM dbo.Drink";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drinks GetDrinkById(int drinkId)
        {
            string query = "SELECT Item_ID, Drink_Name, Drink_Type, Subcategory FROM dbo.Drink WHERE Item_Id = @DrinksId";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinksId", drinkId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks()
                {
                    Item_ID = (int)dr["Item_ID"],
                    Drink_Type = (int)dr["Drink_Type"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
