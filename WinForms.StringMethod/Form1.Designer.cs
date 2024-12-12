namespace WinForms.StringMethod
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
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            btnSplitName = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(128, 50);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(372, 23);
            txtFullname.TabIndex = 0;
            txtFullname.Text = "นายอชิตะ บุญมารักษ์";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(128, 100);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(210, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 124);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(128, 149);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 23);
            txtLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(529, 50);
            btnSplitName.Margin = new Padding(3, 2, 3, 2);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(82, 22);
            btnSplitName.TabIndex = 5;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 127);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "ชื่อ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 149);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "นามสกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 102);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "คำนำหน้า";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(668, 224);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSplitName);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Button btnSplitName;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
