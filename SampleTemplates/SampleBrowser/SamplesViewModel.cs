using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser
{
    public class SamplesViewModel
    {
        public List<ControlType> ControlTypes { get; set; }
        public ObservableCollection<SampleInfo> Samples { get; set; }

        public SamplesViewModel()
        {
            Samples = new ObservableCollection<SampleInfo>();
            ControlTypes = Enum.GetValues(typeof(ControlType)).Cast<ControlType>().ToList();
        }

        
        public void PopulateXamDataGridSamples()
        {
            Samples.Clear();
            Samples.Add(new SampleInfo() { Name = "XDGHeterogeneous", UserControlType = typeof(XDGHeterogeneous) });
            Samples.Add(new SampleInfo() { Name = "XDGHomogeneous", UserControlType = typeof(XDGHomogeneous) });
            Samples.Add(new SampleInfo() { Name = "XDGStandard", UserControlType = typeof(XDGStandard) });
            Samples.Add(new SampleInfo() { Name = "XDGWithCombo", UserControlType = typeof(XDGWithCombo) });
        }

        public void PopulateXamGridSamples()
        {
            Samples.Clear();
            Samples.Add(new SampleInfo() { Name = "XamGridHeterogeneous", UserControlType = typeof(XamGridHeterogeneous) });
            Samples.Add(new SampleInfo() { Name = "XamGridHomogeneous", UserControlType = typeof(XamGridHomogeneous) });
            Samples.Add(new SampleInfo() { Name = "XamGridStandard", UserControlType = typeof(XamGridStandard) });
            Samples.Add(new SampleInfo() { Name = "XamGridWithCombo", UserControlType = typeof(XamGridWithCombo) });
        }

        public void PopulateXamDataChartSamples()
        {
            Samples.Clear();
            Samples.Add(new SampleInfo() { Name = "XamDataChartBubbleSeries", UserControlType = typeof(XamDataChartBubbleSeries) });
            Samples.Add(new SampleInfo() { Name = "XamDataChartCategorySeries", UserControlType = typeof(XamDataChartCategorySeries) });
            Samples.Add(new SampleInfo() { Name = "XamDataChartScatterSeries", UserControlType = typeof(XamDataChartScatterSeries) });
            Samples.Add(new SampleInfo() { Name = "XamDataChartStackedSeriesGroupBy", UserControlType = typeof(XamDataChartStackedSeriesGroupBy) });
            Samples.Add(new SampleInfo() { Name = "XamDataChartStackedSeriesManual", UserControlType = typeof(XamDataChartStackedSeriesManual) });
        }

        public void PopulateXamPivotGridSamples()
        {
            Samples.Clear();
            Samples.Add(new SampleInfo() { Name = "XamPivotGridFlatData", UserControlType = typeof(XamPivotGridFlatData) });
        }
    }

    public enum ControlType
    {
        XamDataChart,
        XamDataGrid,
        XamGrid,
        XamPivotGrid            
    }

    public class SampleInfo
    {
        public string Name { get; set; }
        public Type UserControlType { get; set; }
    }
}
