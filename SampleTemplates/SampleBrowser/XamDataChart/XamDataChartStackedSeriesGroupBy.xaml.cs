using IG_WPF_Library.Data;
using Infragistics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleBrowser
{
    /// <summary>
    /// Interaction logic for XamDataChartStackedSeriesGroupBy.xaml
    /// </summary>
    public partial class XamDataChartStackedSeriesGroupBy : UserControl
    {
        public GroupBy GroupData { get; set; }
        public XamDataChartStackedSeriesGroupBy()
        {
            InitializeComponent();

            TestEmissionsCollection source = new TestEmissionsCollection();

            GroupData = new GroupBy()
            {
                ItemsSource = source,
                KeyMemberPath = "Installation",
                GroupMemberPath = "Date",
                ValueMemberPath = "Emission"
            };

            this.DataContext = this;
        }
    }
}
