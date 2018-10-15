using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.Apis.Models;

namespace ConsumoApi
{
    class Program
    {
        static void Main(string[] args)
        {
            InvocarAPI();
        }

        private static async void InvocarAPIAsync()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://192.168.1.13/MiTeindaApis");
            var request = await client.GetAsync("/api/Publicacion");
            if(request.IsSuccessStatusCode)
            {
                var response = await request.Content.ReadAsStringAsync();
            }
        }

        private static async void InvocarAPI()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://192.168.1.13/MiTeindaApis");
            var request = client.GetAsync("/api/Publicacion").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson =  request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);

                foreach (var item in response)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
