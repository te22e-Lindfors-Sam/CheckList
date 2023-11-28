using System.Security.AccessControl;
using Raylib_cs;

public class Task
{
    public static List<Task> tasks;
    public static int selectedTask;
    public string taskName { get; set; }
    public string taskBody { get; set; }
    public DateTime timeToBeDone { get; set; }

    public bool selected = false;
    public Task(string taskName, string taskBody, DateTime timeToBeDone)
    {
        this.taskName = taskName;
        this.taskBody = taskBody;
        this.timeToBeDone = timeToBeDone;
    }

    public static void renderTasks()
    {
        List<Section> taskButtons = new List<Section>();
        for (int i = 0; i < tasks.Count; i++)
        {
            taskButtons.Add(new Section(30, 90 + i * 60, 230, 50, State.Button, Color.BROWN));
            if (tasks[i].selected)
            {
                Raylib.DrawText(tasks[i].taskName, 350, 20, 50, Color.BLACK);
            }
        }
        Section.renderButtons(taskButtons);
        Section.checkMouseOverSection(taskButtons);
    }

}