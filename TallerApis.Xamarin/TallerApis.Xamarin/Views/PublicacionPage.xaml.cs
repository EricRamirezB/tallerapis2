﻿using Newtonsoft.Json;
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
            //CargarPublicacion();
        }

        private async Task CargarProductos()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://192.168.1.13/MiTeindaApis");
            var request = await client.GetAsync("/api/Publicacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicacion.ItemsSource = response;
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