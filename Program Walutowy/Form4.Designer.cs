namespace Program_Walutowy
{
    partial class Form4
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
            this.CurrencyIn = new System.Windows.Forms.ListBox();
            this.CurrencyOut = new System.Windows.Forms.ListBox();
            this.MoneyIn = new System.Windows.Forms.Label();
            this.MoneyOut = new System.Windows.Forms.Label();
            this.MoneyAEx = new System.Windows.Forms.Label();
            this.MoneyBEx = new System.Windows.Forms.TextBox();
            this.CancelEx = new System.Windows.Forms.Button();
            this.Exchange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyIn
            // 
            this.CurrencyIn.FormattingEnabled = true;
            this.CurrencyIn.Location = new System.Drawing.Point(8, 9);
            this.CurrencyIn.Name = "CurrencyIn";
            this.CurrencyIn.Size = new System.Drawing.Size(173, 160);
            this.CurrencyIn.TabIndex = 11;
            this.CurrencyIn.SelectedIndexChanged += new System.EventHandler(this.CurrencyIn_SelectedIndexChanged);
            // 
            // CurrencyOut
            // 
            this.CurrencyOut.FormattingEnabled = true;
            this.CurrencyOut.Location = new System.Drawing.Point(187, 9);
            this.CurrencyOut.Name = "CurrencyOut";
            this.CurrencyOut.Size = new System.Drawing.Size(173, 160);
            this.CurrencyOut.TabIndex = 12;
            this.CurrencyOut.SelectedIndexChanged += new System.EventHandler(this.CurrencyOut_SelectedIndexChanged);
            // 
            // MoneyIn
            // 
            this.MoneyIn.BackColor = System.Drawing.SystemColors.Control;
            this.MoneyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoneyIn.Location = new System.Drawing.Point(8, 172);
            this.MoneyIn.Name = "MoneyIn";
            this.MoneyIn.Size = new System.Drawing.Size(173, 47);
            this.MoneyIn.TabIndex = 13;
            // 
            // MoneyOut
            // 
            this.MoneyOut.BackColor = System.Drawing.SystemColors.Control;
            this.MoneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoneyOut.Location = new System.Drawing.Point(187, 172);
            this.MoneyOut.Name = "MoneyOut";
            this.MoneyOut.Size = new System.Drawing.Size(173, 47);
            this.MoneyOut.TabIndex = 14;
            // 
            // MoneyAEx
            // 
            this.MoneyAEx.BackColor = System.Drawing.SystemColors.Control;
            this.MoneyAEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyAEx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoneyAEx.Location = new System.Drawing.Point(193, 222);
            this.MoneyAEx.Name = "MoneyAEx";
            this.MoneyAEx.Size = new System.Drawing.Size(167, 47);
            this.MoneyAEx.TabIndex = 15;
            // 
            // MoneyBEx
            // 
            this.MoneyBEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyBEx.Location = new System.Drawing.Point(8, 222);
            this.MoneyBEx.Name = "MoneyBEx";
            this.MoneyBEx.Size = new System.Drawing.Size(173, 47);
            this.MoneyBEx.TabIndex = 16;
            this.MoneyBEx.TextChanged += new System.EventHandler(this.MoneyBEx_TextChanged);
            // 
            // CancelEx
            // 
            this.CancelEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelEx.Location = new System.Drawing.Point(8, 296);
            this.CancelEx.Name = "CancelEx";
            this.CancelEx.Size = new System.Drawing.Size(173, 54);
            this.CancelEx.TabIndex = 17;
            this.CancelEx.Text = "Anuluj";
            this.CancelEx.UseVisualStyleBackColor = true;
            this.CancelEx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelEx_MouseClick);
            // 
            // Exchange
            // 
            this.Exchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exchange.Location = new System.Drawing.Point(187, 296);
            this.Exchange.Name = "Exchange";
            this.Exchange.Size = new System.Drawing.Size(173, 54);
            this.Exchange.TabIndex = 18;
            this.Exchange.Text = "Wymień";
            this.Exchange.UseVisualStyleBackColor = true;
            this.Exchange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exchange_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exchange);
            this.panel1.Controls.Add(this.CancelEx);
            this.panel1.Controls.Add(this.MoneyBEx);
            this.panel1.Controls.Add(this.MoneyAEx);
            this.panel1.Controls.Add(this.MoneyOut);
            this.panel1.Controls.Add(this.MoneyIn);
            this.panel1.Controls.Add(this.CurrencyOut);
            this.panel1.Controls.Add(this.CurrencyIn);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 368);
            this.panel1.TabIndex = 19;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 386);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Program Walutowy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CurrencyIn;
        private System.Windows.Forms.ListBox CurrencyOut;
        private System.Windows.Forms.Label MoneyIn;
        private System.Windows.Forms.Label MoneyOut;
        private System.Windows.Forms.Label MoneyAEx;
        private System.Windows.Forms.TextBox MoneyBEx;
        private System.Windows.Forms.Button CancelEx;
        private System.Windows.Forms.Button Exchange;
        private System.Windows.Forms.Panel panel1;
    }
}