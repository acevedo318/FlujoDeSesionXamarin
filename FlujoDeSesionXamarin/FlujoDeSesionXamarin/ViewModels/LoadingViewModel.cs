using FlujoDeSesionXamarin.Services.Identity;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlujoDeSesionXamarin.ViewModels
{
    class LoadingViewModel : BaseViewModel
    {
        private readonly IIdentityService identityService;
        public LoadingViewModel(IIdentityService identityService = null)
        {
            this.identityService = identityService ?? Locator.Current.GetService<IIdentityService>();
            Init();
        }

        // Called by the views OnAppearing method
        public async void Init()
        {
            //var isAuthenticated = await this.identityService.VerifyRegistration();
            var isAuthenticated = await this.identityService.VerifyRegistration(); ;
            
            if (isAuthenticated)
            {
                await Shell.Current.GoToAsync("//main");
            }
            else
            {
                await Shell.Current.GoToAsync("//LoginPage");
            }
        }
       
    }
}
