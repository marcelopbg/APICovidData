using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class FileStoreService : IFileStoreService
    {
        private string Directory = "jsonData";
        private string File = "covidData.json";
        public async Task<string> getFileContent()
        {
            var jsonContent = await System.IO.File.ReadAllTextAsync($"{Directory}/{File}");
            return jsonContent;
        }
        public void StoreContent(string fileContent)
        {
            System.IO.Directory.CreateDirectory(Directory);
            System.IO.File.WriteAllTextAsync($"{Directory}/{File}", fileContent);
        }
    }
}

