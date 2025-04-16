using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredTeamLead
{
    internal class TeamLead : Developer, ILead
    {

        public void AssignTask(ITask task, ITeamMember teamMember)
        {
            // code to assign a task
            task.AssignTo(teamMember);
            Console.WriteLine($"Task '{task.Title}' assigned to {teamMember.Name}");
        }

        public void CreateTask(string title, string description, ITask task)
        {
            // code to create a task
            task.Title = title;
            task.Description = description;
            Console.WriteLine($"Task created: {task.Title} - {task.Description}");
        }
    }
}
