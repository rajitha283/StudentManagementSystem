namespace studentmanagementsystem
{
    partial class CourseConductDetailscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseConductDetailscs));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbConductSearch = new System.Windows.Forms.ComboBox();
            this.btnConductSearch = new System.Windows.Forms.Button();
            this.btnConductEdit = new System.Windows.Forms.Button();
            this.btnCConductBack = new System.Windows.Forms.Button();
            this.cmbConductStatus = new System.Windows.Forms.ComboBox();
            this.txtConductTime = new System.Windows.Forms.TextBox();
            this.btnConductClear = new System.Windows.Forms.Button();
            this.btnConductAdd = new System.Windows.Forms.Button();
            this.txtConductName = new System.Windows.Forms.TextBox();
            this.txtConductNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConductSave = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.sqlCeCommand1 = new System.Data.SqlServerCe.SqlCeCommand();
            this.sqlCeConnection1 = new System.Data.SqlServerCe.SqlCeConnection();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(871, 86);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(600, 54);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(241, 21);
            this.dateTimePicker4.TabIndex = 28;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(100, 52);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(247, 21);
            this.dateTimePicker3.TabIndex = 28;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(600, 22);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(241, 21);
            this.textBox11.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(100, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(247, 21);
            this.textBox10.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(472, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "Modified Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(472, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Modified By";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Created Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Created By";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbConductSearch);
            this.groupBox1.Controls.Add(this.btnConductSearch);
            this.groupBox1.Controls.Add(this.btnConductEdit);
            this.groupBox1.Controls.Add(this.btnCConductBack);
            this.groupBox1.Controls.Add(this.cmbConductStatus);
            this.groupBox1.Controls.Add(this.txtConductTime);
            this.groupBox1.Controls.Add(this.btnConductClear);
            this.groupBox1.Controls.Add(this.btnConductAdd);
            this.groupBox1.Controls.Add(this.txtConductName);
            this.groupBox1.Controls.Add(this.txtConductNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConductSave);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 246);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cmbConductSearch
            // 
            this.cmbConductSearch.FormattingEnabled = true;
            this.cmbConductSearch.Location = new System.Drawing.Point(100, 38);
            this.cmbConductSearch.Name = "cmbConductSearch";
            this.cmbConductSearch.Size = new System.Drawing.Size(77, 23);
            this.cmbConductSearch.TabIndex = 12;
            // 
            // btnConductSearch
            // 
            this.btnConductSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnConductSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConductSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConductSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductSearch.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductSearch.ForeColor = System.Drawing.Color.White;
            this.btnConductSearch.Location = new System.Drawing.Point(195, 38);
            this.btnConductSearch.Name = "btnConductSearch";
            this.btnConductSearch.Size = new System.Drawing.Size(75, 23);
            this.btnConductSearch.TabIndex = 10;
            this.btnConductSearch.Text = "Search";
            this.btnConductSearch.UseVisualStyleBackColor = false;
            this.btnConductSearch.Click += new System.EventHandler(this.btnConductSearch_Click);
            // 
            // btnConductEdit
            // 
            this.btnConductEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnConductEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConductEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConductEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductEdit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductEdit.ForeColor = System.Drawing.Color.White;
            this.btnConductEdit.Location = new System.Drawing.Point(372, 199);
            this.btnConductEdit.Name = "btnConductEdit";
            this.btnConductEdit.Size = new System.Drawing.Size(75, 23);
            this.btnConductEdit.TabIndex = 9;
            this.btnConductEdit.Text = "Edit";
            this.btnConductEdit.UseVisualStyleBackColor = false;
            this.btnConductEdit.Click += new System.EventHandler(this.btnConductEdit_Click);
            // 
            // btnCConductBack
            // 
            this.btnCConductBack.BackColor = System.Drawing.Color.Transparent;
            this.btnCConductBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCConductBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCConductBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCConductBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCConductBack.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCConductBack.ForeColor = System.Drawing.Color.White;
            this.btnCConductBack.Location = new System.Drawing.Point(285, 199);
            this.btnCConductBack.Name = "btnCConductBack";
            this.btnCConductBack.Size = new System.Drawing.Size(75, 23);
            this.btnCConductBack.TabIndex = 8;
            this.btnCConductBack.Text = "Back";
            this.btnCConductBack.UseVisualStyleBackColor = false;
            this.btnCConductBack.Click += new System.EventHandler(this.btnCConductBack_Click);
            // 
            // cmbConductStatus
            // 
            this.cmbConductStatus.FormattingEnabled = true;
            this.cmbConductStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbConductStatus.Location = new System.Drawing.Point(102, 147);
            this.cmbConductStatus.Name = "cmbConductStatus";
            this.cmbConductStatus.Size = new System.Drawing.Size(126, 23);
            this.cmbConductStatus.TabIndex = 7;
            // 
            // txtConductTime
            // 
            this.txtConductTime.Location = new System.Drawing.Point(102, 110);
            this.txtConductTime.Name = "txtConductTime";
            this.txtConductTime.Size = new System.Drawing.Size(317, 23);
            this.txtConductTime.TabIndex = 6;
            // 
            // btnConductClear
            // 
            this.btnConductClear.BackColor = System.Drawing.Color.Transparent;
            this.btnConductClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConductClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConductClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductClear.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductClear.ForeColor = System.Drawing.Color.White;
            this.btnConductClear.Location = new System.Drawing.Point(195, 199);
            this.btnConductClear.Name = "btnConductClear";
            this.btnConductClear.Size = new System.Drawing.Size(75, 23);
            this.btnConductClear.TabIndex = 5;
            this.btnConductClear.Text = "Clear";
            this.btnConductClear.UseVisualStyleBackColor = false;
            this.btnConductClear.Click += new System.EventHandler(this.btnConductClear_Click);
            // 
            // btnConductAdd
            // 
            this.btnConductAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnConductAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConductAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConductAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductAdd.ForeColor = System.Drawing.Color.White;
            this.btnConductAdd.Location = new System.Drawing.Point(101, 199);
            this.btnConductAdd.Name = "btnConductAdd";
            this.btnConductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConductAdd.TabIndex = 4;
            this.btnConductAdd.Text = "Add";
            this.btnConductAdd.UseVisualStyleBackColor = false;
            this.btnConductAdd.Click += new System.EventHandler(this.btnConductAdd_Click);
            // 
            // txtConductName
            // 
            this.txtConductName.Location = new System.Drawing.Point(102, 74);
            this.txtConductName.Name = "txtConductName";
            this.txtConductName.Size = new System.Drawing.Size(376, 23);
            this.txtConductName.TabIndex = 2;
            // 
            // txtConductNo
            // 
            this.txtConductNo.Location = new System.Drawing.Point(102, 38);
            this.txtConductNo.Name = "txtConductNo";
            this.txtConductNo.Size = new System.Drawing.Size(75, 23);
            this.txtConductNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "No";
            // 
            // btnConductSave
            // 
            this.btnConductSave.BackColor = System.Drawing.Color.Transparent;
            this.btnConductSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnConductSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConductSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductSave.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductSave.ForeColor = System.Drawing.Color.White;
            this.btnConductSave.Location = new System.Drawing.Point(101, 199);
            this.btnConductSave.Name = "btnConductSave";
            this.btnConductSave.Size = new System.Drawing.Size(75, 23);
            this.btnConductSave.TabIndex = 11;
            this.btnConductSave.Text = "Save";
            this.btnConductSave.UseVisualStyleBackColor = false;
            this.btnConductSave.Click += new System.EventHandler(this.btnConductSave_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(12, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(171, 20);
            this.label28.TabIndex = 34;
            this.label28.Text = "Course Conduct Details";
            // 
            // sqlCeCommand1
            // 
            this.sqlCeCommand1.CommandTimeout = 0;
            this.sqlCeCommand1.Connection = null;
            this.sqlCeCommand1.IndexName = null;
            this.sqlCeCommand1.Transaction = null;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1063, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.TabIndex = 35;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(889, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // CourseConductDetailscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(87)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1105, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseConductDetailscs";
            this.Text = "CourseConductDetailscs";
            this.Load += new System.EventHandler(this.CourseConductDetailscs_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbConductStatus;
        private System.Windows.Forms.TextBox txtConductTime;
        private System.Windows.Forms.Button btnConductClear;
        private System.Windows.Forms.Button btnConductAdd;
        private System.Windows.Forms.TextBox txtConductName;
        private System.Windows.Forms.TextBox txtConductNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCConductBack;
        private System.Windows.Forms.Label label28;
        private System.Data.SqlServerCe.SqlCeCommand sqlCeCommand1;
        private System.Data.SqlServerCe.SqlCeConnection sqlCeConnection1;
        private System.Windows.Forms.Button btnConductEdit;
        private System.Windows.Forms.Button btnConductSearch;
        private System.Windows.Forms.Button btnConductSave;
        private System.Windows.Forms.ComboBox cmbConductSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}