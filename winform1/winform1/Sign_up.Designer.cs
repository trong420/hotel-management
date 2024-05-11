namespace winform1
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            panel1 = new Panel();
            label4 = new Label();
            link_signup = new LinkLabel();
            label3 = new Label();
            b1_signup = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(link_signup);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(b1_signup);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(23, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 305);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(292, 255);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 8;
            label4.Text = "Already have an account?";
            // 
            // link_signup
            // 
            link_signup.ActiveLinkColor = Color.Cyan;
            link_signup.AutoSize = true;
            link_signup.Location = new Point(433, 255);
            link_signup.Name = "link_signup";
            link_signup.Size = new Size(40, 15);
            link_signup.TabIndex = 7;
            link_signup.TabStop = true;
            link_signup.Text = "Log in";
            link_signup.LinkClicked += link_signup_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(264, 19);
            label3.MaximumSize = new Size(300, 200);
            label3.Name = "label3";
            label3.Size = new Size(252, 40);
            label3.TabIndex = 6;
            label3.Text = "Sign up with Email";
            // 
            // b1_signup
            // 
            b1_signup.BackColor = Color.DeepSkyBlue;
            b1_signup.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1_signup.ForeColor = SystemColors.ActiveCaptionText;
            b1_signup.Location = new Point(299, 208);
            b1_signup.Name = "b1_signup";
            b1_signup.Size = new Size(163, 33);
            b1_signup.TabIndex = 5;
            b1_signup.Text = "Sign up";
            b1_signup.UseVisualStyleBackColor = false;
            b1_signup.Click += b1_signup_Click;
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
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveBorder;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(299, 156);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(163, 29);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveBorder;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(299, 96);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 29);
            textBox3.TabIndex = 0;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 361);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sign_up";
            Text = "Sign up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private LinkLabel link_signup;
        private Label label3;
        private Button b1_signup;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}