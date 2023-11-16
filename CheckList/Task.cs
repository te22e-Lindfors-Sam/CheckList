public class Task
{
    public string taskName { get; set; }
    public DateTime timeToBeDone { get; set; }

    public Task(string taskName, DateTime timeToBeDone)
    {
        this.taskName = taskName;
        this.timeToBeDone = timeToBeDone;
    }
}