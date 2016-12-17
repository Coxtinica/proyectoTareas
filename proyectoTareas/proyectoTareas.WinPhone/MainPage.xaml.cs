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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace proyectoTareas.WinPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
            //this.NavigationCacheMode = NavigationCacheMode.Required;

            LoadApplication(new proyectoTareas.App());
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
