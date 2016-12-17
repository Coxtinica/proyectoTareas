using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace proyectoTareas
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            save.Clicked += agregartareas;

            cargarPicker();

        }

        private void cargarPicker()
        {
            prioridad1.Items.Add("Alta");
            prioridad1.Items.Add("Media");
            prioridad1.Items.Add("Baja");

            responsable1.Items.Add("Hector Velez");
            responsable1.Items.Add("Robirosa Escobar");
            responsable1.Items.Add("Azucena Coxtinica");

            status1.Items.Add("Creada");
            status1.Items.Add("En ejecucion");
            status1.Items.Add("Completada");
            status1.Items.Add("No completada");
        }


        private async void agregartareas(object sender, EventArgs e)
        {
            IMobileServiceTable<tareas> tabla;
            tabla = App.client.GetTable<tareas>();

            var datos = new tareas { Title = titulo1.Text, Priority=prioridad1.Items[prioridad1.SelectedIndex], Responsible= responsable1.Items[responsable1.SelectedIndex], Estatus=status1.Items[status1.SelectedIndex], Date = fecha1.Date, Description = descripcion1.Text };
            await tabla.InsertAsync(datos);
            IEnumerable<tareas> items = await tabla.ToEnumerableAsync();

            /*string[] arreglo = new string[items.Count()];
            string[] arreglo2 = new string[items.Count()];
            int i = 0;


            foreach (var x in items)
            {
                arreglo[i] = x.Title;
                arreglo2[i] = x.Date;
                //arreglo[i] = x.Lastname;
                i++;
            }
            lista.ItemsSource = arreglo;
            //lista2.ItemsSource = arreglo2;
            lista.ItemsSource = arreglo2;
            */
        }
    }
}
