namespace disaster
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNUSERLOGIN = new System.Windows.Forms.Button();
            this.BTNADMINLOGIN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNUSERLOGIN
            // 
            this.BTNUSERLOGIN.BackColor = System.Drawing.Color.Navy;
            this.BTNUSERLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUSERLOGIN.ForeColor = System.Drawing.Color.Transparent;
            this.BTNUSERLOGIN.Location = new System.Drawing.Point(496, 460);
            this.BTNUSERLOGIN.Name = "BTNUSERLOGIN";
            this.BTNUSERLOGIN.Size = new System.Drawing.Size(477, 154);
            this.BTNUSERLOGIN.TabIndex = 0;
            this.BTNUSERLOGIN.Text = "USER LOGIN";
            this.BTNUSERLOGIN.UseVisualStyleBackColor = false;
            this.BTNUSERLOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNADMINLOGIN
            // 
            this.BTNADMINLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNADMINLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADMINLOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNADMINLOGIN.Location = new System.Drawing.Point(1120, 460);
            this.BTNADMINLOGIN.Name = "BTNADMINLOGIN";
            this.BTNADMINLOGIN.Size = new System.Drawing.Size(477, 149);
            this.BTNADMINLOGIN.TabIndex = 1;
            this.BTNADMINLOGIN.Text = "ADMIN LOGIN";
            this.BTNADMINLOGIN.UseVisualStyleBackColor = false;
            this.BTNADMINLOGIN.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(846, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(477, 154);
            this.button1.TabIndex = 2;
            this.button1.Text = "OFFICER LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNADMINLOGIN);
            this.Controls.Add(this.BTNUSERLOGIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNUSERLOGIN;
        private System.Windows.Forms.Button BTNADMINLOGIN;
        private System.Windows.Forms.Button button1;
    }
}

