using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            Reset();
            dashboard_Design1.Show();

            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;

            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;

            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;

            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;

            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;

            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;

            button1.MouseEnter += (sender, e) =>
            {
                button1.BackColor = Color.FromArgb(75, 8, 100);
                button1.ForeColor = Color.Red;
            };

            button1.MouseLeave += (sender, e) =>
            {
                button1.BackColor = Color.Transparent;
                button1.ForeColor = Color.White;
            };

            button2.MouseEnter += (sender, e) =>
            {
                button2.BackColor = Color.FromArgb(75, 8, 100);
                button2.ForeColor = Color.Pink;
            };

            button2.MouseLeave += (sender, e) =>
            {
                button2.BackColor = Color.Transparent;
                button2.ForeColor = Color.White;
            };

            button3.MouseEnter += (sender, e) =>
            {
                button3.BackColor = Color.FromArgb(75, 8, 100);
            };

            button3.MouseLeave += (sender, e) =>
            {
                button3.BackColor = Color.Transparent;
            };

            button4.MouseEnter += (sender, e) =>
            {
                button4.BackColor = Color.FromArgb(75, 8, 100);
            };

            button4.MouseLeave += (sender, e) =>
            {
                button4.BackColor = Color.Transparent;
            };

            button5.MouseEnter += (sender, e) =>
            {
                button5.BackColor = Color.FromArgb(75, 8, 100);
            };

            button5.MouseLeave += (sender, e) =>
            {
                button5.BackColor = Color.Transparent;
            };

            button6.MouseEnter += (sender, e) =>
            {
                button6.BackColor = Color.FromArgb(75, 8, 100);
                button6.ForeColor = Color.Red;
            };

            button6.MouseLeave += (sender, e) =>
            {
                button6.BackColor = Color.Transparent;
                button6.ForeColor = Color.White;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.panel2.MouseDown += panel2_MouseDown;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Reset() 
        {
            addEmployee1.Hide();
            dashboard_Design1.Hide();
            salary1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            dashboard_Design1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            addEmployee1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset();
            salary1.Show();
        }
    }
}
