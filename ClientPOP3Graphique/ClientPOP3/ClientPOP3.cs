using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPOP3
{
    public partial class ClientPOP3 : Form
    {
        public ClientPOP3()
        { 
            InitializeComponent();

            Connexion();
        }

        #region Méthodes d'écriture dans les zones d'affichage utilisateur et verbose (debug)
        public void WriteAffichage(string line)
        {
            listBoxAffichage.Items.Add(line);
            // permet "l'auto-scroll" : défiler l'affichage de la fenêtre jusqu'à la dernière ligne
            listBoxAffichage.SelectedIndex = listBoxAffichage.Items.Count - 1;
            listBoxAffichage.SelectedIndex = -1;
        }

        public void WriteMessage(string line)
        {
            displayMessage.Text += line + Environment.NewLine;

        }

        public void WriteVerbose(string line)
        {
            listBoxVerbose.Items.Add(line);
            // permet "l'auto-scroll" : défiler l'affichage de la fenêtre jusqu'à la dernière ligne
            listBoxVerbose.SelectedIndex = listBoxVerbose.Items.Count - 1;
            listBoxVerbose.SelectedIndex = -1;
        }
        #endregion

        private void ButtonQUIT_Click(object sender, EventArgs e)
        {
            Communication.Quit();
            MessageBox.Show("Fin du client");
            this.Dispose();
        }

        private void ButtonSTAT_Click(object sender, EventArgs e)
        {
            Communication.Stat();
        }

        private void ButtonLIST_Click(object sender, EventArgs e)
        {
            Communication.List();
        }

        public bool getCheckBoxExpediteur()
        {
            return checkBoxExpediteur.Checked;
        }

        public bool getCheckBoxDate()
        {
            return checkBoxDate.Checked;
        }

        public bool getCheckBoxSujet()
        {
            return checkBoxSujet.Checked;
        }

        private void decoButton_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            Connexion();
        }

        private void Connexion()
        {
            Connexion connexion = new Connexion();
            if (connexion.ShowDialog() == DialogResult.OK)
            {
                Preferences.username = connexion.Identifiant;
                Preferences.password = connexion.MotDePasse;
            }
            else
            {
                Dispose();
            }

            /* Connexion au serveur POP3 */
            Communication.Initialise(this);

            /* Identification */
            Communication.Identification();

            /* envoi STAT pour recuperer nb messages */
            Communication.Stat();

            Opacity = 100;

        }

        private void listBoxAffichage_Click(object sender, EventArgs e)
        {
            displayMessage.Clear();
            if (listBoxAffichage.SelectedItems.Count > 0)
            {
                string ligne = (string)listBoxAffichage.SelectedItem;
                if (ligne.Substring(0, 8).Equals("Message "))
                {
                    int num = int.Parse(ligne.Substring(8, ligne.Length - 8));
                    Communication.Retr(num, true);
                }

            }
        }
    }
}
