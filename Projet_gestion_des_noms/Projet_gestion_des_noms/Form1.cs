using System;
using System.Windows.Forms;

namespace Projet_gestion_des_noms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string noms = textBox1.Text;

            // MessageBox.Show($"Vous êtes : {noms}", "NOM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!listNoms.Items.Contains(noms))
            {
                listNoms.Items.Add(noms);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("L'élément est déjà dans la liste.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
