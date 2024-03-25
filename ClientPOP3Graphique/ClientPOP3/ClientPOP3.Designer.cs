namespace ClientPOP3
{
    partial class ClientPOP3
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
            this.listBoxAffichage = new System.Windows.Forms.ListBox();
            this.labelAffichage = new System.Windows.Forms.Label();
            this.listBoxVerbose = new System.Windows.Forms.ListBox();
            this.labelVerbose = new System.Windows.Forms.Label();
            this.buttonSTAT = new System.Windows.Forms.Button();
            this.buttonQUIT = new System.Windows.Forms.Button();
            this.buttonLIST = new System.Windows.Forms.Button();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxExpediteur = new System.Windows.Forms.CheckBox();
            this.checkBoxSujet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decoButton = new System.Windows.Forms.Button();
            this.displayMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxAffichage
            // 
            this.listBoxAffichage.FormattingEnabled = true;
            this.listBoxAffichage.Location = new System.Drawing.Point(24, 38);
            this.listBoxAffichage.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAffichage.Name = "listBoxAffichage";
            this.listBoxAffichage.Size = new System.Drawing.Size(196, 433);
            this.listBoxAffichage.TabIndex = 0;
            this.listBoxAffichage.Click += new System.EventHandler(this.listBoxAffichage_Click);
            // 
            // labelAffichage
            // 
            this.labelAffichage.AutoSize = true;
            this.labelAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAffichage.Location = new System.Drawing.Point(21, 13);
            this.labelAffichage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAffichage.Name = "labelAffichage";
            this.labelAffichage.Size = new System.Drawing.Size(199, 17);
            this.labelAffichage.TabIndex = 1;
            this.labelAffichage.Text = "Affichage pour l\'utilisateur";
            // 
            // listBoxVerbose
            // 
            this.listBoxVerbose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxVerbose.FormattingEnabled = true;
            this.listBoxVerbose.Location = new System.Drawing.Point(701, 38);
            this.listBoxVerbose.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVerbose.Name = "listBoxVerbose";
            this.listBoxVerbose.Size = new System.Drawing.Size(484, 433);
            this.listBoxVerbose.TabIndex = 2;
            // 
            // labelVerbose
            // 
            this.labelVerbose.AutoSize = true;
            this.labelVerbose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerbose.Location = new System.Drawing.Point(699, 13);
            this.labelVerbose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVerbose.Name = "labelVerbose";
            this.labelVerbose.Size = new System.Drawing.Size(330, 17);
            this.labelVerbose.TabIndex = 3;
            this.labelVerbose.Text = "VERBOSE : Communication \"brute\" avec le serveur";
            // 
            // buttonSTAT
            // 
            this.buttonSTAT.Location = new System.Drawing.Point(974, 511);
            this.buttonSTAT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSTAT.Name = "buttonSTAT";
            this.buttonSTAT.Size = new System.Drawing.Size(77, 40);
            this.buttonSTAT.TabIndex = 4;
            this.buttonSTAT.Text = "STAT";
            this.buttonSTAT.UseVisualStyleBackColor = true;
            this.buttonSTAT.Click += new System.EventHandler(this.ButtonSTAT_Click);
            // 
            // buttonQUIT
            // 
            this.buttonQUIT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonQUIT.Location = new System.Drawing.Point(1098, 510);
            this.buttonQUIT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQUIT.Name = "buttonQUIT";
            this.buttonQUIT.Size = new System.Drawing.Size(77, 40);
            this.buttonQUIT.TabIndex = 5;
            this.buttonQUIT.Text = "QUIT";
            this.buttonQUIT.UseVisualStyleBackColor = false;
            this.buttonQUIT.Click += new System.EventHandler(this.ButtonQUIT_Click);
            // 
            // buttonLIST
            // 
            this.buttonLIST.Location = new System.Drawing.Point(846, 511);
            this.buttonLIST.Name = "buttonLIST";
            this.buttonLIST.Size = new System.Drawing.Size(77, 40);
            this.buttonLIST.TabIndex = 12;
            this.buttonLIST.Text = "LIST";
            this.buttonLIST.UseVisualStyleBackColor = true;
            this.buttonLIST.Click += new System.EventHandler(this.ButtonLIST_Click);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(737, 504);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(49, 17);
            this.checkBoxDate.TabIndex = 15;
            this.checkBoxDate.Text = "Date";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxExpediteur
            // 
            this.checkBoxExpediteur.AutoSize = true;
            this.checkBoxExpediteur.Location = new System.Drawing.Point(737, 524);
            this.checkBoxExpediteur.Name = "checkBoxExpediteur";
            this.checkBoxExpediteur.Size = new System.Drawing.Size(76, 17);
            this.checkBoxExpediteur.TabIndex = 16;
            this.checkBoxExpediteur.Text = "Expediteur";
            this.checkBoxExpediteur.UseVisualStyleBackColor = true;
            // 
            // checkBoxSujet
            // 
            this.checkBoxSujet.AutoSize = true;
            this.checkBoxSujet.Location = new System.Drawing.Point(737, 547);
            this.checkBoxSujet.Name = "checkBoxSujet";
            this.checkBoxSujet.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSujet.TabIndex = 17;
            this.checkBoxSujet.Text = "Sujet";
            this.checkBoxSujet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(734, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "En-tête ";
            // 
            // decoButton
            // 
            this.decoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.decoButton.Location = new System.Drawing.Point(24, 510);
            this.decoButton.Name = "decoButton";
            this.decoButton.Size = new System.Drawing.Size(98, 40);
            this.decoButton.TabIndex = 19;
            this.decoButton.Text = "DECONNEXION";
            this.decoButton.UseVisualStyleBackColor = false;
            this.decoButton.Click += new System.EventHandler(this.decoButton_Click);
            // 
            // displayMessage
            // 
            this.displayMessage.Location = new System.Drawing.Point(237, 38);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(445, 433);
            this.displayMessage.TabIndex = 20;
            this.displayMessage.Text = "";
            // 
            // ClientPOP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 603);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.decoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSujet);
            this.Controls.Add(this.checkBoxExpediteur);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.buttonLIST);
            this.Controls.Add(this.buttonQUIT);
            this.Controls.Add(this.buttonSTAT);
            this.Controls.Add(this.labelVerbose);
            this.Controls.Add(this.listBoxVerbose);
            this.Controls.Add(this.labelAffichage);
            this.Controls.Add(this.listBoxAffichage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientPOP3";
            this.Text = "ClientPOP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAffichage;
        private System.Windows.Forms.Label labelAffichage;
        private System.Windows.Forms.ListBox listBoxVerbose;
        private System.Windows.Forms.Label labelVerbose;
        private System.Windows.Forms.Button buttonSTAT;
        private System.Windows.Forms.Button buttonQUIT;
        private System.Windows.Forms.Button buttonLIST;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxExpediteur;
        private System.Windows.Forms.CheckBox checkBoxSujet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decoButton;
        private System.Windows.Forms.RichTextBox displayMessage;
    }
}

