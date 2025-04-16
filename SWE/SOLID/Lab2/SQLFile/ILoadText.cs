using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFile
{
    public interface ILoadText : ISQLFile
    {
        public string LoadText();
    }
}
