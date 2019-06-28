using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.TextToSpeech;

namespace ELA.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Fala : ContentPage
	{
		public Fala ()
		{
			InitializeComponent ();
		}

        private async void Falar_Clicked(object sender, EventArgs e)
        {
            var x = texto.Text;
            await CrossTextToSpeech.Current.Speak(x);

        }
    }
}