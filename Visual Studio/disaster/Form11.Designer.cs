namespace disaster
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.BTNADD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textuid = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnuserid = new System.Windows.Forms.Label();
            this.btnname = new System.Windows.Forms.Label();
            this.btnpassword = new System.Windows.Forms.Label();
            this.btndisasterid = new System.Windows.Forms.Label();
            this.btnaadhar = new System.Windows.Forms.Label();
            this.btnphno = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNADD.Location = new System.Drawing.Point(54, 158);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(257, 91);
            this.BTNADD.TabIndex = 8;
            this.BTNADD.Text = "INSERT";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(392, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 91);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textuid
            // 
            this.textuid.Location = new System.Drawing.Point(213, 287);
            this.textuid.Name = "textuid";
            this.textuid.Size = new System.Drawing.Size(310, 22);
            this.textuid.TabIndex = 1;
            this.textuid.TextChanged += new System.EventHandler(this.textuid_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 348);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(699, 287);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(398, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(699, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(398, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(699, 403);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(398, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnuserid
            // 
            this.btnuserid.AutoSize = true;
            this.btnuserid.Location = new System.Drawing.Point(126, 287);
            this.btnuserid.Name = "btnuserid";
            this.btnuserid.Size = new System.Drawing.Size(47, 17);
            this.btnuserid.TabIndex = 19;
            this.btnuserid.Text = "userid";
            this.btnuserid.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnname
            // 
            this.btnname.AutoSize = true;
            this.btnname.Location = new System.Drawing.Point(126, 353);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(45, 17);
            this.btnname.TabIndex = 19;
            this.btnname.Text = "Name";
            this.btnname.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnpassword
            // 
            this.btnpassword.AutoSize = true;
            this.btnpassword.Location = new System.Drawing.Point(126, 408);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Size = new System.Drawing.Size(69, 17);
            this.btnpassword.TabIndex = 19;
            this.btnpassword.Text = "Password";
            this.btnpassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // btndisasterid
            // 
            this.btndisasterid.AutoSize = true;
            this.btndisasterid.Location = new System.Drawing.Point(617, 406);
            this.btndisasterid.Name = "btndisasterid";
            this.btndisasterid.Size = new System.Drawing.Size(77, 17);
            this.btndisasterid.TabIndex = 19;
            this.btndisasterid.Text = "Disaster ID";
            this.btndisasterid.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnaadhar
            // 
            this.btnaadhar.AutoSize = true;
            this.btnaadhar.Location = new System.Drawing.Point(617, 348);
            this.btnaadhar.Name = "btnaadhar";
            this.btnaadhar.Size = new System.Drawing.Size(76, 17);
            this.btnaadhar.TabIndex = 19;
            this.btnaadhar.Text = "Aadhar No";
            this.btnaadhar.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnphno
            // 
            this.btnphno.AutoSize = true;
            this.btnphno.Location = new System.Drawing.Point(590, 287);
            this.btnphno.Name = "btnphno";
            this.btnphno.Size = new System.Drawing.Size(103, 17);
            this.btnphno.TabIndex = 19;
            this.btnphno.Text = "Phone Number";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(129, 473);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1071, 297);
            this.dgvData.TabIndex = 20;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(747, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 91);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1341, 801);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnphno);
            this.Controls.Add(this.btnaadhar);
            this.Controls.Add(this.btndisasterid);
            this.Controls.Add(this.btnpassword);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.btnuserid);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textuid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textuid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label btnuserid;
        private System.Windows.Forms.Label btnname;
        private System.Windows.Forms.Label btnpassword;
        private System.Windows.Forms.Label btndisasterid;
        private System.Windows.Forms.Label btnaadhar;
        private System.Windows.Forms.Label btnphno;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnUpdate;
    }
}