namespace WinForms.StringMethod
{
    partial class Form3
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
            lblresult = new Label();
            txtText = new TextBox();
            txtSize = new TextBox();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnFor = new Button();
            btnForeach = new Button();
            comboBox2 = new ComboBox();
            btnReang = new Button();
            SuspendLayout();
            // 
            // lblresult
            // 
            lblresult.BackColor = SystemColors.Window;
            lblresult.Location = new Point(10, 90);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(334, 297);
            lblresult.TabIndex = 0;
            // 
            // txtText
            // 
            txtText.Location = new Point(10, 9);
            txtText.Margin = new Padding(3, 2, 3, 2);
            txtText.Name = "txtText";
            txtText.Size = new Size(110, 23);
            txtText.TabIndex = 1;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(10, 34);
            txtSize.Margin = new Padding(3, 2, 3, 2);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(110, 23);
            txtSize.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(184, 9);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(161, 70);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "สร้างรูป";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 11);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "ตัวอักษร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 34);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "ขนาด";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 58);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 61);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "รูปแบบ";
            // 
            // btnFor
            // 
            btnFor.Location = new Point(10, 393);
            btnFor.Margin = new Padding(3, 2, 3, 2);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(152, 22);
            btnFor.TabIndex = 8;
            btnFor.Text = "หาค่าเฉลี่ย Array แบบ For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += button1_Click;
            // 
            // btnForeach
            // 
            btnForeach.Location = new Point(168, 393);
            btnForeach.Margin = new Padding(3, 2, 3, 2);
            btnForeach.Name = "btnForeach";
            btnForeach.Size = new Size(177, 22);
            btnForeach.TabIndex = 9;
            btnForeach.Text = "หาค่าเฉลี่ย Array แบบ Foreach";
            btnForeach.UseVisualStyleBackColor = true;
            btnForeach.Click += btnForeach_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(10, 420);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(60, 23);
            comboBox2.TabIndex = 10;
            // 
            // btnReang
            // 
            btnReang.Location = new Point(83, 420);
            btnReang.Name = "btnReang";
            btnReang.Size = new Size(260, 23);
            btnReang.TabIndex = 11;
            btnReang.Text = "เรียงค่าใน Array";
            btnReang.UseVisualStyleBackColor = true;
            btnReang.Click += btnReang_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(355, 450);
            Controls.Add(btnReang);
            Controls.Add(comboBox2);
            Controls.Add(btnForeach);
            Controls.Add(btnFor);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(txtSize);
            Controls.Add(txtText);
            Controls.Add(lblresult);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblresult;
        private TextBox txtText;
        private TextBox txtSize;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnFor;
        private Button btnForeach;
        private ComboBox comboBox2;
        private Button btnReang;
    }
}