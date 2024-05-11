




namespace winform1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            b1_login = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            link_login = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(299, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 29);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(299, 156);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(163, 29);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(299, 72);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(299, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // b1_login
            // 
            b1_login.BackColor = Color.DeepSkyBlue;
            b1_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1_login.ForeColor = SystemColors.ActiveCaptionText;
            b1_login.Location = new Point(299, 208);
            b1_login.Name = "b1_login";
            b1_login.Size = new Size(163, 33);
            b1_login.TabIndex = 5;
            b1_login.Text = "Login";
            b1_login.UseVisualStyleBackColor = false;
            b1_login.Click += b1_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(335, 12);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 40);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(link_login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(b1_login);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(23, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 319);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(282, 255);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 8;
            label4.Text = "Don’t have an account yet?";
            // 
            // link_login
            // 
            link_login.ActiveLinkColor = Color.Cyan;
            link_login.AutoSize = true;
            link_login.Location = new Point(428, 255);
            link_login.Name = "link_login";
            link_login.Size = new Size(47, 15);
            link_login.TabIndex = 7;
            link_login.TabStop = true;
            link_login.Text = "Sign up";
            link_login.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 361);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            TransparencyKey = Color.White;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

       
  

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button b1_login;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private LinkLabel link_login;
        private PaintEventHandler panel1_Paint;
        private EventHandler label4_Click;
    }
}
