using FlujoDeSesionXamarin.Services;
using FlujoDeSesionXamarin.Services.Identity;
using FlujoDeSesionXamarin.Views;
using Splat;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlujoDeSesionXamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeDi();
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        private void InitializeDi()
        {
            Locator.CurrentMutable.RegisterLazySingleton<IIdentityService>(() => new IdentityServiceStub());
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
