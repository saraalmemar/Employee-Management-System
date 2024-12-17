using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();

            button1.BackColor = Color.FromArgb(75, 8, 100);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;

            button2.BackColor = Color.FromArgb(75, 8, 100);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;

            button3.BackColor = Color.FromArgb(75, 8, 100);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;

            button4.BackColor = Color.FromArgb(75, 8, 100);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
        }
    }
}
