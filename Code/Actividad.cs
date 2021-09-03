using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUWP
{
    public class Actividad
    {
        public string Titulo { get; set; }
        public string Aula { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public Actividad(string titulo, string aula, DateTime fecha, TimeSpan hora)
        {
            Titulo = titulo;
            Aula = aula;
            Fecha = fecha;
            Hora = hora;
        }
        public Actividad() { }
    }
}
