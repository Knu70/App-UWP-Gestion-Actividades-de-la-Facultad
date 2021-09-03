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
    public sealed partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click_Back(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }

        async private void AppBarButton_Click_Save(object sender, RoutedEventArgs e)
        {
            Actividad actividad = new Actividad();
            actividad.Titulo = cajaTitulo.Text;
            actividad.Aula = cajaAula.Text;
            actividad.Fecha = new DateTime(pickerFecha.Date.Year, pickerFecha.Date.Month, pickerFecha.Date.Day);
            actividad.Hora = pickerHora.Time;

            App.ListaActividades.Add(actividad);

            MessageDialog md = new MessageDialog("Has añadido una actividad", "Añadir");
            await md.ShowAsync();

            limpiar();
        }

        private void limpiar()
        {
            cajaTitulo.Text = String.Empty;
            cajaAula.Text = string.Empty;
            pickerFecha.Date = new DateTime(1990, 1, 1);
            pickerHora.Time = new TimeSpan();
        }

        private void AppBarButton_Click_Clear(object sender, RoutedEventArgs e)
        {
            limpiar();
        }
    }
}
