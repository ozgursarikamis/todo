using FluentScheduler;

namespace Todo.Library.Schedules.Jobs
{
    public class ReminderJob : IJob
    {
        public void Execute()
        {
            
        }
    }

    public class RepeatJob : IJob
    {
        public void Execute() { }
    }
}