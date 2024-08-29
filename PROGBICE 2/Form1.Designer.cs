namespace PROGBICE_2
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
            this.btnCreateRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreateRequest.Location = new System.Drawing.Point(71, 75);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(110, 50);
            this.btnCreateRequest.TabIndex = 0;
            this.btnCreateRequest.Text = "Create Request";
            this.btnCreateRequest.UseVisualStyleBackColor = false;
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnApproveRequest
            // 
            this.btnApproveRequest.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnApproveRequest.Location = new System.Drawing.Point(71, 131);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(110, 50);
            this.btnApproveRequest.TabIndex = 2;
            this.btnApproveRequest.Text = "Approve Request";
            this.btnApproveRequest.UseVisualStyleBackColor = false;
            this.btnApproveRequest.Click += new System.EventHandler(this.btnApproveRequest_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGenerateReports.Location = new System.Drawing.Point(71, 187);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(110, 50);
            this.btnGenerateReports.TabIndex = 3;
            this.btnGenerateReports.Text = "GenerateReports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 296);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Button btnGenerateReports;
    }
}

