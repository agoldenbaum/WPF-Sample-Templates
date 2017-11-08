using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class EnergyDataSource : ObservableCollection<EnergyProduction>
    {
        public EnergyDataSource()
        {
            this.Add(new EnergyProduction { Region = "America", Country = "Canada", Coal = 400, Oil = 100, Gas = 175, Nuclear = 225, Hydro = 350 });
            this.Add(new EnergyProduction { Region = "Asia", Country = "China", Coal = 925, Oil = 200, Gas = 350, Nuclear = 400, Hydro = 625 });
            this.Add(new EnergyProduction { Region = "Europe", Country = "Russia", Coal = 550, Oil = 200, Gas = 250, Nuclear = 475, Hydro = 425 });
            this.Add(new EnergyProduction { Region = "Asia", Country = "Australia", Coal = 450, Oil = 100, Gas = 150, Nuclear = 175, Hydro = 350 });
            this.Add(new EnergyProduction { Region = "America", Country = "USA", Coal = 800, Oil = 250, Gas = 475, Nuclear = 575, Hydro = 750 });
            this.Add(new EnergyProduction { Region = "Europe", Country = "France", Coal = 375, Oil = 150, Gas = 350, Nuclear = 275, Hydro = 325 });
        }
    } 

    public class EnergyProduction : ObservableModel
    {
        private string _country;
        private string _region;
        private double _nuke;
        private double _coal;
        private double _oil;
        private double _gas;
        private double _hydro;

        public string Country
        {
            get { return _country; }
            set
            {
                if(_country != value)
                {
                    _country = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Region
        {
            get { return _region; }
            set
            {
                if(_region != value)
                {
                    _region = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public double Nuclear
        {
            get { return _nuke; }
            set
            {
                if(_nuke != value)
                {
                    _nuke = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Coal
        {
            get { return _coal; }
            set
            {
                if(_coal != value)
                {
                    _coal = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Oil
        {
            get { return _oil; }
            set
            {
                if(_oil != value)
                {
                    _oil = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Gas
        {
            get { return _gas; }
            set
            {
                if(_gas != value)
                {
                    _gas = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public double Hydro
        {
            get { return _hydro; }
            set
            {
                if(_hydro != value)
                {
                    _hydro = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
