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

namespace MouseMover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Mover _mouseMOver;

        public MainWindow()
        {
            InitializeComponent();
            _mouseMOver = new Mover();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _mouseMOver.Enable();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            _mouseMOver.Disable();
        }
    }
}
