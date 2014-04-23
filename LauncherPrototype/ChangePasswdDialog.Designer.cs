namespace LauncherPrototype
{
    partial class ChangePasswdDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswdDialog));
            this.ReenterPasswdLbl = new System.Windows.Forms.Label();
            this.CurrentPasswdLbl = new System.Windows.Forms.Label();
            this.NewPasswdLbl = new System.Windows.Forms.Label();
            this.NewPasswdField = new System.Windows.Forms.TextBox();
            this.ReenterNewPasswdField = new System.Windows.Forms.TextBox();
            this.CurrentPasswdField = new System.Windows.Forms.TextBox();
            this.ChangePasswdBtn = new System.Windows.Forms.Button();
            this.PasswdCancelBtn = new System.Windows.Forms.Button();
            this.passwdValidationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReenterPasswdLbl
            // 
            this.ReenterPasswdLbl.AutoSize = true;
            this.ReenterPasswdLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReenterPasswdLbl.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReenterPasswdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ReenterPasswdLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReenterPasswdLbl.Location = new System.Drawing.Point(34, 128);
            this.ReenterPasswdLbl.Name = "ReenterPasswdLbl";
            this.ReenterPasswdLbl.Size = new System.Drawing.Size(261, 24);
            this.ReenterPasswdLbl.TabIndex = 18;
            this.ReenterPasswdLbl.Text = "Re-enter New Password:";
            // 
            // CurrentPasswdLbl
            // 
            this.CurrentPasswdLbl.AutoSize = true;
            this.CurrentPasswdLbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPasswdLbl.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CurrentPasswdLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentPasswdLbl.Location = new System.Drawing.Point(34, 29);
            this.CurrentPasswdLbl.Name = "CurrentPasswdLbl";
            this.CurrentPasswdLbl.Size = new System.Drawing.Size(201, 24);
            this.CurrentPasswdLbl.TabIndex = 19;
            this.CurrentPasswdLbl.Text = "Current Password:";
            // 
            // NewPasswdLbl
            // 
            this.NewPasswdLbl.AutoSize = true;
            this.NewPasswdLbl.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswdLbl.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NewPasswdLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewPasswdLbl.Location = new System.Drawing.Point(34, 78);
            this.NewPasswdLbl.Name = "NewPasswdLbl";
            this.NewPasswdLbl.Size = new System.Drawing.Size(168, 24);
            this.NewPasswdLbl.TabIndex = 20;
            this.NewPasswdLbl.Text = "New Password:";
            // 
            // NewPasswdField
            // 
            this.NewPasswdField.BackColor = System.Drawing.Color.White;
            this.NewPasswdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswdField.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswdField.ForeColor = System.Drawing.Color.Black;
            this.NewPasswdField.Location = new System.Drawing.Point(333, 78);
            this.NewPasswdField.Name = "NewPasswdField";
            this.NewPasswdField.Size = new System.Drawing.Size(279, 22);
            this.NewPasswdField.TabIndex = 21;
            // 
            // ReenterNewPasswdField
            // 
            this.ReenterNewPasswdField.BackColor = System.Drawing.Color.White;
            this.ReenterNewPasswdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReenterNewPasswdField.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReenterNewPasswdField.ForeColor = System.Drawing.Color.Black;
            this.ReenterNewPasswdField.Location = new System.Drawing.Point(333, 128);
            this.ReenterNewPasswdField.Name = "ReenterNewPasswdField";
            this.ReenterNewPasswdField.Size = new System.Drawing.Size(279, 22);
            this.ReenterNewPasswdField.TabIndex = 22;
            this.ReenterNewPasswdField.TextChanged += new System.EventHandler(this.ReenterNewPasswdField_TextChanged);
            // 
            // CurrentPasswdField
            // 
            this.CurrentPasswdField.BackColor = System.Drawing.Color.White;
            this.CurrentPasswdField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentPasswdField.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswdField.ForeColor = System.Drawing.Color.Black;
            this.CurrentPasswdField.Location = new System.Drawing.Point(333, 29);
            this.CurrentPasswdField.Name = "CurrentPasswdField";
            this.CurrentPasswdField.Size = new System.Drawing.Size(279, 22);
            this.CurrentPasswdField.TabIndex = 23;
            // 
            // ChangePasswdBtn
            // 
            this.ChangePasswdBtn.BackColor = System.Drawing.Color.Transparent;
            this.ChangePasswdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePasswdBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswdBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChangePasswdBtn.Location = new System.Drawing.Point(98, 259);
            this.ChangePasswdBtn.Name = "ChangePasswdBtn";
            this.ChangePasswdBtn.Size = new System.Drawing.Size(185, 86);
            this.ChangePasswdBtn.TabIndex = 24;
            this.ChangePasswdBtn.Text = "Change Password";
            this.ChangePasswdBtn.UseVisualStyleBackColor = false;
            this.ChangePasswdBtn.Click += new System.EventHandler(this.ChangePasswdBtn_Click);
            // 
            // PasswdCancelBtn
            // 
            this.PasswdCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.PasswdCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswdCancelBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswdCancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PasswdCancelBtn.Location = new System.Drawing.Point(374, 259);
            this.PasswdCancelBtn.Name = "PasswdCancelBtn";
            this.PasswdCancelBtn.Size = new System.Drawing.Size(185, 86);
            this.PasswdCancelBtn.TabIndex = 25;
            this.PasswdCancelBtn.Text = "Cancel";
            this.PasswdCancelBtn.UseVisualStyleBackColor = false;
            this.PasswdCancelBtn.Click += new System.EventHandler(this.PasswdCancelBtn_Click);
            // 
            // passwdValidationLbl
            // 
            this.passwdValidationLbl.AutoSize = true;
            this.passwdValidationLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwdValidationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdValidationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passwdValidationLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwdValidationLbl.Location = new System.Drawing.Point(331, 170);
            this.passwdValidationLbl.Name = "passwdValidationLbl";
            this.passwdValidationLbl.Size = new System.Drawing.Size(281, 29);
            this.passwdValidationLbl.TabIndex = 26;
            this.passwdValidationLbl.Text = "Passwords do not match!";
            this.passwdValidationLbl.Visible = false;
            // 
            // ChangePasswdDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 365);
            this.Controls.Add(this.passwdValidationLbl);
            this.Controls.Add(this.PasswdCancelBtn);
            this.Controls.Add(this.ChangePasswdBtn);
            this.Controls.Add(this.CurrentPasswdField);
            this.Controls.Add(this.ReenterNewPasswdField);
            this.Controls.Add(this.NewPasswdField);
            this.Controls.Add(this.NewPasswdLbl);
            this.Controls.Add(this.CurrentPasswdLbl);
            this.Controls.Add(this.ReenterPasswdLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswdDialog";
            this.Text = "Change Account Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswdDialog_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReenterPasswdLbl;
        private System.Windows.Forms.Label CurrentPasswdLbl;
        private System.Windows.Forms.Label NewPasswdLbl;
        private System.Windows.Forms.TextBox NewPasswdField;
        private System.Windows.Forms.TextBox ReenterNewPasswdField;
        private System.Windows.Forms.TextBox CurrentPasswdField;
        private System.Windows.Forms.Button ChangePasswdBtn;
        private System.Windows.Forms.Button PasswdCancelBtn;
        private System.Windows.Forms.Label passwdValidationLbl;
    }
}