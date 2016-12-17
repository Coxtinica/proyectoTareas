using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace proyectoTareas
{
    public partial class modificarTarea : ContentPage
    {
        private DeviceUser deviceUser;
        private tareas tarea;


        public modificarTarea(DeviceUser deviceUser, tareas tarea)
        {
            InitializeComponent();
            this.deviceUser = deviceUser;
            this.tarea = tarea;

            cargarPicker();

            modific.Clicked += actualizartareas;
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



        private async void actualizartareas(object sender, EventArgs e)
        {
            IMobileServiceTable<tareas> tabla;
            tabla = App.client.GetTable<tareas>();

            IEnumerable<tareas> items = await tabla
                .ToEnumerableAsync();

            string[] arreglo = new string[items.Count()];
            string[] arreglo2 = new string[items.Count()];
            string[] ids = new string[items.Count()];
            string[] arreglo3 = new string[items.Count()];
            DateTime[] arreglo4 = new DateTime[items.Count()];
            string[] arreglo5 = new string[items.Count()];
            string[] arreglo6 = new string[items.Count()];
            int i = 0;

            foreach (var x in items)
            {
                

                arreglo[i] = x.Title;
                arreglo2[i] = x.Responsible;
                arreglo3[i] = x.Priority;
                arreglo4[i] = x.Date;
                ids[i] = x.Id;
                arreglo5[i] = x.Estatus;
                arreglo6[i] = x.Description;


                if (x.Title == titulo1.Text)
                {
                    if (x.Responsible != responsable1.Items[prioridad1.SelectedIndex])
                    {
                        x.Responsible = responsable1.Items[prioridad1.SelectedIndex];
                    }
                    if (x.Priority != prioridad1.Items[prioridad1.SelectedIndex])
                    {
                        x.Priority = prioridad1.Items[prioridad1.SelectedIndex];
                    }
                    if (x.Date != fecha1.Date)
                    {
                        x.Date = fecha1.Date;
                    }
                    if (x.Estatus != status1.Items[prioridad1.SelectedIndex])
                    {
                        x.Estatus = status1.Items[prioridad1.SelectedIndex];
                    }
                    if (x.Description != descripcion1.Text)
                    {
                        x.Description = descripcion1.Text;
                    }
                    await tabla.UpdateAsync(x);
                }
                i++;
            }

        }
    }   

    }

