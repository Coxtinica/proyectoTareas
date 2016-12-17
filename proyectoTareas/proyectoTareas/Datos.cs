using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace proyectoTareas
{
        public class tareas
        {
            string id;
            string titulo;
            string responsable;
            string prioridad;
            string status;
            string descripcion;



            [JsonProperty(PropertyName = "id")]
            public string Id
            {
                get { return id; }
                set { id = value; }
            }

            [JsonProperty(PropertyName = "Titulo")]
            public string Title
            {
                get { return titulo; }
                set { titulo = value; }
            }


            [JsonProperty(PropertyName = "Responsable")]
            public string Responsible
            {
                get { return responsable; }
                set { responsable = value; }
            }


            [JsonProperty(PropertyName = "Prioridad")]
            public string Priority
            {
                get { return prioridad; }
                set { prioridad = value; }
            }


            [JsonProperty(PropertyName = "Fecha")]
            public DateTime Date
            {
                get;
                set;
            }


            [JsonProperty(PropertyName = "Status")]
            public string Estatus
            {
                get { return status; }
                set { status = value; }
            }

            [JsonProperty(PropertyName = "Descripcion")]
            public string Description
            {
                get { return descripcion; }
                set { descripcion = value; }
            }


            [Version]
            public string Version { get; set; }
        }
    }

