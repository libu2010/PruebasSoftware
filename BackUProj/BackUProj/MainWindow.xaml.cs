using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BackUProj.Properties;

namespace BackUProj
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Datos.menu = menu;
            Datos.cambiarVisibilidadMenu();
            Datos.repositorio_actual = 0;
            frame_principal.NavigationService.Navigate(new LoginPage());
            Datos.ventana = this;
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            frame_principal.NavigationService.Navigate(new ConfiguracionPage());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frame_principal.NavigationService.Navigate(new RepositoriosPage());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            frame_principal.NavigationService.Navigate(new UnirseARepositorioPage());
        }
    }

    public class UsuarioLogueado
    {
        public usuario usuario { get; set; }
        
    }

}
