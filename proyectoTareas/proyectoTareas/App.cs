using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace proyectoTareas
{
    public class App : Application
    {
        public static login Authenticator { get; private set; }

        public static MobileServiceClient client = new MobileServiceClient(Conexion.conn);

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new Inicio())
            {

            };

        /* MainPage = new NavigationPage(new visualizarTarea())
            {

            };*/

        }

        public interface login
        {
            Task<bool> Authenticate();
        }

        public static void Init(login authenticator)
        {
            Authenticator = authenticator;
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
