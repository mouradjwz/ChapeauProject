using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public class SalesDao : BaseDao
    {
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT Item.Price as [Price], FROM Item, JOIN [Order_Items] ON Order_ID = Order_ID," +
                "JOIN [Order] ON Order_ID = Order_ID" +
                "Where Table_IS is @TableID ";
        return orders;
        }
    }
}
