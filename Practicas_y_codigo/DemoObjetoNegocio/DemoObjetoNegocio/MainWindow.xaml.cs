using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoObjetoNegocio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona usuario = new Persona("Juan", 30);
        public MainWindow()
        {
            InitializeComponent();


            //nombreTextBox.DataContext = usuario;
            //edadTextBox.DataContext = usuario;

            //PrimerStackPanel.DataContext = usuario;

            this.DataContext = usuario;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Actualiza en C# el objeto usuario, pero no en la VISTA
            usuario.Nombre = "Javier";
            usuario.Edad = 44;

            MessageBox.Show($"En la VISTA, Nombre: {nombreTextBox.Text}, Edad: {edadTextBox.Text}");
            MessageBox.Show("En objeto, Nombre: " + usuario.Nombre + ", Edad: " + usuario.Edad);

        }
    }
}