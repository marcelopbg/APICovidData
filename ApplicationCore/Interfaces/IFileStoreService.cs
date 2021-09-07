using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IFileStoreService
    {
        void StoreContent(string fileContent);

        Task<string> getFileContent();
    }
}
