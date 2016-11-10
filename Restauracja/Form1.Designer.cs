namespace Restauracja
{
    partial class Form1
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
            this.Przycisk_Logowania = new System.Windows.Forms.Button();
            this.Etykieta_Logowanie = new System.Windows.Forms.Label();
            this.Tekst_Logowanie = new System.Windows.Forms.TextBox();
            this.Etykieta_Haslo = new System.Windows.Forms.Label();
            this.Tekst_Haslo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Przycisk_Logowania
            // 
            this.Przycisk_Logowania.Location = new System.Drawing.Point(489, 451);
            this.Przycisk_Logowania.Name = "Przycisk_Logowania";
            this.Przycisk_Logowania.Size = new System.Drawing.Size(203, 56);
            this.Przycisk_Logowania.TabIndex = 0;
            this.Przycisk_Logowania.Text = "Zaloguj się";
            this.Przycisk_Logowania.UseVisualStyleBackColor = true;
            this.Przycisk_Logowania.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etykieta_Logowanie
            // 
            this.Etykieta_Logowanie.AutoSize = true;
            this.Etykieta_Logowanie.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Etykieta_Logowanie.Location = new System.Drawing.Point(407, 96);
            this.Etykieta_Logowanie.Name = "Etykieta_Logowanie";
            this.Etykieta_Logowanie.Size = new System.Drawing.Size(106, 40);
            this.Etykieta_Logowanie.TabIndex = 1;
            this.Etykieta_Logowanie.Text = "Login:";
            // 
            // Tekst_Logowanie
            // 
            this.Tekst_Logowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tekst_Logowanie.Location = new System.Drawing.Point(414, 188);
            this.Tekst_Logowanie.Name = "Tekst_Logowanie";
            this.Tekst_Logowanie.Size = new System.Drawing.Size(349, 34);
            this.Tekst_Logowanie.TabIndex = 2;
            // 
            // Etykieta_Haslo
            // 
            this.Etykieta_Haslo.AutoSize = true;
            this.Etykieta_Haslo.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Etykieta_Haslo.Location = new System.Drawing.Point(407, 252);
            this.Etykieta_Haslo.Name = "Etykieta_Haslo";
            this.Etykieta_Haslo.Size = new System.Drawing.Size(109, 40);
            this.Etykieta_Haslo.TabIndex = 3;
            this.Etykieta_Haslo.Text = "Hasło:";
            // 
            // Tekst_Haslo
            // 
            this.Tekst_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tekst_Haslo.Location = new System.Drawing.Point(414, 333);
            this.Tekst_Haslo.Name = "Tekst_Haslo";
            this.Tekst_Haslo.Size = new System.Drawing.Size(349, 34);
            this.Tekst_Haslo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Tekst_Haslo);
            this.Controls.Add(this.Etykieta_Haslo);
            this.Controls.Add(this.Tekst_Logowanie);
            this.Controls.Add(this.Etykieta_Logowanie);
            this.Controls.Add(this.Przycisk_Logowania);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Przycisk_Logowania;
        private System.Windows.Forms.Label Etykieta_Logowanie;
        private System.Windows.Forms.TextBox Tekst_Logowanie;
        private System.Windows.Forms.Label Etykieta_Haslo;
        private System.Windows.Forms.MaskedTextBox Tekst_Haslo;
    }
}

