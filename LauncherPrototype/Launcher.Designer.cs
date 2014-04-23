namespace LauncherPrototype
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.usernameFieldLbl = new System.Windows.Forms.Label();
            this.passwdFieldLbl = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.lockPic = new System.Windows.Forms.PictureBox();
            this.passwdField = new System.Windows.Forms.TextBox();
            this.LoginTitleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.opnSSLLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lockPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameFieldLbl
            // 
            this.usernameFieldLbl.AutoSize = true;
            this.usernameFieldLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameFieldLbl.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFieldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.usernameFieldLbl.Location = new System.Drawing.Point(324, 183);
            this.usernameFieldLbl.Name = "usernameFieldLbl";
            this.usernameFieldLbl.Size = new System.Drawing.Size(150, 27);
            this.usernameFieldLbl.TabIndex = 0;
            this.usernameFieldLbl.Text = "Username: ";
            // 
            // passwdFieldLbl
            // 
            this.passwdFieldLbl.AutoSize = true;
            this.passwdFieldLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwdFieldLbl.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdFieldLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passwdFieldLbl.Location = new System.Drawing.Point(324, 223);
            this.passwdFieldLbl.Name = "passwdFieldLbl";
            this.passwdFieldLbl.Size = new System.Drawing.Size(141, 27);
            this.passwdFieldLbl.TabIndex = 1;
            this.passwdFieldLbl.Text = "Password: ";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.Gray;
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameField.Cursor = System.Windows.Forms.Cursors.Cross;
            this.usernameField.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.Black;
            this.usernameField.Location = new System.Drawing.Point(494, 183);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(230, 29);
            this.usernameField.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(311, 475);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(154, 97);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(654, 475);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(154, 97);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(484, 475);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(154, 97);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // lockPic
            // 
            this.lockPic.BackColor = System.Drawing.Color.Transparent;
            this.lockPic.Image = global::LauncherPrototype.Properties.Resources.padlock;
            this.lockPic.Location = new System.Drawing.Point(1059, 12);
            this.lockPic.Name = "lockPic";
            this.lockPic.Size = new System.Drawing.Size(62, 43);
            this.lockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockPic.TabIndex = 22;
            this.lockPic.TabStop = false;
            // 
            // passwdField
            // 
            this.passwdField.BackColor = System.Drawing.Color.Gray;
            this.passwdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdField.Cursor = System.Windows.Forms.Cursors.Cross;
            this.passwdField.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdField.ForeColor = System.Drawing.Color.Black;
            this.passwdField.Location = new System.Drawing.Point(494, 218);
            this.passwdField.Name = "passwdField";
            this.passwdField.PasswordChar = '*';
            this.passwdField.Size = new System.Drawing.Size(230, 29);
            this.passwdField.TabIndex = 1;
            this.passwdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdField_KeyPress);
            // 
            // LoginTitleLbl
            // 
            this.LoginTitleLbl.AutoSize = true;
            this.LoginTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoginTitleLbl.Font = new System.Drawing.Font("Lucida Blackletter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LoginTitleLbl.Location = new System.Drawing.Point(372, 60);
            this.LoginTitleLbl.Name = "LoginTitleLbl";
            this.LoginTitleLbl.Size = new System.Drawing.Size(348, 37);
            this.LoginTitleLbl.TabIndex = 23;
            this.LoginTitleLbl.Text = "Welcome... to the gate...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(994, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(966, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // opnSSLLbl
            // 
            this.opnSSLLbl.AutoSize = true;
            this.opnSSLLbl.BackColor = System.Drawing.Color.Transparent;
            this.opnSSLLbl.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnSSLLbl.ForeColor = System.Drawing.Color.White;
            this.opnSSLLbl.Location = new System.Drawing.Point(963, 3);
            this.opnSSLLbl.Name = "opnSSLLbl";
            this.opnSSLLbl.Size = new System.Drawing.Size(64, 16);
            this.opnSSLLbl.TabIndex = 26;
            this.opnSSLLbl.Text = "Secured By";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 619);
            this.Controls.Add(this.opnSSLLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginTitleLbl);
            this.Controls.Add(this.lockPic);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwdField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwdFieldLbl);
            this.Controls.Add(this.usernameFieldLbl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.Text = "Gate of Gabethulu by Team7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Launcher_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.lockPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameFieldLbl;
        private System.Windows.Forms.Label passwdFieldLbl;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox lockPic;
        private System.Windows.Forms.TextBox passwdField;
        private System.Windows.Forms.Label LoginTitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label opnSSLLbl;
    }
}

