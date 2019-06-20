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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailIn
            // 
            this.EmailIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailIn.Location = new System.Drawing.Point(284, 29);
            this.EmailIn.Name = "EmailIn";
            this.EmailIn.Size = new System.Drawing.Size(297, 47);
            this.EmailIn.TabIndex = 3;
            // 
            // EMailR
            // 
            this.EMailR.AutoSize = true;
            this.EMailR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EMailR.Location = new System.Drawing.Point(161, 32);
            this.EMailR.Name = "EMailR";
            this.EMailR.Size = new System.Drawing.Size(121, 39);
            this.EMailR.TabIndex = 2;
            this.EMailR.Text = "Email:";
            // 
            // LoginIn
            // 
            this.LoginIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginIn.Location = new System.Drawing.Point(284, 82);
            this.LoginIn.Name = "LoginIn";
            this.LoginIn.Size = new System.Drawing.Size(297, 47);
            this.LoginIn.TabIndex = 5;
            // 
            // LoginR
            // 
            this.LoginR.AutoSize = true;
            this.LoginR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginR.Location = new System.Drawing.Point(161, 85);
            this.LoginR.Name = "LoginR";
            this.LoginR.Size = new System.Drawing.Size(117, 39);
            this.LoginR.TabIndex = 4;
            this.LoginR.Text = "Login:";
            // 
            // PasswdIn
            // 
            this.PasswdIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdIn.Location = new System.Drawing.Point(284, 135);
            this.PasswdIn.Name = "PasswdIn";
            this.PasswdIn.Size = new System.Drawing.Size(297, 47);
            this.PasswdIn.TabIndex = 7;
            this.PasswdIn.UseSystemPasswordChar = true;
            // 
            // HasloR
            // 
            this.HasloR.AutoSize = true;
            this.HasloR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloR.Location = new System.Drawing.Point(161, 138);
            this.HasloR.Name = "HasloR";
            this.HasloR.Size = new System.Drawing.Size(122, 39);
            this.HasloR.TabIndex = 6;
            this.HasloR.Text = "Hasło:";
            // 
            // PasswdagIn
            // 
            this.PasswdagIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdagIn.Location = new System.Drawing.Point(284, 187);
            this.PasswdagIn.Name = "PasswdagIn";
            this.PasswdagIn.Size = new System.Drawing.Size(297, 47);
            this.PasswdagIn.TabIndex = 9;
            this.PasswdagIn.UseSystemPasswordChar = true;
            // 
            // ComPassword
            // 
            this.ComPassword.AutoSize = true;
            this.ComPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComPassword.Location = new System.Drawing.Point(13, 190);
            this.ComPassword.Name = "ComPassword";
            this.ComPassword.Size = new System.Drawing.Size(265, 39);
            this.ComPassword.TabIndex = 8;
            this.ComPassword.Text = "Powtórz Hasło:";
            // 
            // RejestAcc
            // 
            this.RejestAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RejestAcc.Location = new System.Drawing.Point(355, 240);
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
            this.Back.Location = new System.Drawing.Point(123, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(226, 54);
            this.Back.TabIndex = 11;
            this.Back.Text = "Powrót";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.RejestAcc);
            this.panel1.Controls.Add(this.PasswdagIn);
            this.panel1.Controls.Add(this.ComPassword);
            this.panel1.Controls.Add(this.PasswdIn);
            this.panel1.Controls.Add(this.HasloR);
            this.panel1.Controls.Add(this.LoginIn);
            this.panel1.Controls.Add(this.LoginR);
            this.panel1.Controls.Add(this.EmailIn);
            this.panel1.Controls.Add(this.EMailR);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 345);
            this.panel1.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 373);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Program Walutowy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}