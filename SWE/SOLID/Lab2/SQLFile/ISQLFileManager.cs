using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFile
{
    public interface ISQLFileManager
    {
        public List<ISQLFile> LstSQLFiles { get; set; }
        public string GetTextFromFiles();
        public void SaveTextIntoFiles();
    }
}
