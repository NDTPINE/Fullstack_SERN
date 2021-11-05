using System;
using System.Collections.Generic;

namespace WorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendMail());
            workFlow.Add(new ChangeStatus());
            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
            Console.ReadLine();
        }
    }
    public interface ITask
    {
        void Execute();
    }
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
    public class WorkFlow : IWorkFlow
    {
        private List<ITask> _tasks;
        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }
        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }
    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service..");
        }
    }
    class SendMail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email...");
        }
    }
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status changed...");
        }
    }
    public class WorkFlowEngine 
    {
        public void Run(IWorkFlow workflow)
        {
            foreach(ITask I in workflow.GetTasks())
            {
                I.Execute();
            }
        }
    }
}
