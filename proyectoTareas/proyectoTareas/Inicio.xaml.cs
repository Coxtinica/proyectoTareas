
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace proyectoTareas
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public async void sesion(object sender, object args)
        {
            bool authenticated = false;

            if (App.Authenticator != null)
            {
                authenticated = await App.Authenticator.Authenticate();
            }

            if (authenticated == true)
            {
                App.Current.MainPage = new NavigationPage(new visualizarTarea());

            }
        }
    }
}
