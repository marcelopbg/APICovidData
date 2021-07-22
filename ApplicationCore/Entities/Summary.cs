using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Summary
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public GlobalSummary Global { get; set; }

        public IEnumerable<CountrySummary> Countries { get; set; }

        public DateTime Date { get; set; }

    }
}
