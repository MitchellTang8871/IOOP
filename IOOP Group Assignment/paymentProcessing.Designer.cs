namespace IOOP_Group_Assignment
{
    partial class paymentProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentProcessing));
            this.lblID = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblRcptID = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.lblOdrDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.lblCollectDate = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 19);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "UserID/Identity";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(813, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 30);
            this.btnMenu.TabIndex = 39;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(341, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 25);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Payment Processing";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 19);
            this.label16.TabIndex = 47;
            this.label16.Text = "Description:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 46;
            this.label15.Text = "Service:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "Tel.No:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "Customer ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Customer Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Receipt ID:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(472, 267);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(37, 19);
            this.lblTel.TabIndex = 52;
            this.lblTel.Text = "N/A";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(472, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 19);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "N/A";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(472, 187);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(37, 19);
            this.lblCustID.TabIndex = 50;
            this.lblCustID.Text = "N/A";
            this.lblCustID.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(472, 146);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(37, 19);
            this.lblCustName.TabIndex = 49;
            this.lblCustName.Text = "N/A";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblRcptID
            // 
            this.lblRcptID.AutoSize = true;
            this.lblRcptID.Location = new System.Drawing.Point(472, 105);
            this.lblRcptID.Name = "lblRcptID";
            this.lblRcptID.Size = new System.Drawing.Size(37, 19);
            this.lblRcptID.TabIndex = 48;
            this.lblRcptID.Text = "N/A";
            this.lblRcptID.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDescript
            // 
            this.lblDescript.Location = new System.Drawing.Point(472, 350);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(239, 110);
            this.lblDescript.TabIndex = 54;
            this.lblDescript.Text = "N/A";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(514, 582);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(275, 582);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 30);
            this.btnAccept.TabIndex = 55;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(290, 526);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(37, 19);
            this.lblPayAmount.TabIndex = 60;
            this.lblPayAmount.Text = "N/A";
            this.lblPayAmount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblOdrDate
            // 
            this.lblOdrDate.AutoSize = true;
            this.lblOdrDate.Location = new System.Drawing.Point(290, 485);
            this.lblOdrDate.Name = "lblOdrDate";
            this.lblOdrDate.Size = new System.Drawing.Size(37, 19);
            this.lblOdrDate.TabIndex = 59;
            this.lblOdrDate.Text = "N/A";
            this.lblOdrDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Payment Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Order Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "Payment Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Collection Date:";
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.AutoSize = true;
            this.lblPayStatus.Location = new System.Drawing.Point(706, 527);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(37, 19);
            this.lblPayStatus.TabIndex = 64;
            this.lblPayStatus.Text = "N/A";
            this.lblPayStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCollectDate
            // 
            this.lblCollectDate.AutoSize = true;
            this.lblCollectDate.Location = new System.Drawing.Point(706, 485);
            this.lblCollectDate.Name = "lblCollectDate";
            this.lblCollectDate.Size = new System.Drawing.Size(37, 19);
            this.lblCollectDate.TabIndex = 63;
            this.lblCollectDate.Text = "N/A";
            this.lblCollectDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(472, 309);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(37, 19);
            this.lblService.TabIndex = 67;
            this.lblService.Text = "N/A";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(813, 614);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // paymentProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 656);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPayStatus);
            this.Controls.Add(this.lblCollectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPayAmount);
            this.Controls.Add(this.lblOdrDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblRcptID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "paymentProcessing";
            this.Text = "Payment Processing";
            this.Load += new System.EventHandler(this.paymentProcessing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblRcptID;
        private System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.Label lblOdrDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPayStatus;
        private System.Windows.Forms.Label lblCollectDate;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}