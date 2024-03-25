namespace ClientPOP3
{
    partial class Connexion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe :";
            // 
            // identifiant
            // 
            this.identifiant.Location = new System.Drawing.Point(322, 135);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(222, 20);
            this.identifiant.TabIndex = 4;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(322, 224);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(222, 20);
            this.mdp.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(644, 224);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 35);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // valider
            // 
            this.valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.valider.Location = new System.Drawing.Point(644, 125);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(94, 39);
            this.valider.TabIndex = 7;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide.Location = new System.Drawing.Point(550, 219);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(33, 25);
            this.hide.TabIndex = 8;
            this.hide.Text = "👁️";
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label hide;
    }
}