using System;

namespace TimerTaskService
{
    public class Task1
    {
        public void Execute()
        {
            Console.WriteLine("我是定时任务1，现在时间：" + DateTime.Now);
        }
    }

    public class Task2
    {
        public void Execute()
        {
            Console.WriteLine("我是定时任务2，现在时间：" + DateTime.Now);
        }
    }

    public class Task3
    {
        public void Execute()
        {
            Console.WriteLine("我是定时任务3，现在时间：" + DateTime.Now);
        }
    }
}
