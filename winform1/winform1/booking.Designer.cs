namespace winform1
{
    partial class booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            panel1 = new Panel();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            duration = new TextBox();
            cost = new TextBox();
            label8 = new Label();
            rtype = new ComboBox();
            phone = new TextBox();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            gender = new ComboBox();
            cusName = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 507);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(1, 240);
            panel7.Name = "panel7";
            panel7.Size = new Size(172, 56);
            panel7.TabIndex = 6;
            panel7.Paint += panel7_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Control;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(75, 15);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 3;
            label6.Text = "About ";
            label6.Click += label6_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(1, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(172, 56);
            panel6.TabIndex = 5;
            panel6.Paint += panel6_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Control;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(55, 15);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 3;
            label5.Text = "Dashboard";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(1, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 56);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Highlight;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(60, 15);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Bookings";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(1, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 56);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(71, 15);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 3;
            label3.Text = "Rooms";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 59);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(114, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Log out";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(200, 5);
            label1.Name = "label1";
            label1.Size = new Size(469, 48);
            label1.TabIndex = 1;
            label1.Text = "Hotel Management Systems";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(duration);
            panel2.Controls.Add(cost);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(rtype);
            panel2.Controls.Add(phone);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(gender);
            panel2.Controls.Add(cusName);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(172, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 441);
            panel2.TabIndex = 0;
            // 
            // duration
            // 
            duration.Location = new Point(529, 50);
            duration.Name = "duration";
            duration.PlaceholderText = "Duration";
            duration.Size = new Size(100, 23);
            duration.TabIndex = 17;
            duration.TextChanged += duration_TextChanged_1;
            // 
            // cost
            // 
            cost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cost.ForeColor = Color.Red;
            cost.Location = new Point(295, 90);
            cost.Name = "cost";
            cost.Size = new Size(152, 25);
            cost.TabIndex = 16;
            cost.TextChanged += cost_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(195, 88);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 15;
            label8.Text = "Total Cost:";
            // 
            // rtype
            // 
            rtype.FormattingEnabled = true;
            rtype.Items.AddRange(new object[] { "Normal", "Luxury", "VIP" });
            rtype.Location = new Point(420, 50);
            rtype.Name = "rtype";
            rtype.Size = new Size(89, 23);
            rtype.TabIndex = 14;
            rtype.Text = "Room Type";
            rtype.SelectedIndexChanged += rtype_SelectedIndexChanged;
            // 
            // phone
            // 
            phone.Location = new Point(285, 50);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone Number";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Location = new Point(395, 125);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(175, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkBlue;
            dataGridView1.Location = new Point(1, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 286);
            dataGridView1.TabIndex = 7;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(175, 50);
            gender.Name = "gender";
            gender.Size = new Size(86, 23);
            gender.TabIndex = 4;
            gender.Text = "Gender";
            // 
            // cusName
            // 
            cusName.Location = new Point(50, 50);
            cusName.Name = "cusName";
            cusName.PlaceholderText = "Customer Name";
            cusName.Size = new Size(100, 23);
            cusName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(244, 10);
            label7.Name = "label7";
            label7.Size = new Size(158, 28);
            label7.TabIndex = 2;
            label7.Text = "Booking Rooms";
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(840, 531);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "booking";
            Text = "booking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label4;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private ComboBox gender;
        private TextBox cusName;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private TextBox phone;
        private ComboBox rtype;
        private TextBox cost;
        private Label label8;
        private TextBox duration;
    }
}