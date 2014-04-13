using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace GuiTest1
{
    public class MoveEvent: ViewModelBase
    {

        private Point location;
        private double lenght;
        private int id;
        public MoveEvent()
        {

        }

        public MoveEvent(int id, Point location, double lenght)
        {
            this.id = id;
            this.lenght = lenght;
            this.location = location;
        }

        public int MoveID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("MoveID");
            }
        }

        public double Lenght
        {
            get { return lenght; }
            set
            {
                lenght = value;
                OnPropertyChanged("Lenght");
            }
        }
        public double Left 
        {
            get { return location.X; }
            set 
            {
                if(value>=0)
                {
                    location.X = value;
                    OnPropertyChanged("Left");
                }
            }
        }
        public double Top
        {
            get { return location.Y; }
            set
            {
                location.Y = value;
                OnPropertyChanged("Top");
            }
        }

    }

}
