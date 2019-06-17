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
            this.Currency = new System.Windows.Forms.ListBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoTransaction = new System.Windows.Forms.Button();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // Currency
            // 
            this.Currency.FormattingEnabled = true;
            this.Currency.Location = new System.Drawing.Point(33, 57);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(408, 316);
            this.Currency.TabIndex = 8;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrencyLabel.Location = new System.Drawing.Point(30, 41);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(411, 13);
            this.CurrencyLabel.TabIndex = 9;
            this.CurrencyLabel.Text = "nazwa_waluty | przelicznik  | kod_waluty | kurs_kupna | kurs_sprzedaży";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrencyLabel);
            this.panel1.Controls.Add(this.Currency);
            this.panel1.Location = new System.Drawing.Point(298, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 389);
            this.panel1.TabIndex = 10;
            // 
            // DoTransaction
            // 
            this.DoTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoTransaction.Location = new System.Drawing.Point(10, 16);
            this.DoTransaction.Name = "DoTransaction";
            this.DoTransaction.Size = new System.Drawing.Size(255, 54);
            this.DoTransaction.TabIndex = 11;
            this.DoTransaction.Text = "Wykonaj Tranzakcję";
            this.DoTransaction.UseVisualStyleBackColor = true;
            this.DoTransaction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DoTransaction_MouseClick);
            // 
            // ShowHistory
            // 
            this.ShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowHistory.Location = new System.Drawing.Point(10, 76);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(255, 54);
            this.ShowHistory.TabIndex = 12;
            this.ShowHistory.Text = "Historia Tranzakcji";
            this.ShowHistory.UseVisualStyleBackColor = true;
            this.ShowHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowHistory_MouseClick);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.Location = new System.Drawing.Point(10, 136);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(255, 54);
            this.Close.TabIndex = 13;
            this.Close.Text = "Zamknij Program";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.ShowHistory);
            this.panel2.Controls.Add(this.DoTransaction);
            this.panel2.Location = new System.Drawing.Point(9, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 388);
            this.panel2.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoneyS);
            this.Controls.Add(this.LoginS);
            this.Controls.Add(this.EmailS);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.LoginU);
            this.Controls.Add(this.EMail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox Currency;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DoTransaction;
        private System.Windows.Forms.Button ShowHistory;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel2;
    }
}