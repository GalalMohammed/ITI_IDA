using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredTeamLead
{
    internal interface ILead
    {
        void AssignTask(ITask task, ITeamMember teamMember);
        void CreateTask(string title, string description, ITask task);
    }
}
