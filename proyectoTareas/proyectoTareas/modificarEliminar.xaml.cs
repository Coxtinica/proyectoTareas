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
    public partial class modificarEliminar : ContentPage
    {



        //refresh.Clicked += modificarEliminar;

        //cargarPicker();




        /*private void cargarPicker()
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



        private async void modificartareas(object sender, EventArgs e)
        {

            IEnumerable<tareas> items = await tabla.ToEnumerableAsync();

            string[] arreglo = new string[items.Count()];
            string[] arreglo2 = new string[items.Count()];
            string[] ids = new string[items.Count()];
            string[] arreglo3 = new string[items.Count()];
            int i = 0;

            foreach (var x in items)
            {
                arreglo[i] = x.Name;
                arreglo2[i] = x.Lastname;
                ids[i] = x.Id;
                arreglo3[i] = x.Cellphone;


                if (x.Cellphone == telefono1.Text)
                {
                    if (x.Name != nombre1.Text)
                    {
                        x.Name = nombre1.Text;
                    }
                    if (x.Lastname != apellido1.Text)
                    {
                        x.Lastname = apellido1.Text;
                    }
                    await tabla.UpdateAsync(x);
                }
                i++;
            }

            lista.ItemsSource = arreglo;
            lista2.ItemsSource = arreglo2;


        }*/
        
    }
}
