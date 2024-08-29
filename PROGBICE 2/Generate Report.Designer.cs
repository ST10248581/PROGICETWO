namespace PROGBICE_2
{
    partial class Generate_Report
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
            this.label2 = new System.Windows.Forms.Label();
            this.ReportTB = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PendingTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generate Reports";
            // 
            // ReportTB
            // 
            this.ReportTB.Location = new System.Drawing.Point(12, 93);
            this.ReportTB.Multiline = true;
            this.ReportTB.Name = "ReportTB";
            this.ReportTB.Size = new System.Drawing.Size(278, 293);
            this.ReportTB.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Location = new System.Drawing.Point(206, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGenerateReports.Location = new System.Drawing.Point(322, 423);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(110, 50);
            this.btnGenerateReports.TabIndex = 10;
            this.btnGenerateReports.Text = "GenerateReports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Processed Reports";
            // 
            // PendingTB
            // 
            this.PendingTB.Location = new System.Drawing.Point(322, 93);
            this.PendingTB.Multiline = true;
            this.PendingTB.Name = "PendingTB";
            this.PendingTB.Size = new System.Drawing.Size(278, 293);
            this.PendingTB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pending Reports";
            // 
            // Generate_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PendingTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ReportTB);
            this.Controls.Add(this.label2);
            this.Name = "Generate_Report";
            this.Text = "Generate_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReportTB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PendingTB;
        private System.Windows.Forms.Label label3;
    }
}