using System;
using System.IO;
using System.Threading;

namespace TimerTaskService
{
    public class Task1
    {
        public void Execute()
        {
            LogHelper.WriteTaskLog("我是定时任务1，现在时间：" + DateTime.Now, "TaskLog1.txt");
        }
    }

    public class Task2
    {
        public void Execute()
        {
            LogHelper.WriteTaskLog("我是定时任务2，现在时间：" + DateTime.Now, "TaskLog2.txt");
        }
    }

    public class Task3
    {
        public void Execute()
        {
            LogHelper.WriteTaskLog("我是定时任务3，现在时间：" + DateTime.Now, "TaskLog3.txt");
        }
    }

    public class Task4
    {
        public void Execute()
        {
            LogHelper.WriteTaskLog("我是定时任务4，现在时间：" + DateTime.Now, "TaskLog4.txt");
        }
    }

    public class Task5
    {
        public void Execute()
        {
            LogHelper.WriteTaskLog("我是定时任务5，现在时间：" + DateTime.Now, "TaskLog5.txt");
        }
    }

    public class LogHelper
    {
        public static void WriteTaskLog(string text, string fileName)
        {
            string _filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            FileStream fs = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(DateTime.Now + ":  " + text);
            m_streamWriter.Flush();
            m_streamWriter.Close();
            fs.Close();
        }
    }
}
