using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public  class Staff
    {
        public string firstName;
        public string lastname;
        public int staffId;
        public int passCode;

        //variables or properties?
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffID { get; set; }

        public Staff(string firstName, string lastName, int staffId, int passCode)
        {
            this.firstName = firstName;
            this.lastname = lastName;
            this.staffId = staffId;
            this.passCode = passCode;
        }
    }
}
