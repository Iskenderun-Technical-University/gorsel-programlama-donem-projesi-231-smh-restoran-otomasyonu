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


namespace Resturant
{
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }
        public static string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Resturant Application Version 1.0\Resturant Application\Database.mdf;Integrated Security = True";
        public static SqlConnection con = new SqlConnection(sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static float temp;
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            LoginForm.mainForm.Order();
            MakeOrderForm.total = 0;
            DishList.Items.Clear();
            PriceList.Items.Clear();
            this.Hide();
            LoginForm.orderForm.DishList.Items.Clear();
            LoginForm.orderForm.PriceList.Items.Clear();
            LoginForm.orderForm.Totallbl.Text = "";
            LoginForm.orderForm.BackCateBtn.PerformClick();
            LoginForm.orderForm.Hide();
            LoginForm.mainForm.Show();
            
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
