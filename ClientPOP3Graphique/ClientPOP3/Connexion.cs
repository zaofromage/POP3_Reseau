using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPOP3
{
    public partial class Connexion : Form
    {
        private bool passHide = true;
        public string Identifiant { get { return identifiant.Text; } }

        public string MotDePasse { get { return mdp.Text; } }

        public Connexion()
        {
            InitializeComponent();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            passHide = !passHide;
            if (!passHide)
            {
                hide.Font = new Font(hide.Font, FontStyle.Bold);
                mdp.PasswordChar = '\0';
            }
            else
            {
                hide.Font = new Font(hide.Font, FontStyle.Regular);
                mdp.PasswordChar = '*';
            }
        }
    }
}
