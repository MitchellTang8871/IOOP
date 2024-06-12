namespace IOOP_Group_Assignment
{
    partial class receptionistMenu
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
            this.btnCustRegister = new System.Windows.Forms.Button();
            this.btnPayProcess = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 19);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "UserID/Identity";
            // 
            // btnProfUp
            // 
            this.btnProfUp.Location = new System.Drawing.Point(360, 105);
            this.btnProfUp.Name = "btnProfUp";
            this.btnProfUp.Size = new System.Drawing.Size(180, 50);
            this.btnProfUp.TabIndex = 2;
            this.btnProfUp.Text = "Profile Update";
            this.btnProfUp.UseVisualStyleBackColor = true;
            this.btnProfUp.Click += new System.EventHandler(this.btnProfUp_Click);
            // 
            // btnCustRegister
            // 
            this.btnCustRegister.Location = new System.Drawing.Point(360, 187);
            this.btnCustRegister.Name = "btnCustRegister";
            this.btnCustRegister.Size = new System.Drawing.Size(180, 50);
            this.btnCustRegister.TabIndex = 3;
            this.btnCustRegister.Text = "Customer Registration";
            this.btnCustRegister.UseVisualStyleBackColor = true;
            this.btnCustRegister.Click += new System.EventHandler(this.btnCustRegister_Click);
            // 
            // btnPayProcess
            // 
            this.btnPayProcess.Location = new System.Drawing.Point(360, 352);
            this.btnPayProcess.Name = "btnPayProcess";
            this.btnPayProcess.Size = new System.Drawing.Size(180, 50);
            this.btnPayProcess.TabIndex = 4;
            this.btnPayProcess.Text = "Payment Processing";
            this.btnPayProcess.UseVisualStyleBackColor = true;
            this.btnPayProcess.Click += new System.EventHandler(this.btnPayProcess_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(388, 437);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(360, 269);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(180, 50);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Service Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // receptionistMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPayProcess);
            this.Controls.Add(this.btnCustRegister);
            this.Controls.Add(this.btnProfUp);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "receptionistMenu";
            this.Text = "Receptionist Menu";
            this.Load += new System.EventHandler(this.receptionistMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnProfUp;
        private System.Windows.Forms.Button btnCustRegister;
        private System.Windows.Forms.Button btnPayProcess;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRequest;
    }
}