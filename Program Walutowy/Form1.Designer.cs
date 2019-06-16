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
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(198, 137);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(117, 39);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login:";
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginInput.Location = new System.Drawing.Point(321, 134);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(297, 47);
            this.LoginInput.TabIndex = 1;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo.Location = new System.Drawing.Point(198, 203);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(122, 39);
            this.haslo.TabIndex = 2;
            this.haslo.Text = "Hasło:";
            // 
            // HasloInput
            // 
            this.HasloInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloInput.Location = new System.Drawing.Point(321, 200);
            this.HasloInput.Name = "HasloInput";
            this.HasloInput.Size = new System.Drawing.Size(297, 47);
            this.HasloInput.TabIndex = 3;
            this.HasloInput.UseSystemPasswordChar = true;
            // 
            // Rejestracja
            // 
            this.Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestracja.Location = new System.Drawing.Point(392, 267);
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
            this.Zaloguj.Location = new System.Drawing.Point(205, 267);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(181, 54);
            this.Zaloguj.TabIndex = 5;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // MenuLogRej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 528);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.HasloInput);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.Login);
            this.Name = "MenuLogRej";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox HasloInput;
        private System.Windows.Forms.Button Rejestracja;
        private System.Windows.Forms.Button Zaloguj;
    }
}

