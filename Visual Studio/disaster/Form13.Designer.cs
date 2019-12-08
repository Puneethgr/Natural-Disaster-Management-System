namespace disaster
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.btnLogout = new System.Windows.Forms.Button();
            this.BTNDISSASTER = new System.Windows.Forms.Button();
            this.BTNCAMPAIGNS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(60, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 69);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BTNDISSASTER
            // 
            this.BTNDISSASTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNDISSASTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDISSASTER.ForeColor = System.Drawing.Color.White;
            this.BTNDISSASTER.Location = new System.Drawing.Point(420, 304);
            this.BTNDISSASTER.Name = "BTNDISSASTER";
            this.BTNDISSASTER.Size = new System.Drawing.Size(304, 101);
            this.BTNDISSASTER.TabIndex = 14;
            this.BTNDISSASTER.Text = "DISASTERS";
            this.BTNDISSASTER.UseVisualStyleBackColor = false;
            this.BTNDISSASTER.Click += new System.EventHandler(this.BTNDISSASTER_Click);
            // 
            // BTNCAMPAIGNS
            // 
            this.BTNCAMPAIGNS.BackColor = System.Drawing.Color.Indigo;
            this.BTNCAMPAIGNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCAMPAIGNS.ForeColor = System.Drawing.Color.White;
            this.BTNCAMPAIGNS.Location = new System.Drawing.Point(929, 304);
            this.BTNCAMPAIGNS.Name = "BTNCAMPAIGNS";
            this.BTNCAMPAIGNS.Size = new System.Drawing.Size(285, 101);
            this.BTNCAMPAIGNS.TabIndex = 11;
            this.BTNCAMPAIGNS.Text = "CAMPAIGNS";
            this.BTNCAMPAIGNS.UseVisualStyleBackColor = false;
            this.BTNCAMPAIGNS.Click += new System.EventHandler(this.BTNCAMPAIGNS_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.BTNDISSASTER);
            this.Controls.Add(this.BTNCAMPAIGNS);
            this.Name = "Form13";
            this.Text = "Form13";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button BTNDISSASTER;
        private System.Windows.Forms.Button BTNCAMPAIGNS;
    }
}