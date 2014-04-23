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
            this.usernameFieldLbl = new System.Windows.Forms.Label();
            this.passwdFieldLbl = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwdField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameFieldLbl
            // 
            this.usernameFieldLbl.AutoSize = true;
            this.usernameFieldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFieldLbl.Location = new System.Drawing.Point(13, 37);
            this.usernameFieldLbl.Name = "usernameFieldLbl";
            this.usernameFieldLbl.Size = new System.Drawing.Size(117, 24);
            this.usernameFieldLbl.TabIndex = 0;
            this.usernameFieldLbl.Text = "Username: ";
            // 
            // passwdFieldLbl
            // 
            this.passwdFieldLbl.AutoSize = true;
            this.passwdFieldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdFieldLbl.Location = new System.Drawing.Point(13, 77);
            this.passwdFieldLbl.Name = "passwdFieldLbl";
            this.passwdFieldLbl.Size = new System.Drawing.Size(112, 24);
            this.passwdFieldLbl.TabIndex = 1;
            this.passwdFieldLbl.Text = "Password: ";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(136, 42);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(187, 20);
            this.usernameField.TabIndex = 0;
            // 
            // passwdField
            // 
            this.passwdField.Location = new System.Drawing.Point(136, 77);
            this.passwdField.Name = "passwdField";
            this.passwdField.Size = new System.Drawing.Size(187, 20);
            this.passwdField.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(17, 132);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(283, 132);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(145, 132);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 253);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwdField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwdFieldLbl);
            this.Controls.Add(this.usernameFieldLbl);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameFieldLbl;
        private System.Windows.Forms.Label passwdFieldLbl;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwdField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}

