using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class HomogenousGridData : SampleGridData
    {
        private ObservableCollection<HomogenousGridData> _children;
        public ObservableCollection<HomogenousGridData> Children
        {
            get { return _children; }
            set
            {
                if(_children != value)
                {
                    _children = value;
                    OnPropertyChanged();
                }
            }
        }
    }

    public class HeterogenousGridData : SampleGridData
    {
        private ObservableCollection<ChildGridData> _children;
        public ObservableCollection<ChildGridData> Children
        {
            get { return _children; }
            set
            {
                if (_children != value)
                {
                    _children = value;
                    OnPropertyChanged();
                }
            }
        }

        string[] childNames = "Andrew;Alex;Jen;Steve;Eric;Tom;Devin;Emilie;Mike;Rob;Pamela;Valerie;Michelle;Trish".Split(';');
        Random r = new Random();
        public HeterogenousGridData()
        {
            Children = new ObservableCollection<ChildGridData>();

            for(int i=0; i<3; i++)
            {
                Children.Add(new ChildGridData()
                {
                    ChildID = i,
                    ChildAge = r.Next(20, 30),
                    ChildName = childNames[r.Next(childNames.Length)]
                });
            }
        }
    }
}
