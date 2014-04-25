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
using System.Windows.Shapes;

namespace GuiTest1
{
    /// <summary>
    /// Interaction logic for Window_dimension.xaml
    /// </summary>
    public partial class Window_dimension : Window
    {
        
        public Window_dimension()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            int valX = Convert.ToInt16(dimensionX.Text);
            int valY = Convert.ToInt16(dimensionY.Text);
            Window1 creator = new Window1(valX,valY);
            creator.Show();
            
            
        }
    }
}
