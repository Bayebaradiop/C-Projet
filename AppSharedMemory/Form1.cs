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


        public List<Jury> servGetListJury()
        {
            HttpClient client;
            client = new HttpClient();
            var services = new List<Jury>();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["ServeurApiUrl"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("appShared/values/GetListJury").Result;

            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                services = JsonConvert.DeserializeObject<List<Jury>>(responseData);
            }
            return services;
        }


        private void dgJury_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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




        public void Effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtSpecialite.Text = string.Empty;
            dgJury.DataSource = serv.GetJurys();
            txtNom.Focus();
        }
    }
}
