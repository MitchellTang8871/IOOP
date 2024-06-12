namespace IOOP_Group_Assignment
{
    partial class technicianMenu
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
            this.btnViewService = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "UserID/Identity";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProfUp
            // 
            this.btnProfUp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfUp.Location = new System.Drawing.Point(367, 87);
            this.btnProfUp.Name = "btnProfUp";
            this.btnProfUp.Size = new System.Drawing.Size(180, 50);
            this.btnProfUp.TabIndex = 1;
            this.btnProfUp.Text = "Profile Update";
            this.btnProfUp.UseVisualStyleBackColor = true;
            this.btnProfUp.Click += new System.EventHandler(this.btnProfUp_Click);
            // 
            // btnViewService
            // 
            this.btnViewService.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewService.Location = new System.Drawing.Point(367, 184);
            this.btnViewService.Name = "btnViewService";
            this.btnViewService.Size = new System.Drawing.Size(180, 50);
            this.btnViewService.TabIndex = 2;
            this.btnViewService.Text = "View Service\r\n";
            this.btnViewService.UseVisualStyleBackColor = true;
            this.btnViewService.Click += new System.EventHandler(this.btnViewService_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(398, 276);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 50);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out\r\n";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // technicianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewService);
            this.Controls.Add(this.btnProfUp);
            this.Controls.Add(this.lblID);
            this.Name = "technicianMenu";
            this.Text = "Technician Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnProfUp;
        private System.Windows.Forms.Button btnViewService;
        private System.Windows.Forms.Button btnLogOut;
    }
}

