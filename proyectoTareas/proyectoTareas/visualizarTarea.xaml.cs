using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace proyectoTareas
{
    public partial class visualizarTarea : ContentPage
    {
        public List<tareas> cargar;
        public DeviceUser deviceUser;

        public visualizarTarea()
        {
            InitializeComponent();

            btnAgregar.Clicked += Boton1_Clicked;

            listaTareas.ItemTapped += listaTareas_ItemTapped;

            cargar_tareas();

        }

        private async void listaTareas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tarea = e.Item as tareas;
            await Navigation.PushAsync(new modificarTarea(this.deviceUser, tarea));

        }


        private async void cargar_tareas()
        {
            IMobileServiceTable<tareas> tabla;
            tabla = App.client.GetTable<tareas>();

            cargar = await tabla.ToListAsync();
            listaTareas.ItemsSource = cargar;


        }

        private async void Boton1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
