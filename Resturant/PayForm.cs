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

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < DishList.Items.Count; i++)
            {
                con.Open();
                string query = "insert into TempBillTb ([Food Name],Price) values('" + DishList.Items[i].ToString() + "','" + Convert.ToSingle(PriceList.Items[i]) + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            da = new SqlDataAdapter("select * From TempBillTb", con);
            ds = new DataSet();
            BillReport billReport = new BillReport();
            TextObject text = (TextObject)billReport.ReportDefinition.Sections["Section4"].ReportObjects["Text12"];
            da.Fill(ds);
            billReport.SetDataSource(ds.Tables[0]);
            text.Text = Total.Text;
            Form1.BillForm.crystalReportViewer1.ReportSource = billReport;
            Form1.BillForm.Show();*/

    }
}
}
