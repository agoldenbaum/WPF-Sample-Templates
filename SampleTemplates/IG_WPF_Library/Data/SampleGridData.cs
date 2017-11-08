using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class SampleGridData : ObservableModel
    {
        private int _id;
        private string _name;
        private double _number;
        private DateTime _date;
        
        public int ID
        {
            get { return _id; }
            set
            {
                if(_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Number
        {
            get { return _number; }
            set
            {
                if(_number != value)
                {
                    _number = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if(_date != value)
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
