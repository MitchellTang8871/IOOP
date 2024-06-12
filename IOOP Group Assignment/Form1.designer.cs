namespace IOOP_Group_Assignment
{
    partial class adminMainMenu
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnProfUp = new System.Windows.Forms.Button();
            this.btnEmpRegister = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(158, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "USER ID / IDENTITY";
            // 
            // btnProfUp
            // 
            this.btnProfUp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfUp.Location = new System.Drawing.Point(360, 102);
            this.btnProfUp.Name = "btnProfUp";
            this.btnProfUp.Size = new System.Drawing.Size(180, 50);
            this.btnProfUp.TabIndex = 1;
            this.btnProfUp.Text = "Profile Update";
            this.btnProfUp.UseVisualStyleBackColor = true;
            this.btnProfUp.Click += new System.EventHandler(this.btnProfUp_Click);
            // 
            // btnEmpRegister
            // 
            this.btnEmpRegister.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpRegister.Location = new System.Drawing.Point(360, 167);
            this.btnEmpRegister.Name = "btnEmpRegister";
            this.btnEmpRegister.Size = new System.Drawing.Size(180, 50);
            this.btnEmpRegister.TabIndex = 2;
            this.btnEmpRegister.Text = "Employee Registration";
            this.btnEmpRegister.UseVisualStyleBackColor = true;
            this.btnEmpRegister.Click += new System.EventHandler(this.btnEmpRegister_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(360, 233);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 50);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Service Report / Financial Statement";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(390, 299);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 50);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // adminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnEmpRegister);
            this.Controls.Add(this.btnProfUp);
            this.Controls.Add(this.lblID);
            this.Name = "adminMainMenu";
            this.Text = "Admin Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnProfUp;
        private System.Windows.Forms.Button btnEmpRegister;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogOut;
    }
}

