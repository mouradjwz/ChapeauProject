using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Table
    {
        public int Id { get; set; }
        public int NumberOfPeople { get; set; }
        public int TableStatus { get; set; }

        public Table(int tableId, int numberOfPeople, int tableStatus)
        {
            Id = tableId;
            NumberOfPeople = numberOfPeople;
            TableStatus = tableStatus;
        }
    }
}
