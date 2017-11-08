using IG_WPF_Library.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class ScatterViewModel
    {
        public ObservableCollection<ScatterDataBase> ScatterSource { get; set; }
        public ObservableCollection<ScatterBubbleData> BubbleSource { get; set; }

        Random r = new Random();
        public ScatterViewModel()
        {
            ScatterSource = new ObservableCollection<ScatterDataBase>();
            BubbleSource = new ObservableCollection<ScatterBubbleData>();

            for(int i=1; i<=3; i++)
            {
                BubbleSource.Add(new ScatterBubbleData() { X = 20, Y = (20 * i), Radius = 10 * i });
                BubbleSource.Add(new ScatterBubbleData() { X = 40, Y = (20 * i), Radius = 10 * i });
                BubbleSource.Add(new ScatterBubbleData() { X = 60, Y = (20 * i), Radius = 10 * i });
            }

            for(int i=0; i<50; i++)
            {
                ScatterSource.Add(new ScatterDataBase() { X = r.Next(50), Y = r.Next(50) });
            }
        }
    }
}
