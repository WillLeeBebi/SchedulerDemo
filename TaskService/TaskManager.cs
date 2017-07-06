using System;

namespace TaskService
{
    public static class TaskManager
    {

        public static void StartTask()
        {
            TaskTest.Instance.Init();
            Console.ReadLine();
        }

        public static void StopTask()
        {
            TaskTest.Instance.Stop();
        }

        public static void AddTask()
        {
            
        }

        public static void DeleteTask()
        {
            
        }
    }
}
