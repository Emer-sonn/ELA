using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELA.Models;
using Plugin.TextToSpeech;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ELA.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FalaLista : ContentPage
	{
		public FalaLista ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lista.ItemsSource = await App.DBase.Listar();
        }

        async void Adicionar(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entrada.Text))
            {

                await App.DBase.Adicionar(new Texto
                {
                    Frase = entrada.Text
                });
                entrada.Text = string.Empty;
                lista.ItemsSource = await App.DBase.Listar();
            }


        }

        public async void Deletar(object sender, EventArgs s)
        {

            var x = lista.SelectedItem as Texto;
            await App.DBase.Deletar(x);
            lista.ItemsSource = await App.DBase.Listar();

        }

        //private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    //var x = BindingContext as Texto; as 
        //    var texto = e.SelectedItem as Texto;
        //    var t = texto.Frase;
        //    await CrossTextToSpeech.Current.Speak(t);
        //}

        private async void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var texto = e.Item as Texto;
            var t = texto.Frase;
            await CrossTextToSpeech.Current.Speak(t);
        }
    }
}