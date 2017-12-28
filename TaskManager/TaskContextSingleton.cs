using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public sealed class TaskContextSingleton
    {

        private static readonly TaskContext taskContext = new TaskContext();

        private TaskContextSingleton() { }

        public static TaskContext Instance
        {
            get
            {
                return taskContext;
            }
        }

    }
}
