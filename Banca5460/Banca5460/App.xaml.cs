using Banca5460.View5460;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Banca5460
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RUser5460());
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
