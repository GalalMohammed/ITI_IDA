using SQLFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredSQLFile
{
    public class ReadOnlySQLFile : ISQLFile, ILoadText
    {
        public required string FilePath { get; set; }
        public required string FileText { get; set; }

        public virtual string LoadText()
        {
            // code to load SQL file
            return FileText;
        }
    }
}
