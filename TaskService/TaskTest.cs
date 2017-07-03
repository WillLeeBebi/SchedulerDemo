using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FluentScheduler;
using Newtonsoft.Json;

namespace TaskService
{
    public class TaskTest
    {
        private List<TaskModel> _taskList = null;  
        
        public void Init()
        {
            GetTaskList();
            Registry reg = new Registry();
            if (_taskList.Any())
            {
                foreach (var taskModel in _taskList)
                {
                    // 从当前时间开始执行，然后每隔指定时间运行
                    reg.Schedule(() => InvokeMethod(taskModel.AssemblyPath, taskModel.Namespace, taskModel.Method)).ToRunNow().AndEvery(taskModel.IntervalTime).Seconds();
                    if (taskModel.Type == 2)
                    {
                        // 从指定时间开始执行，然后每隔指定时间运行
                        if (taskModel.ExcuteTime == null)
                        {
                            taskModel.ExcuteTime = DateTime.Now.AddMinutes(2);
                        }
                        reg.Schedule(() => InvokeMethod(taskModel.AssemblyPath, taskModel.Namespace, taskModel.Method))
                            .ToRunOnceAt(taskModel.ExcuteTime.Value).AndEvery(taskModel.IntervalTime).Seconds();
                    }
                }
            }

            JobManager.Initialize(reg);
        }

        private void GetTaskList()
        {
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Task.json";
            string result = File.ReadAllText(path);
            var list = JsonConvert.DeserializeObject<List<TaskModel>>(result);
            _taskList = list;
        }

        private void InvokeMethod(string assemblyPath, string nameSpace, string method)
        {
            Assembly assembly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + assemblyPath);
            Type type = assembly.GetType(nameSpace);
            object obj = Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod(method, BindingFlags.Instance | BindingFlags.Public);

            if (mi != null)
            {
                mi.Invoke(obj, null);
            }
        }
    }

    public class Task1 : IJob
    {
        public void Execute()
        {
            Console.WriteLine("--------------任务2开始----------");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("--------------任务2结束----------");
        }
    }
}
