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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resturant
{
    public partial class EditMenu : Form
    {

        static string Sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmrkh\Documents\GitHub\gorsel-programlama-donem-projesi-231-smh-restoran-otomasyonu\Resturant\Database.mdf;Integrated Security=True";
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

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true) { TextBox1.Text = Foodlist.Text; TextBox1.Enabled = false; }
            else { TextBox1.Clear(); TextBox1.Enabled = true; }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true) { TextBox2.Clear(); TextBox2.Enabled = true;  }
            else { TextBox2.Text = listBox1.Text; TextBox2.Enabled = false; }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackBtn.Visible = NextBtn.Visible = FinishButton.Visible = true;
            Foodlist.Items.Clear(); listBox1.Items.Clear(); listBox2.Items.Clear();
            da = new SqlDataAdapter("SELECT Data,Price,ID FROM FoodsMenuTb WHERE [index]=0 and Type='" + ComboBox1.Text + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Foodlist.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                listBox2.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                if (ds.Tables[0].Rows[i][1].ToString() == "") listBox1.Items.Add("Category");
                else listBox1.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != -1)
            {
                label8.Visible = TextBox1.Visible = TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = guna2CheckBox1.Visible = false;
            }
            if (RadioButton.Checked == true)
            {
                label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = false; FinishButton.Text = "Modify";
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != -1)
            {
                label8.Visible = TextBox1.Visible = true; label8.Text = "Enter The New Category Name:"; TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = guna2CheckBox1.Visible = false;
            }
            if (RadioButton1.Checked == true)
            {
                label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = true;
                label6.Text = "A New Category In Another Category";
                label5.Text = "A Completely New Category";
                FinishButton.Text = "Add";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex != -1)
            {
                label8.Text = "Enter A New Name For The Dish:"; label8.Visible = TextBox1.Visible = label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = TextBox2.Enabled = TextBox2.Visible = label9.Visible = true;
            }
            if (RadioButton2.Checked == true)
            {
                label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = true;
                FinishButton.Text = "Add"; label5.Text = "I Want To Add A New Dish In The Main List";
                label6.Text = "I Want To Add A New Dish Inside Category";
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked == true)
            {
                label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = label8.Visible = TextBox1.Visible = TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = guna2CheckBox1.Visible = false;
                FinishButton.Text = "Remove";
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                label5.Visible = label6.Visible = RadioButton6.Visible = RadioButton7.Visible = label8.Visible = TextBox1.Visible = TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = guna2CheckBox1.Visible = false;
                FinishButton.Text = "Remove";
            }
        }

        private void Foodlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex = Foodlist.SelectedIndex;
            if (Foodlist.SelectedIndex != -1 && RadioButton.Checked == true)
            {
                if (listBox1.Items[Foodlist.SelectedIndex].ToString() == "Category") { label8.Visible = TextBox1.Visible = true; label8.Text = "Enter The New Category Name:"; TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = guna2CheckBox1.Visible = false; }
                else { TextBox2.Text = listBox1.Text; label8.Text = "Enter A New Name For The Dish:"; TextBox2.Visible = label9.Visible = guna2CheckBox2.Visible = label8.Visible = TextBox1.Visible = guna2CheckBox1.Visible = true;  }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (Foodlist.SelectedIndex != -1)
            {
                float temp1;
                con = new SqlConnection(Sqlcon);
                con.Open();
                string query = "select [index],Place from FoodsMenuTb where Data ='" + Foodlist.Text + "' and Type ='" + ComboBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    temp1 = Convert.ToSingle(dtable.Rows[0][1]);
                    da = new SqlDataAdapter("select Data,Price,ID from FoodsMenuTb where [index] ='" + temp1 + "' and Type ='" + ComboBox1.Text + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "FoodsMenuTb");
                    if (ds.Tables["FoodsMenuTb"].Rows.Count != 0 && ds.Tables["FoodsMenuTb"].Rows[0][0].ToString() != "NULL")
                    {
                        TempIndex = Convert.ToSingle(dtable.Rows[0][0]);
                        CurrentPlace = Convert.ToSingle(dtable.Rows[0][1]); listBox2.Items.Clear();
                        counter++; Foodlist.Items.Clear(); listBox1.Items.Clear(); BackBtn.Enabled = true;
                        for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++)
                        {
                            Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
                            listBox2.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][2].ToString());
                            if (ds.Tables["FoodsMenuTb"].Rows[i][1].ToString() == "") listBox1.Items.Add("Category");
                            else listBox1.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][1].ToString());
                        }
                    }
                }
                con.Close();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            NextBtn.Enabled = true;
            da = new SqlDataAdapter("select Data,Price,ID from FoodsMenuTb where [index] ='" + TempIndex + "' and Type ='" + ComboBox1.Text + "'", con);
            ds = new DataSet();
            da.Fill(ds, "FoodsMenuTb");
            if (ds.Tables["FoodsMenuTb"].Rows.Count != 0)
            {
                counter--; Foodlist.Items.Clear(); listBox1.Items.Clear(); listBox2.Items.Clear();
                for (int i = 0; i < ds.Tables["FoodsMenuTb"].Rows.Count; i++)
                {
                    Foodlist.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][0].ToString());
                    listBox2.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][2].ToString());
                    if (ds.Tables["FoodsMenuTb"].Rows[i][1].ToString() == "") listBox1.Items.Add("Category");
                    else listBox1.Items.Add(ds.Tables["FoodsMenuTb"].Rows[i][1].ToString());
                }
                da = new SqlDataAdapter("select [index],Place from FoodsMenuTb where Place ='" + TempIndex + "' and Type ='" + ComboBox1.Text + "'", con);
                ds = new DataSet();
                da.Fill(ds, "FoodsMenuTb");
                if (ds.Tables["FoodsMenuTb"].Rows.Count != 0)
                {
                    TempIndex = Convert.ToSingle(ds.Tables["FoodsMenuTb"].Rows[0][0]);
                    CurrentPlace = Convert.ToSingle(ds.Tables["FoodsMenuTb"].Rows[0][1]);
                }
            }
            else NextBtn.Enabled = false;
            if (counter == 1) BackBtn.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Foodlist.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex;
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
                updatelist();
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
                updatelist();
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
                updatelist();
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
                updatelist();
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
                updatelist();
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
                updatelist();
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
                updatelist();

            }
        }

        void updatelist() {
            con.Open();
            Foodlist.Items.Clear(); listBox1.Items.Clear(); listBox2.Items.Clear();
            da = new SqlDataAdapter("SELECT Data,Price,ID FROM FoodsMenuTb WHERE [index]=0 and Type='" + ComboBox1.Text + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Foodlist.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                listBox2.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                if (ds.Tables[0].Rows[i][1].ToString() == "") listBox1.Items.Add("Category");
                else listBox1.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
            con.Close();
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
