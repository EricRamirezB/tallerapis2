using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionPage : ContentPage
	{
		public PublicacionPage ()
		{
			InitializeComponent ();
            CargarPublicacion();
        }

        private void CargarProductos()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://mitiendaapis.azurewebsites.net");
            var request = client.GetAsync("/api/publicacion");

            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listProductos.ItemsSource = response;
            }

        }


        //private async void PublicacionSeleccionado(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var producto = e.SelectedItem as Publicacion;
        //    string mensaje = string.Format("Publicacion : {0} - Cantidad : {1}", producto.Nombre, producto.Cantidad);
        //    await DisplayAlert("Producto seleccionado", mensaje, "Ok");
        //}
    }
}