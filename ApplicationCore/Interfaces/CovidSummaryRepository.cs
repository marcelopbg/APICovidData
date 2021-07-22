using ApplicationCore.Entities;
using Infrastructure.Services;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public class CovidSummaryRepository : ICovidSummaryRepository
    {
        private readonly ICovidSummaryService _covidSummaryService;
        private readonly IFileStoreService _fileStoreService;
        public CovidSummaryRepository(ICovidSummaryService covidSummaryService, IFileStoreService fileStoreService)
        {
            _covidSummaryService = covidSummaryService;
            _fileStoreService = fileStoreService;
        }

        public async Task<Summary> GetSummary()
        {
            var res = await _fileStoreService.getFileContent();
            var summary = JsonConvert.DeserializeObject<Summary>(res);
            return summary;
        }

        public async void StoreSummary()
        {
            var res = await _covidSummaryService.getCovidSummaryFromExternalAPI();
            _fileStoreService.StoreContent(res);
        }

    }
}
