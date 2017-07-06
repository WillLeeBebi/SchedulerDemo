﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskService
{
    public class TaskModel
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// 程序集名称
        /// </summary>
        public string AssemblyPath { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 方法名称
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 执行类型
        /// </summary>
        public TaskExccuteType Type { get; set; }

        /// <summary>
        /// 间隔时长
        /// </summary>
        public string IntervalTime { get; set; }

        /// <summary>
        /// 开始执行时间
        /// </summary>
        public string ExcuteTime { get; set; }

        public bool IsExecuting { get; set; }
    }

    public enum TaskExccuteType
    {
        /// <summary>
        /// 指定时间运行一次
        /// </summary>
        OnceTime,

        /// <summary>
        /// 每间隔多少秒执行一次
        /// </summary>
        IntervalSecond,

        /// <summary>
        /// 每间隔都少小时执行一次
        /// </summary>
        IntervalHour,

        /// <summary>
        /// 每间隔多少天执行一次
        /// </summary>
        IntervalDay,

        /// <summary>
        /// 指定时间运行
        /// </summary>
        SpecifyTime
    }
}
