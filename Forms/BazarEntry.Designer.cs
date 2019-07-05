namespace MyMess
{
    partial class BazarEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BazarEntry));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblBazarDate = new System.Windows.Forms.Label();
            this.dtpBazarDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblBazarBy = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comBoxMembers = new System.Windows.Forms.ComboBox();
            this.dgvAddBazar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comBoxUnit = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBazar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(263, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Bazar";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(38, 101);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(91, 18);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name :";
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(129, 101);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 25);
            this.txtItemName.TabIndex = 1;
            // 
            // lblBazarDate
            // 
            this.lblBazarDate.AutoSize = true;
            this.lblBazarDate.Location = new System.Drawing.Point(263, 48);
            this.lblBazarDate.Name = "lblBazarDate";
            this.lblBazarDate.Size = new System.Drawing.Size(58, 18);
            this.lblBazarDate.TabIndex = 3;
            this.lblBazarDate.Text = "Date  : ";
            // 
            // dtpBazarDate
            // 
            this.dtpBazarDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBazarDate.Location = new System.Drawing.Point(354, 47);
            this.dtpBazarDate.MaxDate = new System.DateTime(5555, 12, 31, 0, 0, 0, 0);
            this.dtpBazarDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpBazarDate.Name = "dtpBazarDate";
            this.dtpBazarDate.Size = new System.Drawing.Size(128, 26);
            this.dtpBazarDate.TabIndex = 0;
            this.dtpBazarDate.Value = new System.DateTime(2019, 3, 9, 0, 0, 0, 0);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 137);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(76, 25);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(38, 139);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 18);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity :";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(386, 138);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(97, 25);
            this.txtCost.TabIndex = 6;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(331, 142);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(49, 18);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost :";
            // 
            // lblBazarBy
            // 
            this.lblBazarBy.AutoSize = true;
            this.lblBazarBy.Location = new System.Drawing.Point(38, 188);
            this.lblBazarBy.Name = "lblBazarBy";
            this.lblBazarBy.Size = new System.Drawing.Size(79, 18);
            this.lblBazarBy.TabIndex = 9;
            this.lblBazarBy.Text = "Bazar By :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(10, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Location = new System.Drawing.Point(116, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comBoxMembers
            // 
            this.comBoxMembers.FormattingEnabled = true;
            this.comBoxMembers.Location = new System.Drawing.Point(129, 184);
            this.comBoxMembers.Name = "comBoxMembers";
            this.comBoxMembers.Size = new System.Drawing.Size(188, 26);
            this.comBoxMembers.TabIndex = 7;
            this.comBoxMembers.Text = "select";
            // 
            // dgvAddBazar
            // 
            this.dgvAddBazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBazar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAddBazar.Location = new System.Drawing.Point(1, 276);
            this.dgvAddBazar.Name = "dgvAddBazar";
            this.dgvAddBazar.Size = new System.Drawing.Size(695, 236);
            this.dgvAddBazar.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cost";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bazay By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comBoxUnit
            // 
            this.comBoxUnit.FormattingEnabled = true;
            this.comBoxUnit.Items.AddRange(new object[] {
            "kg",
            "pcs",
            "ltr",
            "gm",
            "pkt"});
            this.comBoxUnit.Location = new System.Drawing.Point(206, 137);
            this.comBoxUnit.Name = "comBoxUnit";
            this.comBoxUnit.Size = new System.Drawing.Size(78, 26);
            this.comBoxUnit.TabIndex = 5;
            this.comBoxUnit.Text = "select";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(38, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 18);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "SL-No :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Location = new System.Drawing.Point(129, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(76, 26);
            this.txtID.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(41, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 34);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BazarEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 559);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.comBoxUnit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAddBazar);
            this.Controls.Add(this.comBoxMembers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBazarBy);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.dtpBazarDate);
            this.Controls.Add(this.lblBazarDate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BazarEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BazarEntry";
            this.Load += new System.EventHandler(this.BazarEntry_Load);
            this.Load += new System.EventHandler(this.myLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBazar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblItemName;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.Label lblBazarDate;
        public System.Windows.Forms.DateTimePicker dtpBazarDate;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.Label lblBazarBy;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox comBoxMembers;
        public System.Windows.Forms.DataGridView dgvAddBazar;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox comBoxUnit;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
    }
}