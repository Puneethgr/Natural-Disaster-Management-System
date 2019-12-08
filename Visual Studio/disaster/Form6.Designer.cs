namespace disaster
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.BTNDISSASTER = new System.Windows.Forms.Button();
            this.BTNDONATION = new System.Windows.Forms.Button();
            this.BTNOFFICER = new System.Windows.Forms.Button();
            this.BTNCAMPAIGNS = new System.Windows.Forms.Button();
            this.BTNUSERS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNDISSASTER
            // 
            this.BTNDISSASTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNDISSASTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDISSASTER.ForeColor = System.Drawing.Color.White;
            this.BTNDISSASTER.Location = new System.Drawing.Point(765, 285);
            this.BTNDISSASTER.Name = "BTNDISSASTER";
            this.BTNDISSASTER.Size = new System.Drawing.Size(304, 101);
            this.BTNDISSASTER.TabIndex = 8;
            this.BTNDISSASTER.Text = "DISASTERS";
            this.BTNDISSASTER.UseVisualStyleBackColor = false;
            this.BTNDISSASTER.Click += new System.EventHandler(this.BTNDISSASTER_Click);
            // 
            // BTNDONATION
            // 
            this.BTNDONATION.BackColor = System.Drawing.Color.Maroon;
            this.BTNDONATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDONATION.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNDONATION.Location = new System.Drawing.Point(287, 485);
            this.BTNDONATION.Name = "BTNDONATION";
            this.BTNDONATION.Size = new System.Drawing.Size(285, 101);
            this.BTNDONATION.TabIndex = 7;
            this.BTNDONATION.Text = "DONATIONS";
            this.BTNDONATION.UseVisualStyleBackColor = false;
            this.BTNDONATION.Click += new System.EventHandler(this.BTNDONATION_Click);
            // 
            // BTNOFFICER
            // 
            this.BTNOFFICER.BackColor = System.Drawing.Color.Black;
            this.BTNOFFICER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOFFICER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNOFFICER.Location = new System.Drawing.Point(773, 485);
            this.BTNOFFICER.Name = "BTNOFFICER";
            this.BTNOFFICER.Size = new System.Drawing.Size(296, 101);
            this.BTNOFFICER.TabIndex = 6;
            this.BTNOFFICER.Text = "OFFICERS";
            this.BTNOFFICER.UseVisualStyleBackColor = false;
            this.BTNOFFICER.Click += new System.EventHandler(this.BTNOFFICER_Click);
            // 
            // BTNCAMPAIGNS
            // 
            this.BTNCAMPAIGNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNCAMPAIGNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCAMPAIGNS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNCAMPAIGNS.Location = new System.Drawing.Point(287, 285);
            this.BTNCAMPAIGNS.Name = "BTNCAMPAIGNS";
            this.BTNCAMPAIGNS.Size = new System.Drawing.Size(285, 101);
            this.BTNCAMPAIGNS.TabIndex = 5;
            this.BTNCAMPAIGNS.Text = "CAMPAIGNS";
            this.BTNCAMPAIGNS.UseVisualStyleBackColor = false;
            this.BTNCAMPAIGNS.Click += new System.EventHandler(this.BTNCAMPAIGNS_Click);
            // 
            // BTNUSERS
            // 
            this.BTNUSERS.BackColor = System.Drawing.Color.Indigo;
            this.BTNUSERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUSERS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNUSERS.Location = new System.Drawing.Point(556, 688);
            this.BTNUSERS.Name = "BTNUSERS";
            this.BTNUSERS.Size = new System.Drawing.Size(246, 98);
            this.BTNUSERS.TabIndex = 9;
            this.BTNUSERS.Text = "USERS";
            this.BTNUSERS.UseVisualStyleBackColor = false;
            this.BTNUSERS.Click += new System.EventHandler(this.BTNUSERS_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(42, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 69);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1473, 798);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.BTNUSERS);
            this.Controls.Add(this.BTNDISSASTER);
            this.Controls.Add(this.BTNDONATION);
            this.Controls.Add(this.BTNOFFICER);
            this.Controls.Add(this.BTNCAMPAIGNS);
            this.Name = "Form6";
            this.Text = "CAMPAIGNS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNDISSASTER;
        private System.Windows.Forms.Button BTNDONATION;
        private System.Windows.Forms.Button BTNOFFICER;
        private System.Windows.Forms.Button BTNCAMPAIGNS;
        private System.Windows.Forms.Button BTNUSERS;
        private System.Windows.Forms.Button btnLogout;
    }
}