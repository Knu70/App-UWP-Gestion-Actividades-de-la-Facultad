using System;
using System.Collections.Generic;
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
    public sealed partial class SearchPage : Page
    {
        public SearchPage()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click_Back(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
        async private void Click_Search(object sender, RoutedEventArgs e)
        {
            bool encontrado = false;
            List<Alumno> lista = new List<Alumno>();
            etiquetaDatos.Text = "Datos";
            etiquetaActividades.Text = "Actividades";
            foreach (Alumno a in App.ListaAlumnos)
            {
                if (a.Dni.Equals(cajaBusqueda.Text))
                {
                    encontrado = true;
                    lista.Add(a);
                    listadoActividades.ItemsSource = a.ListaActividadesAlumno;
                   
                }
            }
            if (encontrado == false)
            {
                MessageDialog md = new MessageDialog("El corredor no esta inscrito", "Error");
                await md.ShowAsync();
                limpiar();
            }

            listadoAlumnos.ItemsSource = lista;
        }
        private void limpiar()
        {
            cajaBusqueda.Text = string.Empty;
            etiquetaActividades.Text = String.Empty;
            etiquetaDatos.Text = String.Empty;
            listadoAlumnos.ItemsSource = App.ListaVaciaLimpiar;
            listadoActividades.ItemsSource = App.ListaVaciaLimpiar;
        }
        private void AppBarButton_Click_Clear(object sender, RoutedEventArgs e)
        {
            limpiar();
        }
    }
}
