using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSharedMemory.ServiceMetier;
using AppSharedMemory;
using Newtonsoft.Json;

namespace AppSharedMemory
{
    public partial class Form1 : Form
    {

        Service1Client serv;

        public Form1()
        {
            serv = new Service1Client("BasicHttpBinding_IService1");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //dgJury.DataSource = servGetListJury();
                dgJury.DataSource = serv.GetJurys();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }


        }

        private void dgJury_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Cette methode permet d'ajouter un jury via le bouton ajouter du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ServiceMetier.Jury jury = new ServiceMetier.Jury();
            jury.Prenom = txtPrenom.Text;
            jury.Nom = txtNom.Text;
            jury.Grade = txtGrade.Text;
            jury.Specialite = txtSpecialite.Text;
            serv.AddJury(jury);
            Effacer();
        }

        /// <summary>
        /// cette methode permet de vider les champs des textBox
        /// </summary>


        public void Effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtSpecialite.Text = string.Empty;
            dgJury.DataSource = serv.GetJurys();
            txtNom.Focus();
        }


        /// <summary>
        /// Cette methode permet de modifier un jury via le bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgJury.CurrentRow != null)
            {
                if (int.TryParse(dgJury.CurrentRow.Cells[2].Value?.ToString(), out int idPersonne))
                {
                    ServiceMetier.Jury jury = new ServiceMetier.Jury
                    {
                        IdPersonne = idPersonne,
                        Nom = txtNom.Text,
                        Prenom = txtPrenom.Text,
                        Grade = txtGrade.Text,
                        Specialite = txtSpecialite.Text
                    };
                    serv.EditJury(jury);
                    Effacer();
                }
                else
                {
                    MessageBox.Show("L'ID de la personne est invalide.");
                }
            }
        }

        /// <summary>
        /// cette methode permet de selectionner les donnees du tableau et les mettent respectivement  dans les textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgJury.CurrentRow.Cells[3].Value.ToString();
            txtPrenom.Text = dgJury.CurrentRow.Cells[4].Value.ToString();
            txtGrade.Text = dgJury.CurrentRow.Cells[0].Value.ToString();
            txtSpecialite.Text = dgJury.CurrentRow.Cells[1].Value.ToString();
        }

        /// <summary>
        /// cette methode permet de supprimer un jury via le bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgJury.CurrentRow != null)
            {
                if (int.TryParse(dgJury.CurrentRow.Cells[2].Value?.ToString(), out int juryId))
                {
                    serv.DeleteJury(juryId);
                    Effacer();
                }
                else
                {
                    MessageBox.Show("L'ID de la personne est invalide.");
                }
            }
        }
    }
}
