using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderView : Form
    {
        Table _table;
        DateTime _time;
        public OrderView(Table table, DateTime time)
        {
            InitializeComponent();
            _table = table;
            _time = time;
        }
    }
}
