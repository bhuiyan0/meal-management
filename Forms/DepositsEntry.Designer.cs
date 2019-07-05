namespace MyMess
{
    partial class DepositsEntry
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comBoxMembers = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.dtpDepositeDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(217, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comBoxMembers
            // 
            this.comBoxMembers.FormattingEnabled = true;
            this.comBoxMembers.Location = new System.Drawing.Point(207, 162);
            this.comBoxMembers.Name = "comBoxMembers";
            this.comBoxMembers.Size = new System.Drawing.Size(177, 26);
            this.comBoxMembers.TabIndex = 1;
            this.comBoxMembers.Text = "Select";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(103, 165);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(74, 18);
            this.lblMember.TabIndex = 27;
            this.lblMember.Text = "Member :";
            // 
            // dtpDepositeDate
            // 
            this.dtpDepositeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepositeDate.Location = new System.Drawing.Point(207, 117);
            this.dtpDepositeDate.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dtpDepositeDate.Name = "dtpDepositeDate";
            this.dtpDepositeDate.Size = new System.Drawing.Size(110, 26);
            this.dtpDepositeDate.TabIndex = 0;
            this.dtpDepositeDate.Value = new System.DateTime(2019, 3, 9, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(105, 123);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 18);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
            this.lblTitle.Location = new System.Drawing.Point(203, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 22);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Deposite Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(105, 213);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 18);
            this.lblAmount.TabIndex = 36;
            this.lblAmount.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(207, 210);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(110, 26);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "SL No :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(207, 83);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(71, 26);
            this.txtID.TabIndex = 39;
            this.txtID.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DepositsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comBoxMembers);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dtpDepositeDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DepositsEntry";
            this.Text = "DepositsEntry";
            this.Load += new System.EventHandler(this.DepositsEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox comBoxMembers;
        public System.Windows.Forms.Label lblMember;
        public System.Windows.Forms.DateTimePicker dtpDepositeDate;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnUpdate;
    }
}