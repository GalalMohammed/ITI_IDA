using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLead
{
    internal class TeamLead : ILead
    {
        public void AssignTask()
        {
            // create a task
            Task t = new Task() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" }; // smell: using new Task() in the method

            // code to assign a task
            t.AssignTo(new Developer() { Name = "John Doe" }); // smell: using new Developer() in the method
        }

        public void CreateTask()
        {
            // code to create a task
        }

        public void WorkOnTask()
        {
            // code to implement and perform assigned task
        }
    }
}
