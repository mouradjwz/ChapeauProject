using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DAL
{
    public class SalesDao : BaseDao
    {
        public Bill GetBill(Table table)
        {
            string query = "SELECT SUM(Item.Price) as Price, FROM Item, JOIN [Order_Items] ON Order_ID = Order_ID," +
                "JOIN [Order] ON Order_ID = Order_ID" +
                "Where Table_IS is @TableID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableID", table.Id), };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bill ReadTables(DataTable dataTable)
        {
            Bill bill = new Bill();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    bill.BillId = (int)dr["ID"],
                    bill.AmountDue = (int)dr["Price"],
                };
               
            }
            return bill;
        }

       
}
