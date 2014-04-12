using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GuiTest1
{
    public class MoveEvent: ViewModelBase
    {
        public static Random random = new Random();

        private Point _location;
        public double Left 
        {
            get { return _location.X; }
            set { _location.X = value; }
        }
        public double Top
        {
            get { return _location.Y; }
            set { _location.Y = value; }
        }

        public static MoveEvent GetRandomMoveEvent()
        {
            var moveEvent = new MoveEvent{ _location= new Point(random.Next(0,100), 0)};
            return moveEvent;
        }
        public static IEnumerable<MoveEvent> GetRandomMoveEvents()
        {

            return Enumerable.Range(5, random.Next(6, 10)).Select(x => GetRandomMoveEvent());
        }
    }
}
