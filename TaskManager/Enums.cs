using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public enum TaskStatus
    {
        NEW = 0,
        IN_PROGRESS = 1,
        DONE = 2
    }

    public enum TaskPriority
    {
        LOW = 0,
        NORMAL = 1,
        HIGH = 2
    }
}
