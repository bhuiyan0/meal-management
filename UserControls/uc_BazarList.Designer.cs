namespace MyMess
{
    partial class uc_BazarList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBazarList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBoxSearch = new System.Windows.Forms.ComboBox();
            this.radByDate = new System.Windows.Forms.RadioButton();
            this.radByName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbledit = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazarList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 621);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 544);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBazarList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 544);
            this.panel4.TabIndex = 2;
            // 
            // dgvBazarList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBazarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBazarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBazarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBazarList.Location = new System.Drawing.Point(0, 0);
            this.dgvBazarList.Name = "dgvBazarList";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBazarList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBazarList.Size = new System.Drawing.Size(1084, 544);
            this.dgvBazarList.TabIndex = 0;
            this.dgvBazarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBazarList_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comBoxSearch);
            this.panel1.Controls.Add(this.radByDate);
            this.panel1.Controls.Add(this.radByName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dtpSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lbledit);
            this.panel1.Controls.Add(this.lblUserList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 77);
            this.panel1.TabIndex = 0;
            // 
            // comBoxSearch
            // 
            this.comBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comBoxSearch.FormattingEnabled = true;
            this.comBoxSearch.Location = new System.Drawing.Point(795, 40);
            this.comBoxSearch.Name = "comBoxSearch";
            this.comBoxSearch.Size = new System.Drawing.Size(158, 28);
            this.comBoxSearch.TabIndex = 8;
            // 
            // radByDate
            // 
            this.radByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radByDate.AutoSize = true;
            this.radByDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radByDate.Location = new System.Drawing.Point(915, 3);
            this.radByDate.Name = "radByDate";
            this.radByDate.Size = new System.Drawing.Size(117, 24);
            this.radByDate.TabIndex = 7;
            this.radByDate.Text = "Search by Date";
            this.radByDate.UseVisualStyleBackColor = true;
            this.radByDate.CheckedChanged += new System.EventHandler(this.radByName_CheckedChanged);
            // 
            // radByName
            // 
            this.radByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radByName.AutoSize = true;
            this.radByName.Checked = true;
            this.radByName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radByName.Location = new System.Drawing.Point(792, 5);
            this.radByName.Name = "radByName";
            this.radByName.Size = new System.Drawing.Size(124, 24);
            this.radByName.TabIndex = 6;
            this.radByName.TabStop = true;
            this.radByName.Text = "Search by Name";
            this.radByName.UseVisualStyleBackColor = true;
            this.radByName.CheckedChanged += new System.EventHandler(this.radByName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(959, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearch.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearch.Location = new System.Drawing.Point(795, 40);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSearch.Size = new System.Drawing.Size(158, 25);
            this.dtpSearch.TabIndex = 4;
            this.dtpSearch.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(31, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Marlett", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(28, 59);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(171, 15);
            this.lbledit.TabIndex = 1;
            this.lbledit.Text = "* double click any cell to edit ";
            // 
            // lblUserList
            // 
            this.lblUserList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Underline);
            this.lblUserList.Location = new System.Drawing.Point(479, 23);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(117, 27);
            this.lblUserList.TabIndex = 1;
            this.lblUserList.Text = "Bazar List";
            // 
            // uc_BazarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "uc_BazarList";
            this.Size = new System.Drawing.Size(1084, 621);
            this.Load += new System.EventHandler(this.uc_BazarList_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBazarList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblUserList;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.DataGridView dgvBazarList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton radByDate;
        private System.Windows.Forms.RadioButton radByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.ComboBox comBoxSearch;
    }
}
