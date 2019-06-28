using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using System.IO;
using ELA.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ELA
{
    public partial class App : Application
    {
        static DBase _dbase;
        public static DBase DBase
        {
            get
            {
                if (_dbase == null)
                {
                    _dbase = new DBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ELA.db3"));
                }
                return _dbase;
            }
        }

        public App()
        {
            InitializeComponent();
            CarouselPage x = new CarouselPage();
            x.Children.Add(new FalaLista());
            x.Children.Add(new Fala());
            MainPage = x;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
