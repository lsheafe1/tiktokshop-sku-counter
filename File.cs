using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiktokshop_sku_counter
{
    public class File
    {
        public string FileName { get; set; }
        private string _fullPath {  get; set; }

        public File(string fileName, string fullPath)
        {
            FileName = fileName;
            _fullPath = fullPath;
        }
    }
}
