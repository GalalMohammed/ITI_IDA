﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFile
{
    public interface ISQLFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
    }
}
