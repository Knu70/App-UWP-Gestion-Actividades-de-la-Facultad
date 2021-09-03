using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            this.InitializeComponent();

            listadoActividades.ItemsSource = App.ListaActividades;
        }
        private void AppBarButton_Click_Back(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
        

        async private void AppBarButton_Click_Save(object sender, RoutedEventArgs e)
        {
            
            Alumno alumno = new Alumno();
            alumno.Dni = cajaDni.Text;
            alumno.Nombre = cajaNombre.Text;
            alumno.Apellidos = cajaApellidos.Text;
            alumno.Email = cajaEmail.Text;

            if (botonHombre.IsChecked == true)
            {
                alumno.Sexo = (int)Sexo.Hombre;
            }
            else if (botonMujer.IsChecked == true)
            {
                alumno.Sexo = (int)Sexo.Mujer;
            }
            if (botonInformatica.IsChecked == true)
            {
                alumno.Titulacion = (int)Titulacion.Informatica;
            }
            else if (botonAdet.IsChecked == true)
            {
                alumno.Titulacion = (int)Titulacion.ADET;
            }
            else if (botonDobleGrado.IsChecked == true)
            {
                alumno.Titulacion = (int)Titulacion.DobleGrado;
            }

   
            alumno.ListaActividadesAlumno.Add((Actividad)listadoActividades.SelectedItem);

            App.ListaAlumnos.Add(alumno);

            MessageDialog md = new MessageDialog("Has inscrito un alumno en una actividad", "Inscrito");
            await md.ShowAsync();

            limpiar();
        }

        private void limpiar()
        {
            cajaDni.Text = String.Empty;
            cajaNombre.Text = String.Empty;
            cajaApellidos.Text = String.Empty;
            cajaEmail.Text = String.Empty;
            botonHombre.IsChecked = false;
            botonMujer.IsChecked = false;
            botonInformatica.IsChecked = false;
            botonAdet.IsChecked = false;
            botonDobleGrado.IsChecked = false;
           listadoActividades.SelectedItems.Clear();
        }

        private void AppBarButton_Click_Clear(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        
    }
}
