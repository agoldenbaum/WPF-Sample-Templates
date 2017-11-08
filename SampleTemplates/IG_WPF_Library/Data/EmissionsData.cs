using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library.Data
{
    public class TestEmissionsCollection
        : ObservableCollection<InstalationEmissionDateInformation>
    {
        public TestEmissionsCollection()
        {
            Add(new InstalationEmissionDateInformation("A", 5, "1/1/2012", 1));
            Add(new InstalationEmissionDateInformation("B", 2, "1/1/2012", 1));
            Add(new InstalationEmissionDateInformation("C", 7, "1/1/2012", 1));
            Add(new InstalationEmissionDateInformation("A", 6, "1/2/2012", 1));
            Add(new InstalationEmissionDateInformation("B", 3, "1/2/2012", 1));
            Add(new InstalationEmissionDateInformation("C", 0, "1/2/2012", 1));
            Add(new InstalationEmissionDateInformation("A", 6, "1/3/2012", 1));
            Add(new InstalationEmissionDateInformation("B", 3, "1/3/2012", 1));
            Add(new InstalationEmissionDateInformation("C", 6, "1/3/2012", 1));
            Add(new InstalationEmissionDateInformation("A", 4, "1/4/2012", 1));
            Add(new InstalationEmissionDateInformation("B", 3, "1/4/2012", 1));
            Add(new InstalationEmissionDateInformation("C", 7, "1/4/2012", 1));
        }
    }

    /// <summary>
    /// The instalation emission date information.
    /// </summary>
    public class InstalationEmissionDateInformation
    {
        public string Installation { get; set; }
        public Decimal Emission { get; set; }
        public string Date { get; set; }
        public Decimal Assignation { get; set; }

        public InstalationEmissionDateInformation(
            string installation,
            Decimal emission,
            string date,
            Decimal assignation)
        {
            Installation = installation;
            Emission = emission;
            Date = date;
            Assignation = assignation;
        }
    }
}
