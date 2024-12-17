using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class Login : Form
    {
        // Connection String
        SqlConnection conn = new SqlConnection(@"");

        public Login()
        {
            InitializeComponent();

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

            button4.BackColor = Color.FromArgb(75, 8, 100);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;

            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;

            button5.BackColor = Color.FromArgb(75, 8, 100);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;

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

            button8.MouseEnter += (sender, e) =>
            {
                button8.BackColor = Color.FromArgb(75, 8, 100);
            };

            button8.MouseLeave += (sender, e) =>
            {
                button8.BackColor = Color.Transparent;
            };

            panel1.Visible = true;
            panel4.Visible = false;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.panel9.MouseDown += panel9_MouseDown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string selectdata = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex, "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string selectusername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkuser = new SqlCommand(selectusername, conn))
                        {
                            checkuser.Parameters.AddWithValue("@user", textBox4.Text.Trim());

                            int count = (int)checkuser.ExecuteScalar();
                            if (count > 1)
                            {
                                MessageBox.Show(textBox4.Text.Trim() + " is already taken", "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertdata = "INSERT INTO users (username, password, date_register) VALUES(@username, @password, @date_register)";
                                using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                                {
                                    cmd.Parameters.AddWithValue("@username", textBox4.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();

                                    panel1.Visible = true;
                                    panel4.Visible = false;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex, "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
