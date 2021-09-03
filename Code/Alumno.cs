using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUWP
{
    public enum Sexo { Hombre, Mujer }
    public enum Titulacion { Informatica, ADET, DobleGrado }
    public class Alumno
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public int Sexo { get; set; }
        public int Titulacion { get; set; }

        public List<Actividad> ListaActividadesAlumno = new List<Actividad>();

        public Alumno(string dni, string nombre, string apellidos, string email, int sexo, int titulacion)
        {
            Dni = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Sexo = sexo;
            Titulacion = titulacion;
        }

        public Alumno() { }
    }
}
