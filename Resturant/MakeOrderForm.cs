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
    public partial class MakeOrderForm : Form
    {
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        string Type;
        public static float total = 0;
        float TempIndex, CurrentPlace;
        int counter = 1;

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SHADENH\Desktop\gorsel-programlama-donem-projesi-231-smh-restoran-otomasyonu\Resturant\Database.mdf;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(Sqlcon);
        public static SqlDataAdapter da;
        public static DataSet ds;

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // it will take you back to the main form .
            this.Hide();
           LoginForm.mainForm.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            // this one is used to delete an item from your order list .  
            int temp = DishList.SelectedIndex;
              if (DishList.SelectedIndex != -1)
              {
                  total -= Convert.ToSingle(PriceList.Items[temp].ToString());
                  DishList.Items.RemoveAt(temp);
                  PriceList.Items.RemoveAt(temp);
              }
              Totallbl.Text = total.ToString();
        }

        private void EndOrderBtn_Click(object sender, EventArgs e)
        {
            // once you click it it will transfer you to the pay form and you have to add something before clicking it other wise it will show you an error .
            LoginForm.payForm.DishList.Items.Clear();
            LoginForm.payForm.PriceList.Items.Clear();
            if (DishList.Items.Count == 0) { MessageBox.Show("You Can't Go To Pay Step With Empty List!!, Please Add Something!"); }
            else
            {
                for (int i = 0; i < DishList.Items.Count; i++)
                {
                    LoginForm.payForm.DishList.Items.Add(DishList.Items[i]);
                    LoginForm.payForm.PriceList.Items.Add(PriceList.Items[i]);
                }
                PayForm.temp = (float)(MakeOrderForm.total * 0.14); LoginForm.payForm.Total.Text = (PayForm.temp + MakeOrderForm.total).ToString();
                LoginForm.payForm.TotalTaxlbl.Text = PayForm.temp.ToString(); LoginForm.payForm.TBTaxlbl.Text = MakeOrderForm.total.ToString();
                LoginForm.payForm.Show();
            }
        }
            

        

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            //this one is used to add an item to your order list so that you can proceed with your oreder .
            try
            {
                float price; string Order = "";
                da = new SqlDataAdapter("select Price from FoodsMenuTb where Data ='" + Foodlist.Text + "' and Type ='" + Type + "'", con);
                ds = new DataSet();
                da.Fill(ds, "FoodsMenuTb");
                if (ds.Tables["FoodsMenuTb"].Rows.Count != 0 && ds.Tables["FoodsMenuTb"].Rows[0][0].ToString() != "NULL" && QuantityCounter.Value > 0)
                {
                    price = Convert.ToSingle(ds.Tables["FoodsMenuTb"].Rows[0][0]);
                    if (counter <= 1)
                    {
                        total += price * Convert.ToSingle(QuantityCounter.Value);
                        PriceList.Items.Add(price * Convert.ToInt32(QuantityCounter.Value));
                        DishList.Items.Add(Foodlist.Text + "\tx" + Convert.ToInt32(QuantityCounter.Value));
                        Totallbl.Text = total.ToString(); QuantityCounter.Value = 1;
                    }
                    else
                    {
                        if (counter >= 3)
                        {
                            da = new SqlDataAdapter("select Data from FoodsMenuTb where Place ='" + Convert.ToInt32(CurrentPlace) + "' and Type ='" + Type + "'", con);
                            ds = new DataSet();
                            da.Fill(ds, "FoodsMenuTb");
                            Order += ds.Tables["FoodsMenuTb"].Rows[0][0].ToString() + " ";
                        }
                        da = new SqlDataAdapter("select Data from FoodsMenuTb where Place ='" + CurrentPlace + "' and Type ='" + Type + "'", con);
                        ds = new DataSet();
                        da.Fill(ds, "FoodsMenuTb");
                        if (ds.Tables["FoodsMenuTb"].Rows.Count != 0)
                        {
                            Order += ds.Tables["FoodsMenuTb"].Rows[0][0].ToString() + " " + Foodlist.Text;
                            total += price * Convert.ToSingle(QuantityCounter.Value);
                            PriceList.Items.Add(price * Convert.ToInt32(QuantityCounter.Value));
                            DishList.Items.Add(Order + "\tx" + Convert.ToInt32(QuantityCounter.Value));
                            Totallbl.Text = total.ToString(); QuantityCounter.Value = 1;
                        }
                    }
                }
            }
            catch { }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
          //it will take you back to all the category if you have and entered into one . 
            FoodBtn.Visible = true; DessertBtn.Visible = true; EntreesBtn.Visible = true; NextBtn.Visible = false; Quantitylbl.Visible = false;
            SoupsBtn.Visible = true; DrinksBtn.Visible = true; BackCateBtn.Visible = false; QuantityCounter.Visible = false;
            Foodlist.Visible = false; AddOrderBtn.Visible = false; BackBtn.Visible = false; Foodlist.Items.Clear(); counter = 1;
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            Type = "Foods"; inCate();
            da = new SqlDataAdapter("SELECT Data FROM FoodsMenuTb WHERE [index]=0 and Type='" + Type + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "FoodsMenuTb");
            for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
            con.Close();
        }

        private void DessertBtn_Click(object sender, EventArgs e)
        {
            Type = "Dessert"; inCate();
            da = new SqlDataAdapter("SELECT Data FROM FoodsMenuTb WHERE [index]=0 and Type='" + Type + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "FoodsMenuTb");
            for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
            con.Close();
        }

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            Type = "Drinks"; inCate();
            da = new SqlDataAdapter("SELECT Data FROM FoodsMenuTb WHERE [index]=0 and Type='" + Type + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "FoodsMenuTb");
            for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
            con.Close();
        }

        private void EntreesBtn_Click(object sender, EventArgs e)
        {
            Type = "Entrees"; inCate();
            da = new SqlDataAdapter("SELECT Data FROM FoodsMenuTb WHERE [index]=0 and Type='" + Type + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "FoodsMenuTb");
            for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
            con.Close();
        }

        private void SoupsBtn_Click(object sender, EventArgs e)
        {
            Type = "Soups"; inCate();
            da = new SqlDataAdapter("SELECT Data FROM FoodsMenuTb WHERE [index]=0 and Type='" + Type + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "FoodsMenuTb");
            for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
            con.Close();
        }

        private void DishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceList.SelectedIndex = DishList.SelectedIndex;
        }

        private void PriceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishList.SelectedIndex = PriceList.SelectedIndex;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            // its made so that you can transfer between the categories and dishes .
            NextBtn.Enabled = true;
            da = new SqlDataAdapter("select Data from FoodsMenuTb where [index] ='" + TempIndex + "' and Type ='" + Type + "'", con);
            ds = new DataSet();
            da.Fill(ds, "FoodsMenuTb");
            if (ds.Tables["FoodsMenuTb"].Rows.Count != 0)
            {
                counter--; Foodlist.Items.Clear();
                for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
                da = new SqlDataAdapter("select [index],Place from FoodsMenuTb where Place ='" + TempIndex + "' and Type ='" + Type + "'", con);
                ds = new DataSet();
                da.Fill(ds, "FoodsMenuTb");
                if (ds.Tables["FoodsMenuTb"].Rows.Count != 0)
                {
                    TempIndex = Convert.ToSingle(ds.Tables["FoodsMenuTb"].Rows[0][0]);
                    CurrentPlace = Convert.ToSingle(ds.Tables["FoodsMenuTb"].Rows[0][1]);
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            // its made so that you can transfer between the categories and dishes .
            if (Foodlist.SelectedIndex != -1)
            {
                float temp1;
                con = new SqlConnection(Sqlcon);
                con.Open();
                string query = "select [index],Place from FoodsMenuTb where Data ='" + Foodlist.Text + "' and Type ='" + Type + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    temp1 = Convert.ToSingle(dtable.Rows[0][1]);
                    da = new SqlDataAdapter("select Data from FoodsMenuTb where [index] ='" + temp1 + "' and Type ='" + Type + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "FoodsMenuTb");
                    if (ds.Tables["FoodsMenuTb"].Rows.Count != 0 && ds.Tables["FoodsMenuTb"].Rows[0][0].ToString() != "NULL")
                    {
                        TempIndex = Convert.ToSingle(dtable.Rows[0][0]);
                        CurrentPlace = Convert.ToSingle(dtable.Rows[0][1]);
                        counter++; Foodlist.Items.Clear(); BackBtn.Enabled = true;
                        for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++) Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
                    }
                    con.Close();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.mainForm.Show();
        }

        void inCate()
        {
            FoodBtn.Visible = false; DessertBtn.Visible = false; EntreesBtn.Visible = false; Quantitylbl.Visible = true;
            SoupsBtn.Visible = false; DrinksBtn.Visible = false; BackCateBtn.Visible = true; NextBtn.Visible = true;
            Foodlist.Visible = true; BackBtn.Visible = true; AddOrderBtn.Visible = true; QuantityCounter.Visible = true;
        }




    }
}