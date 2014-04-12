using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using System.Collections.ObjectModel;

namespace GuiTest1
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            _moveEvents = new ObservableCollection<MoveEvent>(MoveEvent.GetRandomMoveEvents());
        }

        public ObservableCollection<MoveEvent> Nodes
        {
            get { return _moveEvents ?? (_moveEvents = new ObservableCollection<MoveEvent>()); }
        }

        private ObservableCollection<MoveEvent> _moveEvents;
    }
}
