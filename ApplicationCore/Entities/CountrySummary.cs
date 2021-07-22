using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class CountrySummary
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public DateTime Date { get; set; }
        public string Id { get; set; }
        public long newConfirmed { get; set; }
        public long newDeaths { get; set; }
        public long newRecovered { get; set; }
        public string Slug { get; set; }
        public long TotalConfirmed { get; set; }
        public long TotalDeaths { get; set; }
        public long TotalRecovered { get; set; }
    }
}
