namespace ASWT_MarsTime
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
            this.btn_check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_interval_1_1 = new System.Windows.Forms.TextBox();
            this.tb_interval_1_2 = new System.Windows.Forms.TextBox();
            this.tb_interval_2_1 = new System.Windows.Forms.TextBox();
            this.tb_interval_2_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.Location = new System.Drawing.Point(255, 31);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(176, 97);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_interval_1_2);
            this.groupBox1.Controls.Add(this.tb_interval_1_1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interval 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tb_interval_2_2);
            this.groupBox2.Controls.Add(this.tb_interval_2_1);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interval 2";
            // 
            // tb_interval_1_1
            // 
            this.tb_interval_1_1.Location = new System.Drawing.Point(23, 19);
            this.tb_interval_1_1.Name = "tb_interval_1_1";
            this.tb_interval_1_1.Size = new System.Drawing.Size(78, 20);
            this.tb_interval_1_1.TabIndex = 0;
            // 
            // tb_interval_1_2
            // 
            this.tb_interval_1_2.Location = new System.Drawing.Point(128, 19);
            this.tb_interval_1_2.Name = "tb_interval_1_2";
            this.tb_interval_1_2.Size = new System.Drawing.Size(78, 20);
            this.tb_interval_1_2.TabIndex = 1;
            // 
            // tb_interval_2_1
            // 
            this.tb_interval_2_1.Location = new System.Drawing.Point(24, 19);
            this.tb_interval_2_1.Name = "tb_interval_2_1";
            this.tb_interval_2_1.Size = new System.Drawing.Size(78, 20);
            this.tb_interval_2_1.TabIndex = 1;
            // 
            // tb_interval_2_2
            // 
            this.tb_interval_2_2.Location = new System.Drawing.Point(129, 19);
            this.tb_interval_2_2.Name = "tb_interval_2_2";
            this.tb_interval_2_2.Size = new System.Drawing.Size(78, 20);
            this.tb_interval_2_2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format: 00:000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MarsTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_interval_1_2;
        private System.Windows.Forms.TextBox tb_interval_1_1;
        private System.Windows.Forms.TextBox tb_interval_2_2;
        private System.Windows.Forms.TextBox tb_interval_2_1;
        private System.Windows.Forms.Label label1;
    }
}

