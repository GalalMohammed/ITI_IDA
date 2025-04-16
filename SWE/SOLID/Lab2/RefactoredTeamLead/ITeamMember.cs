using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredTeamLead
{
    internal interface ITeamMember
    {
        internal string Name { get; }
        void WorkOnTask(ITask task);
    }
}
