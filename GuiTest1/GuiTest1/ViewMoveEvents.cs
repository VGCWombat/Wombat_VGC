using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GuiTest1
{
    class ViewMoveEvents: ObservableCollection<MoveEvent>
    {
        public static Random random = new Random();
        public ViewMoveEvents(): base()
        {
            Add(new MoveEvent(1, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
            Add(new MoveEvent(2, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
            Add(new MoveEvent(3, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
            Add(new MoveEvent(4, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
            Add(new MoveEvent(5, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
            Add(new MoveEvent(6, new Point(random.Next(0, 800), 0), random.Next(20, 200)));
        } 
    }
}
