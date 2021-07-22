using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IFileStoreService
    {
        void StoreContent(string fileContent);

        Task<string> getFileContent();
    }
}
