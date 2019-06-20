namespace Program_Walutowy
{
    partial class Form5
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
            this.TransLab = new System.Windows.Forms.Label();
            this.TransHis = new System.Windows.Forms.ListBox();
            this.GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransLab
            // 
            this.TransLab.BackColor = System.Drawing.SystemColors.Control;
            this.TransLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransLab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TransLab.Location = new System.Drawing.Point(-1, -2);
            this.TransLab.Name = "TransLab";
            this.TransLab.Size = new System.Drawing.Size(801, 50);
            this.TransLab.TabIndex = 7;
            this.TransLab.Text = "Historia Transakcji";
            this.TransLab.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TransHis
            // 
            this.TransHis.FormattingEnabled = true;
            this.TransHis.Location = new System.Drawing.Point(12, 51);
            this.TransHis.Name = "TransHis";
            this.TransHis.Size = new System.Drawing.Size(776, 329);
            this.TransHis.TabIndex = 12;
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoBack.Location = new System.Drawing.Point(615, 384);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(173, 54);
            this.GoBack.TabIndex = 18;
            this.GoBack.Text = "Powrót";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.TransHis);
            this.Controls.Add(this.TransLab);
            this.Name = "Form5";
            this.Text = "Program Walutowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TransLab;
        private System.Windows.Forms.ListBox TransHis;
        private System.Windows.Forms.Button GoBack;
    }
}