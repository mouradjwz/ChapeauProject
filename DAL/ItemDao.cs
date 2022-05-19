using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class ItemDao : BaseDao
    {
        public Item GetItemById(int itemId)
        {
            string query = "SELECT Item_ID, Price, Stock FROM Items WHERE Item_ID = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id",itemId)};
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    Item_ID = (int)dr["Item_ID"],
                    Price = (float)dr["Price"],
                    Stock = (int)dr["Stock"]
                };
                items.Add(item);
            }
            return items;
        }
    }
}
