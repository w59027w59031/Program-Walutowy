namespace Program_Walutowy
{
    partial class MenuLogRej
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.HasloInput = new System.Windows.Forms.TextBox();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(70, 76);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(117, 39);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login:";
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginInput.Location = new System.Drawing.Point(193, 73);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(297, 47);
            this.LoginInput.TabIndex = 1;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.Location = new System.Drawing.Point(70, 142);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(122, 39);
            this.haslo.TabIndex = 2;
            this.haslo.Text = "Hasło:";
            // 
            // HasloInput
            // 
            this.HasloInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloInput.Location = new System.Drawing.Point(193, 139);
            this.HasloInput.Name = "HasloInput";
            this.HasloInput.Size = new System.Drawing.Size(297, 47);
            this.HasloInput.TabIndex = 3;
            this.HasloInput.UseSystemPasswordChar = true;
            // 
            // Rejestracja
            // 
            this.Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestracja.Location = new System.Drawing.Point(264, 206);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(226, 54);
            this.Rejestracja.TabIndex = 4;
            this.Rejestracja.Text = "Rejestracja";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // Zaloguj
            // 
            this.Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaloguj.Location = new System.Drawing.Point(77, 206);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(181, 54);
            this.Zaloguj.TabIndex = 5;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Zaloguj);
            this.panel1.Controls.Add(this.Rejestracja);
            this.panel1.Controls.Add(this.HasloInput);
            this.panel1.Controls.Add(this.haslo);
            this.panel1.Controls.Add(this.LoginInput);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 326);
            this.panel1.TabIndex = 6;
            // 
            // MenuLogRej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 357);
            this.Controls.Add(this.panel1);
            this.Name = "MenuLogRej";
            this.Text = "Program Walutowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox HasloInput;
        private System.Windows.Forms.Button Rejestracja;
        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Panel panel1;
    }
}

