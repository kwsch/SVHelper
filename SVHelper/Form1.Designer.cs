namespace SVHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_TID = new System.Windows.Forms.MaskedTextBox();
            this.L_TID = new System.Windows.Forms.Label();
            this.L_SID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_TSV = new System.Windows.Forms.Label();
            this.TB_SID = new System.Windows.Forms.MaskedTextBox();
            this.TB_TSV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PID = new System.Windows.Forms.TextBox();
            this.TB_ESV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_TID
            // 
            this.TB_TID.Location = new System.Drawing.Point(43, 14);
            this.TB_TID.Mask = "00000";
            this.TB_TID.Name = "TB_TID";
            this.TB_TID.Size = new System.Drawing.Size(41, 20);
            this.TB_TID.TabIndex = 0;
            this.TB_TID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_TID.ValidatingType = typeof(int);
            this.TB_TID.TextChanged += new System.EventHandler(this.updateTSV);
            // 
            // L_TID
            // 
            this.L_TID.AutoSize = true;
            this.L_TID.Location = new System.Drawing.Point(9, 17);
            this.L_TID.Name = "L_TID";
            this.L_TID.Size = new System.Drawing.Size(28, 13);
            this.L_TID.TabIndex = 2;
            this.L_TID.Text = "TID:";
            // 
            // L_SID
            // 
            this.L_SID.AutoSize = true;
            this.L_SID.Location = new System.Drawing.Point(9, 39);
            this.L_SID.Name = "L_SID";
            this.L_SID.Size = new System.Drawing.Size(28, 13);
            this.L_SID.TabIndex = 3;
            this.L_SID.Text = "SID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_TSV);
            this.groupBox1.Controls.Add(this.TB_SID);
            this.groupBox1.Controls.Add(this.L_TSV);
            this.groupBox1.Controls.Add(this.L_SID);
            this.groupBox1.Controls.Add(this.TB_TID);
            this.groupBox1.Controls.Add(this.L_TID);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainer";
            // 
            // L_TSV
            // 
            this.L_TSV.AutoSize = true;
            this.L_TSV.Location = new System.Drawing.Point(6, 67);
            this.L_TSV.Name = "L_TSV";
            this.L_TSV.Size = new System.Drawing.Size(31, 13);
            this.L_TSV.TabIndex = 5;
            this.L_TSV.Text = "TSV:";
            // 
            // TB_SID
            // 
            this.TB_SID.Location = new System.Drawing.Point(43, 36);
            this.TB_SID.Mask = "00000";
            this.TB_SID.Name = "TB_SID";
            this.TB_SID.Size = new System.Drawing.Size(41, 20);
            this.TB_SID.TabIndex = 6;
            this.TB_SID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_SID.ValidatingType = typeof(int);
            this.TB_SID.TextChanged += new System.EventHandler(this.updateTSV);
            // 
            // TB_TSV
            // 
            this.TB_TSV.Location = new System.Drawing.Point(43, 64);
            this.TB_TSV.Name = "TB_TSV";
            this.TB_TSV.ReadOnly = true;
            this.TB_TSV.Size = new System.Drawing.Size(41, 20);
            this.TB_TSV.TabIndex = 7;
            this.TB_TSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TB_ESV);
            this.groupBox2.Controls.Add(this.TB_PID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(108, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESV:";
            // 
            // TB_PID
            // 
            this.TB_PID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PID.Location = new System.Drawing.Point(38, 14);
            this.TB_PID.MaxLength = 8;
            this.TB_PID.Name = "TB_PID";
            this.TB_PID.Size = new System.Drawing.Size(73, 22);
            this.TB_PID.TabIndex = 2;
            this.TB_PID.TextChanged += new System.EventHandler(this.updateESV);
            // 
            // TB_ESV
            // 
            this.TB_ESV.Location = new System.Drawing.Point(38, 64);
            this.TB_ESV.Name = "TB_ESV";
            this.TB_ESV.ReadOnly = true;
            this.TB_ESV.Size = new System.Drawing.Size(73, 20);
            this.TB_ESV.TabIndex = 3;
            this.TB_ESV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Hex)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 107);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SV Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TB_TID;
        private System.Windows.Forms.Label L_TID;
        private System.Windows.Forms.Label L_SID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_TSV;
        private System.Windows.Forms.MaskedTextBox TB_SID;
        private System.Windows.Forms.Label L_TSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_ESV;
        private System.Windows.Forms.TextBox TB_PID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

