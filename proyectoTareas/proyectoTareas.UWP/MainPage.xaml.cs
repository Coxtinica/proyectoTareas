using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace proyectoTareas.UWP
{
    public sealed partial class MainPage:proyectoTareas.App.login
    {
        private MobileServiceUser user;

        public async Task<bool> Authenticate()
        {
            string message = string.Empty;

            var success = false;
            try
            {
                if (user == null)
                {
                    user = await proyectoTareas.App.client.LoginAsync(MobileServiceAuthenticationProvider.WindowsAzureActiveDirectory);

                    if (user != null)
                    {
                        success = true;
                        await new MessageDialog(user.UserId, "Bienvenido").ShowAsync();
                    }

                }
            }

            catch (Exception ex)
            {
                await new MessageDialog(ex.Message, "Error Message").ShowAsync();
            }

            return success;
        }

        public MainPage()
        {    
            this.InitializeComponent();

            proyectoTareas.App.Init((proyectoTareas.App.login)this);

            LoadApplication(new proyectoTareas.App());
        }
    }
}
