using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredTeamLead
{
    internal interface ITask
    {
        string Title { get; set; }
        string Description { get; set; }
        void AssignTo(ITeamMember teamMember);
    }
}
