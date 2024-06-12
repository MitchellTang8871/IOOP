namespace IOOP_Group_Assignment
{
    partial class customerHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.receiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Customer Trading History";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(813, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 30);
            this.btnMenu.TabIndex = 38;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 19);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "UserID/Identity";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(409, 113);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(37, 19);
            this.lblCustID.TabIndex = 41;
            this.lblCustID.Text = "N/A";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(813, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptID,
            this.ID,
            this.service,
            this.urgency,
            this.description,
            this.od,
            this.cd,
            this.pa,
            this.ps});
            this.dgv1.Location = new System.Drawing.Point(16, 200);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(872, 218);
            this.dgv1.TabIndex = 43;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // receiptID
            // 
            this.receiptID.DataPropertyName = "receiptID";
            this.receiptID.HeaderText = "Receipt ID";
            this.receiptID.MinimumWidth = 6;
            this.receiptID.Name = "receiptID";
            this.receiptID.ReadOnly = true;
            this.receiptID.Width = 112;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "custID";
            this.ID.HeaderText = "Customer ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // service
            // 
            this.service.DataPropertyName = "service";
            this.service.HeaderText = "Service";
            this.service.MinimumWidth = 6;
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 125;
            // 
            // urgency
            // 
            this.urgency.DataPropertyName = "urgency";
            this.urgency.HeaderText = "Urgency";
            this.urgency.MinimumWidth = 6;
            this.urgency.Name = "urgency";
            this.urgency.ReadOnly = true;
            this.urgency.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // od
            // 
            this.od.DataPropertyName = "orderDate";
            this.od.HeaderText = "Order Date";
            this.od.MinimumWidth = 6;
            this.od.Name = "od";
            this.od.ReadOnly = true;
            this.od.Width = 125;
            // 
            // cd
            // 
            this.cd.DataPropertyName = "collectionDate";
            this.cd.HeaderText = "Collection Date";
            this.cd.MinimumWidth = 6;
            this.cd.Name = "cd";
            this.cd.ReadOnly = true;
            this.cd.Width = 125;
            // 
            // pa
            // 
            this.pa.DataPropertyName = "payAmount";
            this.pa.HeaderText = "Payment Amount";
            this.pa.MinimumWidth = 6;
            this.pa.Name = "pa";
            this.pa.ReadOnly = true;
            this.pa.Width = 125;
            // 
            // ps
            // 
            this.ps.DataPropertyName = "payStatus";
            this.ps.HeaderText = "Payment Status";
            this.ps.MinimumWidth = 6;
            this.ps.Name = "ps";
            this.ps.ReadOnly = true;
            this.ps.Width = 125;
            // 
            // customerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customerHistory";
            this.Text = "Customer Trading History";
            this.Load += new System.EventHandler(this.customerHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn od;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
    }
}