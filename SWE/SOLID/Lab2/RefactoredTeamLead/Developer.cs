using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredTeamLead
{
    internal class Developer : ITeamMember
    {
        public required string Name { get; set; }

        public void WorkOnTask(ITask task)
        {
            // code to implement and perform assigned task
            Console.WriteLine($"{Name} is working on task: {task.Title}");
        }
    }
}
