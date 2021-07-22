using ApplicationCore.Entities;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICovidSummaryRepository
    {
        void StoreSummary();
        Task<Summary> GetSummary();
    }
}
