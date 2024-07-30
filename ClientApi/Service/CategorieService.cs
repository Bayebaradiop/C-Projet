using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ClientApi.Model;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

namespace ClientApi.Service
{
    public class CategorieService
    {
        public List<Categorie> ServGetListCategorie()
        {
            var services = new List<Categorie>();

            try
            {
                // Forcer l'utilisation de TLS 1.2
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Désactiver la validation des certificats SSL (à des fins de test uniquement)
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

                using (HttpClient client = new HttpClient(handler))
                {
                    var baseAddress = ConfigurationSettings.AppSettings["Linkserveur"];
                    if (string.IsNullOrEmpty(baseAddress))
                    {
                        throw new Exception("Base address is not configured in app settings.");
                    }

                    Console.WriteLine("Base address: " + baseAddress);

                    client.BaseAddress = new Uri(baseAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("groupe2/Categories/GetCategorie").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = response.Content.ReadAsStringAsync().Result;
                        services = JsonConvert.DeserializeObject<List<Categorie>>(responseData);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to get categories. Status code: {response.StatusCode}");
                        throw new Exception($"Failed to get categories. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException httpRequestEx)
            {
                Console.WriteLine($"HttpRequestException: {httpRequestEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }

            return services;
        }
    }
}
