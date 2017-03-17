using MaSolution.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaSolution4.Crud
{
    public partial class MainForm : Form
    {
        MaSolution4.Crud.Dtc.PersonneManager _PersonneManager = null;

        //public object PersonneListBox { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }
        private void AjouterPersonneButton_Click(object sender, EventArgs e)
        {
            PersonneDetailForm personneDetailForm = new PersonneDetailForm();
            personneDetailForm.ShowDialog();
        }
        private void ModifierButton_Click(object sender, EventArgs e)
        {
            PersonneDetailForm personneDetailForm = new PersonneDetailForm();
            personneDetailForm.ShowDialog();
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            if (PersonneListBox.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Etês vous sur de vouloir supprimer cette personne ?",
                                     "Confi rmation de suppression!!",
                                     MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    _PersonneManager.Delete((MaSolution4.Crud.Dtc.Personne)PersonneListBox.SelectedItem);
                    ListBoxPersonneInitialize();
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une personne");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _PersonneManager = new MaSolution4.Crud.Dtc.PersonneManager();
            _PersonneManager.Add(new MaSolution4.Crud.Dtc.Personne
            {
                Nom = "Nom 1",
                Prenom = "Prenom1",
                DateNaissance = DateTime.Now
            });
            ListBoxPersonneInitialize();
        }
        private void ListBoxPersonneInitialize()
        {
            List<MaSolution4.Crud.Dtc.Personne> personnes = _PersonneManager.GetPersonnes();
            PersonneListBox.Items.Clear();
            foreach (var item in personnes)
            {
                PersonneListBox.Items.Add(item);
            }
        }
    }
}
