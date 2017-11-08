using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library.Data
{
    public class ScatterDataBase : ObservableModel
    {
        private double _x;
        private double _y;
        
        public double X
        {
            get { return _x; }
            set
            {
                if(_x != value)
                {
                    _x = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                if (_y != value)
                {
                    _y = value;
                    OnPropertyChanged();
                }
            }
        }
    }

    public class ScatterBubbleData : ScatterDataBase
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    OnPropertyChanged();
                }                    
            }
        }
    }
}
