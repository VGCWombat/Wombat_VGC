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
using System.Windows.Navigation;

using System.Drawing;
using System.Windows.Forms;
 

namespace GuiTest1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        
        public Window1(int dimX, int dimY)
        {
            InitializeComponent();
            System.Drawing.Rectangle workingRectangle =
            Screen.PrimaryScreen.WorkingArea;
            

            double sze = this.ActualWidth;
            System.Windows.Size max = new System.Windows.Size(workingRectangle.Width,workingRectangle.Height-100);
            
            canvas.Measure(max);
            canvas.Arrange(new Rect(0, 0, max.Width, max.Height));
            
            
            System.Windows.Shapes.Rectangle[,] myRectangle = new System.Windows.Shapes.Rectangle[50,50];
            double startUp=0;
            int col = (int)(dimX - (dimX % 1.2) / 1.2);
            int row = (int)(dimY - (dimY % 1.2) / 1.2);
            int wi=(int)((float)dimX / dimY * canvas.ActualHeight);
            int roz = (int)(canvas.ActualWidth - wi)/2;
            //int centerX = canvas.ActualWidth - col * 30;
            //start = centerX;
            double start = (roz);
            double wysokosc = canvas.ActualHeight;
            double szerokosc = canvas.ActualWidth;
            
            Add.Content = startUp;
            Delete.Content = canvas.ActualWidth;
           

            for(int i=0;i<row;i++)

            {   
                for (int j = 0; j < col; j++)
                {
                    myRectangle[i, j] = new System.Windows.Shapes.Rectangle();
                    myRectangle[i,j].Width = (canvas.ActualHeight/row)-2;
                    myRectangle[i, j].Height = (canvas.ActualHeight / row) - 2;
                    SolidColorBrush myBrush = new SolidColorBrush(Colors.Green);
                    myRectangle[i,j].Stroke = System.Windows.Media.Brushes.Red;
                    myRectangle[i,j].StrokeThickness = 4;
                    myRectangle[i,j].Fill = myBrush;
                    canvas.Children.Insert(0, myRectangle[i, j]);
                    Canvas.SetLeft(myRectangle[i, j], start);
                    Canvas.SetTop(myRectangle[i, j], startUp);
                    start = start + myRectangle[i, j].Width+2;
                }
                startUp = startUp + (canvas.ActualHeight / row) -  2;
                start = (roz);
            }
            
        }






        public static double ActualHeightPropertyHeight { get; set; }

        public static double ActualWidthPropertyWidth { get; set; }
    }
}
