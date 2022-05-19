using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class StaffDao : BaseDao
    {
        public Staff LoginStaff(string firstName, int PassCode)
        {

        }

        public Staff ReadUser(SqlDataReader reader)
        {
            Staff staff = new Staff();

            return staff;
        }
    }
}
