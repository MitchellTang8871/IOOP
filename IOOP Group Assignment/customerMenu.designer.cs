namespace IOOP_Group_Assignment
{
    partial class customerMenu
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
            this.btnServiceInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(11, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(120, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "UserID/ Identity";
            // 
            // btnProfUp
            // 
            this.btnProfUp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfUp.Location = new System.Drawing.Point(368, 114);
            this.btnProfUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfUp.Name = "btnProfUp";
            this.btnProfUp.Size = new System.Drawing.Size(160, 40);
            this.btnProfUp.TabIndex = 1;
            this.btnProfUp.Text = "Profile Update";
            this.btnProfUp.UseVisualStyleBackColor = true;
            this.btnProfUp.Click += new System.EventHandler(this.btnProfUp_Click);
            // 
            // btnServiceInfo
            // 
            this.btnServiceInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceInfo.Location = new System.Drawing.Point(368, 167);
            this.btnServiceInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServiceInfo.Name = "btnServiceInfo";
            this.btnServiceInfo.Size = new System.Drawing.Size(160, 40);
            this.btnServiceInfo.TabIndex = 2;
            this.btnServiceInfo.Text = "View Service Info";
            this.btnServiceInfo.UseVisualStyleBackColor = true;
            this.btnServiceInfo.Click += new System.EventHandler(this.btnServiceInfo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(390, 226);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // customerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 360);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnServiceInfo);
            this.Controls.Add(this.btnProfUp);
            this.Controls.Add(this.lblID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "customerMenu";
            this.Text = "Customer Menu";
            this.Load += new System.EventHandler(this.customerMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnProfUp;
        private System.Windows.Forms.Button btnServiceInfo;
        private System.Windows.Forms.Button btnLogOut;
    }
}

