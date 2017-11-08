using IG_WPF_Library;
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
    /// Interaction logic for XamGridStandard.xaml
    /// </summary>
    public partial class XamGridStandard : UserControl
    {
        public XamGridStandard()
        {
            InitializeComponent();
            this.DataContext = new GridViewModel();
        }
    }
}
