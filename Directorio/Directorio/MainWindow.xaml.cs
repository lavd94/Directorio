using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Directorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void a_click(object sender, RoutedEventArgs e)
        {
            ClassLibrary1.Personas Per = new ClassLibrary1.Personas();
            dataGrid1.DataContext= Per.datosPersona();
            
        }

        private void button1_Personas(object sender, RoutedEventArgs e)
        {
            ClassLibrary1.Personas p = new ClassLibrary1.Personas();
            listBox1.Items.Add(p.ListarPersonas());
   

  
        }
    }
}
