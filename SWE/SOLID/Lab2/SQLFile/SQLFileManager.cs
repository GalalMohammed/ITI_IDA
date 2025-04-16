using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFile
{
    public class SQLFileManager : ISQLFileManager
    {
        public virtual List<ISQLFile> LstSQLFiles { get; set; } = [];
        public virtual string GetTextFromFiles()
        {
            StringBuilder sb = new();
            foreach (ISQLFile file in LstSQLFiles)
            {
                if (file is ILoadText loadText)
                {
                    string text = loadText.LoadText();
                    sb.Append(text);
                }
            }
            return sb.ToString();
        }
        public virtual void SaveTextIntoFiles()
        {
            foreach (ISQLFile file in LstSQLFiles)
            {
                if (file is ISaveText saveText)
                    saveText.SaveText();
            }
        }
    }
}
