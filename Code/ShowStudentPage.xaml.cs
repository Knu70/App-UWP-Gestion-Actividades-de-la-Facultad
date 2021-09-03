using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace practicaUWP
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ShowStudentPage : Page
    {
        public ShowStudentPage()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click_Back(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                Alumno a = (e.Parameter as Alumno);
                cajaDni.Text = a.Dni;
                cajaNombre.Text = a.Nombre;
                cajaApellidos.Text = a.Apellidos;
                cajaEmail.Text = a.Email;

                if (a.Sexo == 0)
                {
                    cajaSexo.Text = "Hombre";
                }
                else if (a.Sexo == 1)
                {
                    cajaSexo.Text = "Mujer";
                }

                if (a.Titulacion == 0)
                {
                    cajaTitulacion.Text = "Informatica";
                }
                else if (a.Titulacion == 1)
                {
                    cajaTitulacion.Text = "ADET";
                }
                else if (a.Titulacion == 2)
                {
                    cajaTitulacion.Text = "Doble Grado";
                }

                listadoActividades.ItemsSource = a.ListaActividadesAlumno;
            }
        }
    }
}
