using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CovidSummaryService : ICovidSummaryService
    {
        public async Task<string> getCovidSummaryFromExternalAPI()
        {
            var client = new HttpClient();
            var res = await client.GetAsync("https://api.covid19api.com/summary");
            var resString = await res.Content.ReadAsStringAsync();
            return resString;
        }
    }
}
