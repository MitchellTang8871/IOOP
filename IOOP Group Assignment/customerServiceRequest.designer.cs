namespace IOOP_Group_Assignment
{
    partial class customerServiceRequest
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.ServiceList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Service Request\r\n\r\n";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "UserID/Identity";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(813, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 30);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ServiceList
            // 
            this.ServiceList.AllowUserToAddRows = false;
            this.ServiceList.AllowUserToDeleteRows = false;
            this.ServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceList.Location = new System.Drawing.Point(94, 98);
            this.ServiceList.Name = "ServiceList";
            this.ServiceList.ReadOnly = true;
            this.ServiceList.RowHeadersWidth = 51;
            this.ServiceList.RowTemplate.Height = 24;
            this.ServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceList.Size = new System.Drawing.Size(696, 270);
            this.ServiceList.TabIndex = 10;
            this.ServiceList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceList_CellClick);
            // 
            // customerServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.ServiceList);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Name = "customerServiceRequest";
            this.Text = "Customer Service Request";
            this.Load += new System.EventHandler(this.customerServiceRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView ServiceList;
    }
}