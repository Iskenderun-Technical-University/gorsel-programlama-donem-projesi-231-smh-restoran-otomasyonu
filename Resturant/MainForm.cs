using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resturant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static MakeOrderForm OrderForm = new MakeOrderForm();
        public static LoginForm loginForm = new LoginForm();
   
        static int sum = 0;

        static string Sqlcon = @"";
        SqlConnection con = new SqlConnection(Sqlcon);
        private void EditMenuBtn_Click(object sender, EventArgs e)
        {
            EditMenu f = new EditMenu();

            if (false == null)
            {
                f = new EditMenu();
                f.Show();
            }
            else
            {
                f.Show();

            }
            // EditMenu.Show();
        }

        private void MakeOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm.Show();
        }

        void Createcaptcha()
        {
            Random r = new Random();
            int temp1 = r.Next(0, 49);
            int temp2 = r.Next(0, 50);
            sum = temp1 + temp2;
            label5.Text = temp1.ToString() + "+" + temp2.ToString();
        }
        Boolean Checkcaptcha()
        {
            if (TextBox4.Text == sum.ToString()) return true;
            else return false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (Checkcaptcha())
            {
                if (TextBox2.Text != TextBox3.Text) { MessageBox.Show("The Entering Password Isn't The Same! Please Try Again"); TextBox2.Clear(); TextBox3.Clear(); TextBox4.Clear(); Createcaptcha(); }
                else
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select Password from LoginTb Where UserID='" + LoginForm.userid + "'", con);
                    if (command.ExecuteScalar().ToString() != TextBox1.Text) { MessageBox.Show("The Old Password Is Wrong! Please Check It And Try Again"); TextBox4.Clear(); Createcaptcha(); }
                    else
                    {
                        command = new SqlCommand("Update LoginTb set Password='" + TextBox3.Text + "' where UserID='" + LoginForm.userid + "'", con);
                        if (command.ExecuteNonQuery() == 1) MessageBox.Show("Your Password Changed Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GroupBox1.Visible = false;
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("The Captcha Is Wrong!, Please Try Again ");
                TextBox4.Clear();
                Createcaptcha();
            }
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (GroupBox1.Visible == true) GroupBox1.Visible = false;
            else GroupBox1.Visible = true; Createcaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
