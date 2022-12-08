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
    public partial class EditMenu : Form
    {

        static string Sqlcon = @"";
        SqlConnection con = new SqlConnection(Sqlcon);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        float TempIndex, CurrentPlace;
        int counter = 1;
        public EditMenu()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true && RadioButton7.Checked == true)
            {
                da = new SqlDataAdapter("select Place From FoodsMenuTb Where [index]='" + 0 + "' and Type='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                int temp = 1;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                    temp++;
                }
                con.Open();
                SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + 0 + "','" + temp + "','" + ComboBox1.Text + "')", con);
                command.ExecuteNonQuery();
                con.Close();
            }
            else if (RadioButton2.Checked == true && RadioButton7.Checked == true)
            {
                da = new SqlDataAdapter("select Place From FoodsMenuTb Where [index]='" + 0 + "' and Type='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                int temp = 1;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                    temp++;
                }
                con.Open();
                SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + 0 + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                command.ExecuteNonQuery();
                con.Close();
            }
            else if (RadioButton4.Checked == true)
            {
                if (listBox1.Items[Foodlist.SelectedIndex].ToString() == "Category")
                {
                    MessageBox.Show("You Can't Delete Category From Here, Please Select Remove Category Choise From The Left Corner!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                SqlCommand command = new SqlCommand("Delete From FoodsMenuTb Where Data='" + Foodlist.Text + "'and ID='" + listBox2.Items[Foodlist.SelectedIndex].ToString() + "'and Type='" + ComboBox1.Text + "' and Price='" + listBox1.Items[Foodlist.SelectedIndex].ToString() + "'", con);
                if (MessageBox.Show("Are You Sure That You Want Delete The Dish: " + Foodlist.Text + " From The Menu?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Close();
                    return;
                }
            }
            else if (RadioButton3.Checked == true)
            {
                listBox1.Items.Clear();

                con.Open();
                SqlCommand command = new SqlCommand("select Place From FoodsMenuTb Where ID='" + listBox2.Items[Foodlist.SelectedIndex] + "'", con);
                float place = Convert.ToSingle(command.ExecuteScalar());
                command = new SqlCommand("Delete From FoodsMenuTb Where ID='" + listBox2.Items[Foodlist.SelectedIndex] + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                DeleteCategory(place, ComboBox1.Text);

            }

            if (Foodlist.SelectedIndex == -1)
            {
                return;
            }
            else if (TextBox1.Text == "") return;
            else if (RadioButton.Checked == true)
            {
                if (TextBox2.Visible == false)
                {
                    if (MessageBox.Show("Are You Sure That You Want To Change " + Foodlist.Text + " To " + TextBox1.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE FoodsMenuTb SET Data ='" + TextBox1.Text + "' Where Data='" + Foodlist.Text + "'and [index]='" + CurrentPlace + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else return;
                }
                else if (TextBox2.Visible == true && guna2CheckBox1.Checked == false)
                {
                    if (MessageBox.Show("Are You Sure That You Want To Change " + Foodlist.Text + " To " + TextBox1.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE FoodsMenuTb SET Data ='" + TextBox1.Text + "' Where Data='" + Foodlist.Text + "' and [index]='" + CurrentPlace + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else return;

                }
                else if (TextBox2.Visible == true && guna2CheckBox1.Checked == true)
                {
                    if (MessageBox.Show("Are You Sure That You Want To Change This Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE FoodsMenuTb SET Data ='" + TextBox1.Text + "',Price='" + Convert.ToSingle(TextBox2.Text) + "' Where Data='" + Foodlist.Text + "' and [index]='" + CurrentPlace + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else return;
                }
            }
            else if (RadioButton1.Checked == true && RadioButton6.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Place from FoodsMenuTb where Data ='" + Foodlist.Text + "' and Type ='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                sda.Fill(ds);
                float tempcurrent = Convert.ToSingle(ds.Tables[0].Rows[0][0]);
                da = new SqlDataAdapter("select Place From FoodsMenuTb Where [index]='" + tempcurrent + "' and Type='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                if (counter == 1)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.1);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.1);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.1);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 2)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.01);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.01);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.01);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 3)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 4)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.0001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.0001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.0001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 5)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.00001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.00001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.00001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter >= 6) { MessageBox.Show("You Have Reached To The Last Page!! You Can't Add More Dishes/Categories!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            else if (RadioButton2.Checked == true && RadioButton6.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Place from FoodsMenuTb where Data ='" + Foodlist.Text + "' and Type ='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                sda.Fill(ds);
                float tempcurrent = Convert.ToSingle(ds.Tables[0].Rows[0][0]);
                da = new SqlDataAdapter("select Place From FoodsMenuTb Where [index]='" + tempcurrent + "' and Type='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                if (counter == 1)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.1);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.1);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.1);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 2)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.01);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.01);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.01);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 3)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 4)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.0001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.0001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.0001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 5)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.00001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.00001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.00001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 6)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.000001);
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (ds.Tables[0].Rows.Count < 10)
                    {
                        float temp = tempcurrent + Convert.ToSingle(0.000001);
                        con.Open();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i][0].ToString() != temp.ToString()) { break; }
                            temp = temp + Convert.ToSingle(0.000001);
                        }
                        SqlCommand command = new SqlCommand("insert into FoodsMenuTb (Data,[index],Place,Price,Type) values ('" + TextBox1.Text + "','" + tempcurrent + "','" + temp + "','" + TextBox2.Text + "','" + ComboBox1.Text + "')", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (counter == 7) { MessageBox.Show("You Have Reached To The Last Page!! You Can't Add More Dishes/Categories!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }

            void DeleteCategory(float place, string type)
            {
                da = new SqlDataAdapter("select ID,Place,Price From FoodsMenuTb Where [index]='" + place + "' and Type='" + type + "'", con);
                DataTable dataTableMain = new DataTable();
                da.Fill(dataTableMain);
                for (int i = 0; i < dataTableMain.Rows.Count; i++)
                {
                    if (dataTableMain.Rows[i][2].ToString() != "")
                    {
                        con.Open();
                        cmd = new SqlCommand("Delete From FoodsMenuTb Where ID='" + dataTableMain.Rows[i][0].ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        da = new SqlDataAdapter("select ID,Place From FoodsMenuTb Where [index]='" + dataTableMain.Rows[i][1].ToString() + "' and Type='" + type + "'", con);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        if (dataTable.Rows.Count == 0)
                        {
                            con.Open();
                            cmd = new SqlCommand("Delete From FoodsMenuTb Where ID='" + dataTableMain.Rows[i][0].ToString() + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            return;
                        }
                        else
                        {
                            place = Convert.ToSingle(dataTableMain.Rows[i][1]);
                            con.Open();
                            cmd = new SqlCommand("Delete From FoodsMenuTb Where ID='" + dataTableMain.Rows[i][0].ToString() + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DeleteCategory(place, type);
                        }
                    }
                }

            }
        }
    }
}
