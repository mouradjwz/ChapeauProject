using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class StaffDao : BaseDao
    {
        public Staff LoginStaff(int staffID, int passCode)
        {
            SqlCommand cmd = new SqlCommand("select Staff_ID, First_Name, Last_Name, Passcode, Has_Permission WHERE [Passcode] = @pass and [Staff_ID] = @ID ", conn);
            cmd.Parameters.AddWithValue("@pass", passCode);
            cmd.Parameters.AddWithValue("@ID", staffID);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Staff staff = ReadStaff(reader);
            conn.Close();
            reader.Close();

            if (staff == null)
            {
                return null;
            }

            return staff;
        }

        public Staff ReadStaff(SqlDataReader reader)
        {
            Staff staff = new Staff
            {
                FirstName = (string)reader["First_Name"],
                LastName = (string)reader["Last_Name"],
                StaffID = (int)reader["Staff_ID"],
                PassCode = (int)reader["Passcode"],
                HasPermission = (int)reader["Has_Permission"]
            };

            return staff;
        }
    }
}
