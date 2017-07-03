using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskService
{
    public class TaskModel
    {
        public string Id { get; set; }

        public string TaskName { get; set; }

        public string AssemblyPath { get; set; }

        public string Namespace { get; set; }

        public string Method { get; set; }

        public int Type { get; set; }

        public int IntervalTime { get; set; }

        public DateTime? ExcuteTime { get; set; }
    }
}
