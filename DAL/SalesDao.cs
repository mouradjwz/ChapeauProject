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
                    //tip and total set to 0 for now, will add tip once the user enters it
                    // then add up tip and amount due to make total due.
                    bill.BillId = (int)dr["ID"];
                    bill.AmountDue = (int)dr["Price"];
                    bill.Tip = 0;
                    bill.TotalDue = 0;
                    bill.Feedback = "n/a";
                };

            }
            return bill;
        }


    }
}

