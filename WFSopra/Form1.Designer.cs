namespace WFSopra
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.GroupBox();
            this.r_Homme = new System.Windows.Forms.RadioButton();
            this.r_Femme = new System.Windows.Forms.RadioButton();
            this.r_Autre = new System.Windows.Forms.RadioButton();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.l_Nom = new System.Windows.Forms.Label();
            this.l_adresse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sexe.SuspendLayout();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(191, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "HELLO WORLD!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sexe
            // 
            this.Sexe.Controls.Add(this.r_Autre);
            this.Sexe.Controls.Add(this.r_Femme);
            this.Sexe.Controls.Add(this.r_Homme);
            this.Sexe.Location = new System.Drawing.Point(460, 102);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(238, 85);
            this.Sexe.TabIndex = 4;
            this.Sexe.TabStop = false;
            this.Sexe.Text = "Sexe";
            // 
            // User
            // 
            this.User.Controls.Add(this.textBox1);
            this.User.Controls.Add(this.l_adresse);
            this.User.Controls.Add(this.l_Nom);
            this.User.Controls.Add(this.txt_Nom);
            this.User.Location = new System.Drawing.Point(31, 102);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(374, 189);
            this.User.TabIndex = 5;
            this.User.TabStop = false;
            this.User.Text = "User";
            // 
            // r_Homme
            // 
            this.r_Homme.AutoSize = true;
            this.r_Homme.Location = new System.Drawing.Point(6, 35);
            this.r_Homme.Name = "r_Homme";
            this.r_Homme.Size = new System.Drawing.Size(77, 21);
            this.r_Homme.TabIndex = 5;
            this.r_Homme.TabStop = true;
            this.r_Homme.Text = "Homme";
            this.r_Homme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.r_Homme.UseVisualStyleBackColor = true;
            this.r_Homme.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // r_Femme
            // 
            this.r_Femme.AutoSize = true;
            this.r_Femme.Location = new System.Drawing.Point(89, 35);
            this.r_Femme.Name = "r_Femme";
            this.r_Femme.Size = new System.Drawing.Size(75, 21);
            this.r_Femme.TabIndex = 6;
            this.r_Femme.TabStop = true;
            this.r_Femme.Text = "Femme";
            this.r_Femme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.r_Femme.UseVisualStyleBackColor = true;
            // 
            // r_Autre
            // 
            this.r_Autre.AutoSize = true;
            this.r_Autre.Location = new System.Drawing.Point(170, 35);
            this.r_Autre.Name = "r_Autre";
            this.r_Autre.Size = new System.Drawing.Size(63, 21);
            this.r_Autre.TabIndex = 7;
            this.r_Autre.TabStop = true;
            this.r_Autre.Text = "Autre";
            this.r_Autre.UseVisualStyleBackColor = true;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(70, 21);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(298, 22);
            this.txt_Nom.TabIndex = 0;
            this.txt_Nom.TextChanged += new System.EventHandler(this.txt_Nom_TextChanged);
            // 
            // l_Nom
            // 
            this.l_Nom.AutoSize = true;
            this.l_Nom.Location = new System.Drawing.Point(19, 22);
            this.l_Nom.Name = "l_Nom";
            this.l_Nom.Size = new System.Drawing.Size(45, 17);
            this.l_Nom.TabIndex = 1;
            this.l_Nom.Text = "Nom :";
            this.l_Nom.Click += new System.EventHandler(this.l_Nom_Click);
            // 
            // l_adresse
            // 
            this.l_adresse.AutoSize = true;
            this.l_adresse.Location = new System.Drawing.Point(19, 61);
            this.l_adresse.Name = "l_adresse";
            this.l_adresse.Size = new System.Drawing.Size(68, 17);
            this.l_adresse.TabIndex = 2;
            this.l_adresse.Text = "Adresse :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Sexe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sexe.ResumeLayout(false);
            this.Sexe.PerformLayout();
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Sexe;
        private System.Windows.Forms.GroupBox User;
        private System.Windows.Forms.RadioButton r_Autre;
        private System.Windows.Forms.RadioButton r_Femme;
        private System.Windows.Forms.RadioButton r_Homme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_adresse;
        private System.Windows.Forms.Label l_Nom;
        private System.Windows.Forms.TextBox txt_Nom;
    }
}

