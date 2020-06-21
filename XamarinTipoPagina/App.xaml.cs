using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTipoPagina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoPagina.Carrousel.Introducao();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
