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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EjemploApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalendarioPage : Page
    {

        List<Carro> listaDeCarros = new List<Carro>();

        public CalendarioPage()
        {
            this.InitializeComponent();
        }

        class Carro
        {
            public Carro(string marca, string color, string matricula, string dueño)
            {
                Marca = marca;
                Color = color;
                Matricula = matricula;
                Dueño = dueño;
            }

            public Carro(string nombreDueño, string telefonoDueño, string marca, string color, string matricula, string dueño)
            {
                NombreDueño = nombreDueño;
                TelefonoDueño = telefonoDueño;
                Marca = marca;
                Color = color;
                Matricula = matricula;
                Dueño = dueño;
            }

            public string NombreDueño { get; set; }
            public string TelefonoDueño { get; set; }
            public string Marca { get; set; }
            public string Color { get; set; }

            public string Matricula { get; set; }

            public string Dueño { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nuevoNombre = name_tb.Text;
            var nuevoTelefono = name_tb.Text;

            var nuevoCarro = new Carro(nuevoNombre, nuevoTelefono, "Toyota", "Rojo", "012345", "Burgos");
            listaDeCarros.Add(nuevoCarro);


            myDataGrid.ItemsSource = null;
            myDataGrid.ItemsSource = listaDeCarros;
           
        }
    }
}
