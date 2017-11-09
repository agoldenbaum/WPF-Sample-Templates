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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SamplesViewModel svm = new SamplesViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = svm;
        }

        private void controlCombo_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            switch ((ControlType)e.NewValue)
            {
                case ControlType.XamDataChart:
                    svm.PopulateXamDataChartSamples();
                    break;
                case ControlType.XamDataGrid:
                    svm.PopulateXamDataGridSamples();
                    break;
                case ControlType.XamGrid:
                    svm.PopulateXamGridSamples();
                    break;
                case ControlType.XamPivotGrid:
                    svm.PopulateXamPivotGridSamples();
                    break;
            }  
        }

        private void sampleCombo_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {            
            UserControl uc = Activator.CreateInstance(((SampleInfo)e.NewValue).UserControlType) as UserControl;
            userControlContainer.Children.Clear();
            userControlContainer.Children.Add(uc);
            GC.Collect();
        }
    }
}
