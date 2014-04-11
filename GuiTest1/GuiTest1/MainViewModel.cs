using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;

namespace GuiTest1
{
    class MainViewModel: INotifyPropertyChanged
    {
        #region Collections

        private ObservableCollection<PlatformMoveEvent> _platforms;
        public ObservableCollection<PlatformMoveEvent> Platforms
        {
            get { return _platforms ?? (_platforms = new ObservableCollection<PlatformMoveEvent>()); }
        }

        private TimeLineObject _selectedObject;
        public TimeLineObject SelectedObject
        {
            get
            {
                return _selectedObject;
            }
            set
            {
               //selector?

                _selectedObject = value;
                OnPropertyChanged("SelectedObject");

            }
        }

        #endregion

        

        #region Constructor

        public MainViewModel()
        {
            _platforms = new ObservableCollection<PlatformMoveEvent>(PlatformSource.GetRandomMoves());
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Scrolling support

        private double _areaHeight = 500;
        public double AreaHeight
        {
            get { return _areaHeight; }
            set
            {
                _areaHeight = value;
                OnPropertyChanged("AreaHeight");
            }
        }

        private double _areaWidth = 500;
        public double AreaWidth
        {
            get { return _areaWidth; }
            set
            {
                _areaWidth = value;
                OnPropertyChanged("AreaWidth");
            }
        }

        #endregion
    }
}
