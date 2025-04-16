using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFile
{
    public class SQLFile: ISQLFile, ILoadText, ISaveText
    {
        public virtual required string FilePath { get; set; }
        public virtual required string FileText { get; set; }
        public virtual string LoadText()
        {
            // code to load SQL file
            return FileText;
        }
        public virtual string SaveText()
        {
            // code to save SQL file
            return FilePath;
        }
    }
}
