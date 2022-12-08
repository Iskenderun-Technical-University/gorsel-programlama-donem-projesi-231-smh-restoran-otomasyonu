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

using static System.Net.Mime.MediaTypeNames;

namespace Resturant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Resturant Application Version 1.0\Resturant Application\Database.mdf;Integrated Security = True";
        //public static Form1 Form1 = new Form1();
        public static SqlConnection con = new SqlConnection(sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static string userid, userpassword;
        
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = guna2CustomCheckBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        public void Login()
        {
            try
            {

                string logintry = "select * from LoginTb Where UserID = '" + TxtUserID.Text + "' And Password ='" +TxtPassword.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(logintry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    userid = TxtUserID.Text; userpassword = TxtPassword.Text;
                    TxtUserID.Clear(); TxtPassword.Clear();
                    con.Open();
                    SqlCommand command = new SqlCommand("select UserName from LoginTb where UserID='" + LoginForm.userid + "'", con);
                    //Form1.label1.Text = "Welcome " + command.ExecuteScalar().ToString();
                    con.Close();
                    this.Hide();
                    //Form1.Show();
                }
                else
                {
                    MessageBox.Show("Invaild Login Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserID.Clear(); TxtPassword.Clear(); TxtUserID.Focus();
                }
            }
            catch { MessageBox.Show("Error"); }
        }

    }
}