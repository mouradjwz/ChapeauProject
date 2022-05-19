using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    class OrderDao : BaseDao
    {
        Order GetOrderById(int orderId)
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
