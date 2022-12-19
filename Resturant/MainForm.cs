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
        public static LoginForm loginForm = new LoginForm();
        public static EditMenu editMenu = new EditMenu();
        public static int OrdNo = 1, Ordincrement = 100, sum;

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SHADENH\Desktop\gorsel-programlama-donem-projesi-231-smh-restoran-otomasyonu\Resturant\Database.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(Sqlcon);
        private void EditMenuBtn_Click(object sender, EventArgs e)
        {
            editMenu.Show();
        }

        private void MakeOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.orderForm.Show();
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (GroupBox1.Visible == true) GroupBox1.Visible = false;
            else GroupBox1.Visible = true; Createcaptcha();
        }

        public void Order()
        {
            int OrderNumber = OrdNo + Ordincrement;
            if (OrdNo == 1 || OrdNo == 11 || OrdNo == 21 || OrdNo == 31 || OrdNo == 41 || OrdNo == 51 || OrdNo == 61 || OrdNo == 71 || OrdNo == 81 || OrdNo == 91)
            {
                OrderGroup1.Text = "Order Number: " + OrderNumber; ListOrder1.Items.Clear();
                ListOrder1.Items.Add("Order Details:-"); ListOrder1.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder1.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 2 || OrdNo == 12 || OrdNo == 22 || OrdNo == 32 || OrdNo == 42 || OrdNo == 52 || OrdNo == 62 || OrdNo == 72 || OrdNo == 82 || OrdNo == 92)
            {
                OrderGroup2.Text = "Order Number: " + OrderNumber; ListOrder2.Items.Clear();
                ListOrder2.Items.Add("Order Details:-"); ListOrder2.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder2.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 3 || OrdNo == 13 || OrdNo == 23 || OrdNo == 33 || OrdNo == 43 || OrdNo == 53 || OrdNo == 63 || OrdNo == 73 || OrdNo == 83 || OrdNo == 93)
            {
                OrderGroup3.Text = "Order Number: " + OrderNumber; ListOrder3.Items.Clear();
                ListOrder3.Items.Add("Order Details:-"); ListOrder3.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder3.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 4 || OrdNo == 14 || OrdNo == 24 || OrdNo == 34 || OrdNo == 44 || OrdNo == 54 || OrdNo == 64 || OrdNo == 74 || OrdNo == 84 || OrdNo == 94)
            {
                OrderGroup4.Text = "Order Number: " + OrderNumber; ListOrder4.Items.Clear();
                ListOrder4.Items.Add("Order Details:-"); ListOrder4.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder4.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 5 || OrdNo == 15 || OrdNo == 25 || OrdNo == 35 || OrdNo == 45 || OrdNo == 55 || OrdNo == 65 || OrdNo == 75 || OrdNo == 85 || OrdNo == 95)
            {
                OrderGroup5.Text = "Order Number: " + OrderNumber; ListOrder5.Items.Clear();
                ListOrder5.Items.Add("Order Details:-"); ListOrder5.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder5.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 6 || OrdNo == 16 || OrdNo == 26 || OrdNo == 36 || OrdNo == 46 || OrdNo == 56 || OrdNo == 66 || OrdNo == 76 || OrdNo == 86 || OrdNo == 96)
            {
                OrderGroup6.Text = "Order Number: " + OrderNumber; ListOrder6.Items.Clear();
                ListOrder6.Items.Add("Order Details:-"); ListOrder6.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder6.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 7 || OrdNo == 17 || OrdNo == 27 || OrdNo == 37 || OrdNo == 47 || OrdNo == 57 || OrdNo == 67 || OrdNo == 77 || OrdNo == 87 || OrdNo == 97)
            {
                OrderGroup7.Text = "Order Number: " + OrderNumber; ListOrder7.Items.Clear();
                ListOrder7.Items.Add("Order Details:-"); ListOrder7.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder7.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 8 || OrdNo == 18 || OrdNo == 28 || OrdNo == 38 || OrdNo == 48 || OrdNo == 58 || OrdNo == 68 || OrdNo == 78 || OrdNo == 88 || OrdNo == 98)
            {
                OrderGroup8.Text = "Order Number: " + OrderNumber; ListOrder8.Items.Clear();
                ListOrder8.Items.Add("Order Details:-"); ListOrder8.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder8.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 9 || OrdNo == 19 || OrdNo == 29 || OrdNo == 39 || OrdNo == 49 || OrdNo == 59 || OrdNo == 69 || OrdNo == 79 || OrdNo == 89 || OrdNo == 99)
            {
                OrderGroup9.Text = "Order Number: " + OrderNumber; ListOrder9.Items.Clear();
                ListOrder9.Items.Add("Order Details:-"); ListOrder9.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder9.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 10 || OrdNo == 20 || OrdNo == 30 || OrdNo == 40 || OrdNo == 50 || OrdNo == 60 || OrdNo == 70 || OrdNo == 80 || OrdNo == 90 || OrdNo == 100)
            {
                OrderGroup10.Text = "Order Number: " + OrderNumber; ListOrder10.Items.Clear();
                ListOrder10.Items.Add("Order Details:-"); ListOrder10.Items.Add(""); OrdNo++;
                for (int i = 0; i < LoginForm.payForm.DishList.Items.Count; i++) { ListOrder10.Items.Add(LoginForm.payForm.DishList.Items[i]); }
            }
            else if (OrdNo == 101) { OrdNo = 1; Ordincrement += 100; }
        }
    }
}
