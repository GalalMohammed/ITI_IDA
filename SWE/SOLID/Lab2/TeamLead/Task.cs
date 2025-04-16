using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLead
{
    internal class Task
    {
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal void AssignTo(Developer developer)
        {
            // code to assign task to developer
            Console.WriteLine($"Task '{Title}' assigned to {developer.Name}");
        }
    }
}
