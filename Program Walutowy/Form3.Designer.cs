namespace Program_Walutowy
{
    partial class Form3
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
            this.EmailIn = new System.Windows.Forms.TextBox();
            this.EMailR = new System.Windows.Forms.Label();
            this.LoginIn = new System.Windows.Forms.TextBox();
            this.LoginR = new System.Windows.Forms.Label();
            this.PasswdIn = new System.Windows.Forms.TextBox();
            this.HasloR = new System.Windows.Forms.Label();
            this.PasswdagIn = new System.Windows.Forms.TextBox();
            this.ComPassword = new System.Windows.Forms.Label();
            this.RejestAcc = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailIn
            // 
            this.EmailIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailIn.Location = new System.Drawing.Point(317, 33);
            this.EmailIn.Name = "EmailIn";
            this.EmailIn.Size = new System.Drawing.Size(297, 47);
            this.EmailIn.TabIndex = 3;
            // 
            // EMailR
            // 
            this.EMailR.AutoSize = true;
            this.EMailR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EMailR.Location = new System.Drawing.Point(194, 36);
            this.EMailR.Name = "EMailR";
            this.EMailR.Size = new System.Drawing.Size(121, 39);
            this.EMailR.TabIndex = 2;
            this.EMailR.Text = "Email:";
            // 
            // LoginIn
            // 
            this.LoginIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginIn.Location = new System.Drawing.Point(317, 86);
            this.LoginIn.Name = "LoginIn";
            this.LoginIn.Size = new System.Drawing.Size(297, 47);
            this.LoginIn.TabIndex = 5;
            // 
            // LoginR
            // 
            this.LoginR.AutoSize = true;
            this.LoginR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginR.Location = new System.Drawing.Point(194, 89);
            this.LoginR.Name = "LoginR";
            this.LoginR.Size = new System.Drawing.Size(117, 39);
            this.LoginR.TabIndex = 4;
            this.LoginR.Text = "Login:";
            // 
            // PasswdIn
            // 
            this.PasswdIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdIn.Location = new System.Drawing.Point(317, 139);
            this.PasswdIn.Name = "PasswdIn";
            this.PasswdIn.Size = new System.Drawing.Size(297, 47);
            this.PasswdIn.TabIndex = 7;
            this.PasswdIn.UseSystemPasswordChar = true;
            // 
            // HasloR
            // 
            this.HasloR.AutoSize = true;
            this.HasloR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloR.Location = new System.Drawing.Point(194, 142);
            this.HasloR.Name = "HasloR";
            this.HasloR.Size = new System.Drawing.Size(122, 39);
            this.HasloR.TabIndex = 6;
            this.HasloR.Text = "Hasło:";
            // 
            // PasswdagIn
            // 
            this.PasswdagIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdagIn.Location = new System.Drawing.Point(317, 191);
            this.PasswdagIn.Name = "PasswdagIn";
            this.PasswdagIn.Size = new System.Drawing.Size(297, 47);
            this.PasswdagIn.TabIndex = 9;
            this.PasswdagIn.UseSystemPasswordChar = true;
            // 
            // ComPassword
            // 
            this.ComPassword.AutoSize = true;
            this.ComPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComPassword.Location = new System.Drawing.Point(46, 194);
            this.ComPassword.Name = "ComPassword";
            this.ComPassword.Size = new System.Drawing.Size(265, 39);
            this.ComPassword.TabIndex = 8;
            this.ComPassword.Text = "Powtórz Hasło:";
            // 
            // RejestAcc
            // 
            this.RejestAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RejestAcc.Location = new System.Drawing.Point(388, 244);
            this.RejestAcc.Name = "RejestAcc";
            this.RejestAcc.Size = new System.Drawing.Size(226, 54);
            this.RejestAcc.TabIndex = 10;
            this.RejestAcc.Text = "Zarejestruj";
            this.RejestAcc.UseVisualStyleBackColor = true;
            this.RejestAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RejestAcc_MouseClick);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back.Location = new System.Drawing.Point(156, 244);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(226, 54);
            this.Back.TabIndex = 11;
            this.Back.Text = "Powrót";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RejestAcc);
            this.Controls.Add(this.PasswdagIn);
            this.Controls.Add(this.ComPassword);
            this.Controls.Add(this.PasswdIn);
            this.Controls.Add(this.HasloR);
            this.Controls.Add(this.LoginIn);
            this.Controls.Add(this.LoginR);
            this.Controls.Add(this.EmailIn);
            this.Controls.Add(this.EMailR);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailIn;
        private System.Windows.Forms.Label EMailR;
        private System.Windows.Forms.TextBox LoginIn;
        private System.Windows.Forms.Label LoginR;
        private System.Windows.Forms.TextBox PasswdIn;
        private System.Windows.Forms.Label HasloR;
        private System.Windows.Forms.TextBox PasswdagIn;
        private System.Windows.Forms.Label ComPassword;
        private System.Windows.Forms.Button RejestAcc;
        private System.Windows.Forms.Button Back;
    }
}