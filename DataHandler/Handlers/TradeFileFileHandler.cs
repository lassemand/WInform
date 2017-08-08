using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler.Handlers
{
    public class TradeFileFileHandler : IFileHandler
    {
        public string FilePath { get; set; }

        public TradeFileFileHandler(string filePath)
        {
            FilePath = filePath;
        }
    }
}
