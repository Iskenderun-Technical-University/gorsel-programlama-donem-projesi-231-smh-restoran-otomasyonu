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
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            /*LoginForm.Form1.Order();
            MakeOrderForm.total = 0;
            ClearTable();
            this.Hide();
            Form1.PayForm.DishList.Items.Clear();
            Form1.PayForm.PriceList.Items.Clear();
            Form1.PayForm.Hide();
            Form1.OrderForm.DishList.Items.Clear();
            Form1.OrderForm.PriceList.Items.Clear();
            Form1.OrderForm.Totallbl.Text = "";
            Form1.OrderForm.BackCateBtn.PerformClick();
            Form1.OrderForm.Hide();
            LoginForm.Form1.Show();*/
            for (int i = 0; i < DishList.Items.Count; i++)
            {
                con.Open();
                string query = "insert into TempBillTb ([Food Name],Price) values('" + DishList.Items[i].ToString() + "','" + Convert.ToSingle(PriceList.Items[i]) + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            da = new SqlDataAdapter("select * From TempBillTb", con);
            ds = new DataSet();
            //BillReport billReport = new BillReport();
            //TextObject text = (TextObject)billReport.ReportDefinition.Sections["Section4"].ReportObjects["Text12"];
           // da.Fill(ds);
           // billReport.SetDataSource(ds.Tables[0]);
           // text.Text = Total.Text;
           // Form1.BillForm.crystalReportViewer1.ReportSource = billReport;
           // Form1.BillForm.Show();
        }
}
}
