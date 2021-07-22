using System;

namespace ApplicationCore.Entities
{
    public class GlobalSummary
    {
        public long NewConfirmed { get; set; }
        public long TotalConfirmed { get; set; }
        public long NewDeaths { get; set; }
        public long TotalDeaths { get; set; }
        public long NewRecovered { get; set; }
        public long TotalRecovered { get; set; }
        public DateTime Date { get; set; }
    }
}