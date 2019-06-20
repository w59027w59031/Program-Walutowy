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
            this.Currency = new System.Windows.Forms.ListBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.ListBox();
            this.DoTransaction = new System.Windows.Forms.Button();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.LoginS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currency
            // 
            this.Currency.FormattingEnabled = true;
            this.Currency.Location = new System.Drawing.Point(28, 212);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(408, 160);
            this.Currency.TabIndex = 8;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrencyLabel.Location = new System.Drawing.Point(25, 196);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(411, 13);
            this.CurrencyLabel.TabIndex = 9;
            this.CurrencyLabel.Text = "nazwa_waluty | przelicznik  | kod_waluty | kurs_kupna | kurs_sprzedaży";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Controls.Add(this.CurrencyLabel);
            this.panel1.Controls.Add(this.Currency);
            this.panel1.Location = new System.Drawing.Point(298, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 389);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "nazwa_waluty | przelicznik  | kod_waluty | kurs_kupna | kurs_sprzedaży";
            // 
            // Balance
            // 
            this.Balance.FormattingEnabled = true;
            this.Balance.Location = new System.Drawing.Point(28, 30);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(408, 160);
            this.Balance.TabIndex = 10;
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
            this.Close.Location = new System.Drawing.Point(10, 196);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(255, 54);
            this.Close.TabIndex = 13;
            this.Close.Text = "Zamknij Program";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogOut);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.ShowHistory);
            this.panel2.Controls.Add(this.DoTransaction);
            this.panel2.Location = new System.Drawing.Point(9, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 388);
            this.panel2.TabIndex = 14;
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOut.Location = new System.Drawing.Point(10, 136);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(255, 54);
            this.LogOut.TabIndex = 14;
            this.LogOut.Text = "Wyloguj";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogOut_MouseClick);
            // 
            // LoginS
            // 
            this.LoginS.BackColor = System.Drawing.SystemColors.Control;
            this.LoginS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginS.Location = new System.Drawing.Point(-1, 0);
            this.LoginS.Name = "LoginS";
            this.LoginS.Size = new System.Drawing.Size(801, 39);
            this.LoginS.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Currency;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DoTransaction;
        private System.Windows.Forms.Button ShowHistory;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Balance;
        private System.Windows.Forms.Label LoginS;
    }
}