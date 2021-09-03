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
    public sealed partial class ShowPage : Page
    {
        public ShowPage()
        {
            this.InitializeComponent();
            listadoActividades.ItemsSource = App.ListaActividades;
        }
        private void AppBarButton_Click_Back(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        private void listadoActividades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Alumno> lista = new List<Alumno>();
            ListView miListView = (ListView)sender;
            foreach (Alumno a in App.ListaAlumnos)
            {
                foreach(Actividad ac in a.ListaActividadesAlumno)
                {
                    if (ac.Titulo.Equals(((Actividad)miListView.SelectedItem).Titulo))
                    {
                        lista.Add(a);
                    }
                }
                
            }
            listadoAlumnos.ItemsSource = lista;
        }

        private void listadoAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame.Navigate(typeof(ShowStudentPage), (sender as ListView).SelectedItem as Alumno);
        }
    }
}
