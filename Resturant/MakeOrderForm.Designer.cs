namespace Resturant
{
    partial class MakeOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrderForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Totallbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.QuantityCounter = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndOrderBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Foodlist = new System.Windows.Forms.ListBox();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.DishList = new System.Windows.Forms.ListBox();
            this.SoupsBtn = new System.Windows.Forms.Button();
            this.DrinksBtn = new System.Windows.Forms.Button();
            this.DessertBtn = new System.Windows.Forms.Button();
            this.EntreesBtn = new System.Windows.Forms.Button();
            this.FoodBtn = new System.Windows.Forms.Button();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 38);
            this.panel1.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1096, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallbl.Location = new System.Drawing.Point(857, 522);
            this.Totallbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(15, 20);
            this.Totallbl.TabIndex = 44;
            this.Totallbl.Text = "-";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.Location = new System.Drawing.Point(165, 537);
            this.Quantitylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(81, 20);
            this.Quantitylbl.TabIndex = 43;
            this.Quantitylbl.Text = "Quantity:";
            this.Quantitylbl.Visible = false;
            // 
            // QuantityCounter
            // 
            this.QuantityCounter.BackColor = System.Drawing.Color.Transparent;
            this.QuantityCounter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityCounter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.QuantityCounter.Location = new System.Drawing.Point(246, 522);
            this.QuantityCounter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityCounter.Name = "QuantityCounter";
            this.QuantityCounter.Size = new System.Drawing.Size(82, 44);
            this.QuantityCounter.TabIndex = 42;
            this.QuantityCounter.UpDownButtonFillColor = System.Drawing.Color.DimGray;
            this.QuantityCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityCounter.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(922, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "EGP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(789, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total:";
            // 
            // EndOrderBtn
            // 
            this.EndOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EndOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EndOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EndOrderBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EndOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EndOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EndOrderBtn.FillColor2 = System.Drawing.Color.Black;
            this.EndOrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndOrderBtn.ForeColor = System.Drawing.Color.White;
            this.EndOrderBtn.Location = new System.Drawing.Point(1004, 581);
            this.EndOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EndOrderBtn.Name = "EndOrderBtn";
            this.EndOrderBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EndOrderBtn.Size = new System.Drawing.Size(119, 106);
            this.EndOrderBtn.TabIndex = 39;
            this.EndOrderBtn.Text = "Go To Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(965, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Dish Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Dish Name";
            // 
            // Foodlist
            // 
            this.Foodlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Foodlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foodlist.FormattingEnabled = true;
            this.Foodlist.ItemHeight = 30;
            this.Foodlist.Location = new System.Drawing.Point(53, 181);
            this.Foodlist.Margin = new System.Windows.Forms.Padding(2);
            this.Foodlist.Name = "Foodlist";
            this.Foodlist.Size = new System.Drawing.Size(387, 270);
            this.Foodlist.TabIndex = 36;
            this.Foodlist.Visible = false;
            // 
            // PriceList
            // 
            this.PriceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceList.FormattingEnabled = true;
            this.PriceList.ItemHeight = 20;
            this.PriceList.Location = new System.Drawing.Point(926, 207);
            this.PriceList.Margin = new System.Windows.Forms.Padding(2);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(162, 282);
            this.PriceList.TabIndex = 35;
            // 
            // DishList
            // 
            this.DishList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DishList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishList.FormattingEnabled = true;
            this.DishList.ItemHeight = 20;
            this.DishList.Location = new System.Drawing.Point(569, 207);
            this.DishList.Margin = new System.Windows.Forms.Padding(2);
            this.DishList.Name = "DishList";
            this.DishList.Size = new System.Drawing.Size(359, 282);
            this.DishList.TabIndex = 34;
            // 
            // SoupsBtn
            // 
            this.SoupsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoupsBtn.BackgroundImage")));
            this.SoupsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoupsBtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoupsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SoupsBtn.Location = new System.Drawing.Point(253, 285);
            this.SoupsBtn.Name = "SoupsBtn";
            this.SoupsBtn.Size = new System.Drawing.Size(206, 187);
            this.SoupsBtn.TabIndex = 33;
            this.SoupsBtn.Text = "Soups";
            this.SoupsBtn.UseVisualStyleBackColor = true;
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrinksBtn.BackgroundImage")));
            this.DrinksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinksBtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DrinksBtn.Location = new System.Drawing.Point(37, 485);
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Size = new System.Drawing.Size(206, 187);
            this.DrinksBtn.TabIndex = 32;
            this.DrinksBtn.Text = "Drinks";
            this.DrinksBtn.UseVisualStyleBackColor = true;
            // 
            // DessertBtn
            // 
            this.DessertBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DessertBtn.BackgroundImage")));
            this.DessertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DessertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DessertBtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertBtn.ForeColor = System.Drawing.Color.White;
            this.DessertBtn.Location = new System.Drawing.Point(253, 82);
            this.DessertBtn.Name = "DessertBtn";
            this.DessertBtn.Size = new System.Drawing.Size(206, 187);
            this.DessertBtn.TabIndex = 31;
            this.DessertBtn.Text = "Dessert";
            this.DessertBtn.UseVisualStyleBackColor = true;
            // 
            // EntreesBtn
            // 
            this.EntreesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EntreesBtn.BackgroundImage")));
            this.EntreesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EntreesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntreesBtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntreesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EntreesBtn.Location = new System.Drawing.Point(37, 285);
            this.EntreesBtn.Name = "EntreesBtn";
            this.EntreesBtn.Size = new System.Drawing.Size(206, 187);
            this.EntreesBtn.TabIndex = 30;
            this.EntreesBtn.Text = "Entrees";
            this.EntreesBtn.UseVisualStyleBackColor = true;
            // 
            // FoodBtn
            // 
            this.FoodBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FoodBtn.BackgroundImage")));
            this.FoodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodBtn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBtn.ForeColor = System.Drawing.Color.White;
            this.FoodBtn.Location = new System.Drawing.Point(37, 82);
            this.FoodBtn.Name = "FoodBtn";
            this.FoodBtn.Size = new System.Drawing.Size(206, 187);
            this.FoodBtn.TabIndex = 29;
            this.FoodBtn.Text = "Foods";
            this.FoodBtn.UseVisualStyleBackColor = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(991, 73);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(132, 50);
            this.guna2GradientButton1.TabIndex = 46;
            this.guna2GradientButton1.Text = "Back To Main Menu";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(53, 450);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(193, 65);
            this.guna2GradientButton2.TabIndex = 47;
            this.guna2GradientButton2.Text = "Back";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.Location = new System.Drawing.Point(246, 450);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(194, 65);
            this.guna2GradientButton3.TabIndex = 48;
            this.guna2GradientButton3.Text = "Back";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(37, 61);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(150, 62);
            this.guna2GradientButton4.TabIndex = 49;
            this.guna2GradientButton4.Text = "Back To All Categories";
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.Location = new System.Drawing.Point(961, 437);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(127, 52);
            this.guna2GradientButton5.TabIndex = 50;
            this.guna2GradientButton5.Text = "Delete From Order";
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 699);
            this.Controls.Add(this.guna2GradientButton5);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Totallbl);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.QuantityCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndOrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Foodlist);
            this.Controls.Add(this.PriceList);
            this.Controls.Add(this.DishList);
            this.Controls.Add(this.SoupsBtn);
            this.Controls.Add(this.DrinksBtn);
            this.Controls.Add(this.DessertBtn);
            this.Controls.Add(this.EntreesBtn);
            this.Controls.Add(this.FoodBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeOrderForm";
            this.Text = "MakeOrderForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.Label Quantitylbl;
        private Guna.UI2.WinForms.Guna2NumericUpDown QuantityCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton EndOrderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Foodlist;
        public System.Windows.Forms.ListBox PriceList;
        public System.Windows.Forms.ListBox DishList;
        private System.Windows.Forms.Button SoupsBtn;
        private System.Windows.Forms.Button DrinksBtn;
        private System.Windows.Forms.Button DessertBtn;
        private System.Windows.Forms.Button EntreesBtn;
        private System.Windows.Forms.Button FoodBtn;
    }
}