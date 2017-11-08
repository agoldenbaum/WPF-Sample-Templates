using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class GridViewModel
    {
        public ObservableCollection<SampleGridData> Data { get; set; }
        public string[] names = "Andrew;Alex;Jen;Steve;Eric;Tom;Devin;Emilie;Mike;Rob;Pamela;Valerie;Michelle;Trish".Split(';');
        public Random r = new Random();
        public GridViewModel()
        {
            FillData();                                                                            
        }

        public void FillData()
        {
            Data = new ObservableCollection<SampleGridData>();

            for(int i=0; i < names.Length; i++)
            {
                Data.Add(new SampleGridData()
                {
                    ID = i,
                    Name = names[i],
                    Number = r.Next(1000),
                    Date = DateTime.Today.AddDays(i)
                });
            }
        }
    }
    public class GridViewModelComboModel : GridViewModel
    {
        public List<string> ComboData { get; set; }

        public GridViewModelComboModel() : base()
        {            
            ComboData = names.ToList();
        }
    }
    public class GridHierarchyHomogeneousModel : GridViewModel
    {        
        public ObservableCollection<HomogenousGridData> HomogeneousData { get; set; }
        public GridHierarchyHomogeneousModel()
        {
            FillHomogenousData();   
        }

        private void FillHomogenousData()
        {            
            HomogeneousData = new ObservableCollection<HomogenousGridData>();
            for (int i = 0; i < names.Length / 2; i++)
            {
                HomogenousGridData item = new HomogenousGridData() { ID = i, Name = names[i], Number = r.Next(1000), Date = DateTime.Today.AddDays(i) };
                item.Children = new ObservableCollection<HomogenousGridData>();

                for (int j = 0; j < 3; j++)
                {
                    item.Children.Add(new HomogenousGridData() { ID = j, Name = names[r.Next(names.Length)], Number = r.Next(1000), Date = DateTime.Today.AddMonths(j) });
                }
                HomogeneousData.Add(item);
            }
        }
    }
    public class GridHierarchyHeterogeneousModel : GridViewModel
    {        
        public ObservableCollection<HeterogenousGridData> HeterogeneousData { get; set; }
        public GridHierarchyHeterogeneousModel()
        {
            FillHeterogeneousData();
        }

        private void FillHeterogeneousData()
        {
            HeterogeneousData = new ObservableCollection<HeterogenousGridData>();
            for (int i = 0; i < names.Length; i++)
            {
                HeterogeneousData.Add(new HeterogenousGridData() { ID = i, Name = names[i], Number = r.Next(1000), Date = DateTime.Today.AddDays(i) });
            }        
        }
    }
}
