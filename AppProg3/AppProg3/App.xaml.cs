using AppProg3.Services;
using AppProg3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProg3
{
    public partial class App : Application
    {

        public App()
        {
            //test
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
