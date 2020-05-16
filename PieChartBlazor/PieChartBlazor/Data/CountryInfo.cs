using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace PieChartBlazor.Data
{
    public class CountryInfo
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int TotalCases { get; set; } = 0;
        public int TotalDeaths { get; set; } = 0;
        public string DeathPercentage => (this.TotalDeaths * 100) / this.TotalCases + "%";

        public List<CountryInfo> GetCountryInfos()
        {
            var countryInfos = new List<CountryInfo>();

            countryInfos.Add(new CountryInfo() { Id = 1, Name = "USA", TotalCases = 142178, TotalDeaths = 2484 });
            countryInfos.Add(new CountryInfo() { Id = 2, Name = "Italy", TotalCases = 97845, TotalDeaths = 10779 });
            countryInfos.Add(new CountryInfo() { Id = 3, Name = "China", TotalCases = 81470, TotalDeaths = 3304 });
            countryInfos.Add(new CountryInfo() { Id = 4, Name = "Spain", TotalCases = 80110, TotalDeaths = 6484 });
            countryInfos.Add(new CountryInfo() { Id = 5, Name = "Germany", TotalCases = 30435, TotalDeaths = 584 });
            countryInfos.Add(new CountryInfo() { Id = 6, Name = "France", TotalCases = 40174, TotalDeaths = 2606 });
            countryInfos.Add(new CountryInfo() { Id = 7, Name = "Iran", TotalCases = 38309, TotalDeaths = 2640 });

            return countryInfos;
        }
    }
}
