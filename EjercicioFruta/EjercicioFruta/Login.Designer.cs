namespace EjercicioFruta
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExti = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblErrorPassword);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lblRegistrarse);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblLimpiar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnExti);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 506);
            this.panel1.TabIndex = 0;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(323, 344);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(29, 14);
            this.lblErrorPassword.TabIndex = 18;
            this.lblErrorPassword.Text = "Error";
            this.lblErrorPassword.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(323, 270);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 14);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPassword.Location = new System.Drawing.Point(365, 315);
            this.txtPassword.MaxLength = 3232;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 19);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkRed;
            this.txtUser.Location = new System.Drawing.Point(366, 235);
            this.txtUser.MaxLength = 22345;
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(251, 25);
            this.txtUser.TabIndex = 15;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyUp);
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.Location = new System.Drawing.Point(444, 443);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(53, 14);
            this.lblRegistrarse.TabIndex = 14;
            this.lblRegistrarse.Text = "Registrarse";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Location = new System.Drawing.Point(326, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 1);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(324, 302);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(326, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 1);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(324, 228);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiar.Location = new System.Drawing.Point(583, 353);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(37, 14);
            this.lblLimpiar.TabIndex = 9;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnExti
            // 
            this.btnExti.BackColor = System.Drawing.Color.DarkRed;
            this.btnExti.FlatAppearance.BorderSize = 0;
            this.btnExti.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExti.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExti.Location = new System.Drawing.Point(580, 468);
            this.btnExti.Name = "btnExti";
            this.btnExti.Size = new System.Drawing.Size(73, 26);
            this.btnExti.TabIndex = 6;
            this.btnExti.Text = "EXIT";
            this.btnExti.UseVisualStyleBackColor = false;
            this.btnExti.Click += new System.EventHandler(this.btnExti_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(324, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(296, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 504);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 506);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}