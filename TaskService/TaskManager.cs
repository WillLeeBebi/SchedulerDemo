using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace TaskService
{
    public static class TaskManager
    {

        public static void StartTask()
        {
            TaskTest test = new TaskTest();
            test.Init();
            Console.ReadLine();
        }

        public static void StopTask()
        {
            JobManager.Stop();
        }

        public static void AddTask()
        {
            
        }

        public static void DeleteTask()
        {
            
        }
    }
}
