namespace winform1
{
    partial class Form1
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
            button1 = new Button();
            box1 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(336, 217);
            button1.Name = "button1";
            button1.Size = new Size(102, 47);
            button1.TabIndex = 0;
            button1.Text = "Click me!";
            button1.UseVisualStyleBackColor = false;
            // 
            // box1
            // 
            box1.Location = new Point(301, 113);
            box1.Name = "box1";
            box1.Size = new Size(196, 23);
            box1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 302);
            Controls.Add(textBox1);
            Controls.Add(box1);
            Controls.Add(button1);
            ForeColor = SystemColors.AppWorkspace;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox box1;
        private TextBox textBox1;
    }
}
