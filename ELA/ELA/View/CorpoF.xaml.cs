using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ELA.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CorpoF : ContentPage
    {
        public CorpoF()
        {
            InitializeComponent();
        }

        private  void Cabeca_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua cabeça esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");
            
        }

        private void Peito_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu Peito esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void Barriga_Clicked(object sender, EventArgs e)
        {

            DisplayActionSheet("Sua barriga esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");
        }

        private void PernaDireita_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua Perna esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void JoelhoDireita_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void CanelaDireita_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua canela esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void PeDireita_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void PernaEsquerda_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua perna esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void JoelhoEsquerda_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu joelho esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void CanelaEsquerda_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua canela esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void PeEsquerda_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu pé esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void BracoEsquedo_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void AnteBracoEsquedo_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void MaoEsquedo_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void BracoDireito_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu braço esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void AnteBracoDireito_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Seu antebraço esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }

        private void MaoDireito_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sua mão esta?", "Cancel", null, "Doendo ", "Coçando", "Dormente");

        }
    }
}