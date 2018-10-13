using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BotonPublicacionPage : ContentPage
	{
		public BotonPublicacionPage ()
		{
			InitializeComponent ();
            CargarProductos();
        }

        private void CargarProductos()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://mitiendaapis.azurewebsites.net");
            var request = client.GetAsync("/api/publicacion");

            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Producto>>(responseJson);
                listProductos.ItemsSource = response;
            }

        }

        private async void ProductoSeleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = e.SelectedItem as Producto;
            string mensaje = string.Format("Producto : {0} - Cantidad : {1}", producto.Nombre, producto.Cantidad);
            await DisplayAlert("Producto seleccionado", mensaje, "Ok");
        }
    }
}