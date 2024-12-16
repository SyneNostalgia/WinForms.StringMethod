namespace WinForms.StringMethod
{
    partial class Form2
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
            btnBMI = new Button();
            btnTriangle = new Button();
            txtheight = new TextBox();
            txtweight = new TextBox();
            txtbase = new TextBox();
            txthigh = new TextBox();
            lblresult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.White;
            btnBMI.Location = new Point(58, 52);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(125, 29);
            btnBMI.TabIndex = 0;
            btnBMI.Text = "หาความเร็วสุดท้าย";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.BackColor = Color.White;
            btnTriangle.Location = new Point(291, 52);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(148, 29);
            btnTriangle.TabIndex = 1;
            btnTriangle.Text = "หาด้านตรงข้ามมุมฉาก";
            btnTriangle.UseVisualStyleBackColor = false;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // txtheight
            // 
            txtheight.Location = new Point(58, 116);
            txtheight.Name = "txtheight";
            txtheight.Size = new Size(125, 27);
            txtheight.TabIndex = 2;
            // 
            // txtweight
            // 
            txtweight.Location = new Point(58, 169);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(125, 27);
            txtweight.TabIndex = 3;
            // 
            // txtbase
            // 
            txtbase.Location = new Point(291, 116);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(125, 27);
            txtbase.TabIndex = 4;
            // 
            // txthigh
            // 
            txthigh.Location = new Point(291, 169);
            txthigh.Name = "txthigh";
            txthigh.Size = new Size(125, 27);
            txthigh.TabIndex = 5;
            // 
            // lblresult
            // 
            lblresult.BackColor = SystemColors.ControlLightLight;
            lblresult.Location = new Point(119, 247);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(236, 105);
            lblresult.TabIndex = 6;
            lblresult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 93);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 7;
            label1.Text = "ความเร็วเริ่มต้น m/s";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 146);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "เวลา s";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 93);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 9;
            label3.Text = "ความยาวฐาน cm";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 146);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 10;
            label4.Text = "ความสูง cm";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(484, 421);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblresult);
            Controls.Add(txthigh);
            Controls.Add(txtbase);
            Controls.Add(txtweight);
            Controls.Add(txtheight);
            Controls.Add(btnTriangle);
            Controls.Add(btnBMI);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBMI;
        private Button btnTriangle;
        private TextBox txtheight;
        private TextBox txtweight;
        private TextBox txtbase;
        private TextBox txthigh;
        private Label lblresult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}