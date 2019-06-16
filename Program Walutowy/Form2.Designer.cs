namespace Program_Walutowy
{
    partial class Form2
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
            this.EMail = new System.Windows.Forms.Label();
            this.LoginU = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.EmailS = new System.Windows.Forms.Label();
            this.LoginS = new System.Windows.Forms.Label();
            this.MoneyS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EMail
            // 
            this.EMail.AutoSize = true;
            this.EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EMail.Location = new System.Drawing.Point(12, 9);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(121, 39);
            this.EMail.TabIndex = 1;
            this.EMail.Text = "Email:";
            // 
            // LoginU
            // 
            this.LoginU.AutoSize = true;
            this.LoginU.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginU.Location = new System.Drawing.Point(215, 9);
            this.LoginU.Name = "LoginU";
            this.LoginU.Size = new System.Drawing.Size(117, 39);
            this.LoginU.TabIndex = 2;
            this.LoginU.Text = "Login:";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Money.Location = new System.Drawing.Point(425, 9);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(172, 39);
            this.Money.TabIndex = 4;
            this.Money.Text = "Gotówka:";
            // 
            // EmailS
            // 
            this.EmailS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EmailS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailS.Location = new System.Drawing.Point(139, 9);
            this.EmailS.Name = "EmailS";
            this.EmailS.Size = new System.Drawing.Size(84, 35);
            this.EmailS.TabIndex = 5;
            // 
            // LoginS
            // 
            this.LoginS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginS.Location = new System.Drawing.Point(320, 11);
            this.LoginS.Name = "LoginS";
            this.LoginS.Size = new System.Drawing.Size(99, 35);
            this.LoginS.TabIndex = 6;
            // 
            // MoneyS
            // 
            this.MoneyS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MoneyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoneyS.Location = new System.Drawing.Point(603, 11);
            this.MoneyS.Name = "MoneyS";
            this.MoneyS.Size = new System.Drawing.Size(114, 35);
            this.MoneyS.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyS);
            this.Controls.Add(this.LoginS);
            this.Controls.Add(this.EmailS);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.LoginU);
            this.Controls.Add(this.EMail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EMail;
        private System.Windows.Forms.Label LoginU;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label EmailS;
        private System.Windows.Forms.Label LoginS;
        private System.Windows.Forms.Label MoneyS;
    }
}