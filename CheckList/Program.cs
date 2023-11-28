using Raylib_cs;

Task.tasks = new List<Task>();
Task.tasks.Add(new Task("task1", "", DateTime.Now));
Task.tasks.Add(new Task("task2", "", DateTime.Now));
Task.tasks.Add(new Task("task3", "", DateTime.Now));
Task.tasks.Add(new Task("task4", "", DateTime.Now));
Task.tasks.Add(new Task("task5", "", DateTime.Now));
Task.tasks.Add(new Task("task6", "", DateTime.Now));
Task.tasks.Add(new Task("task7", "", DateTime.Now));
Task.tasks.Add(new Task("task8", "", DateTime.Now));
Task.tasks.Add(new Task("task9", "", DateTime.Now));
Task.tasks.Add(new Task("task10", "", DateTime.Now));
Task.tasks.Add(new Task("task11", "", DateTime.Now));
Task.tasks.Add(new Task("task12", "", DateTime.Now));
Task.tasks.Add(new Task("task13", "", DateTime.Now));
Task.tasks.Add(new Task("task14", "", DateTime.Now));
Task.tasks.Add(new Task("task15", "", DateTime.Now));
Task.tasks.Add(new Task("task16", "", DateTime.Now));
Task.tasks.Add(new Task("task17", "", DateTime.Now));

Task.tasks[4].selected = true;
Task.selectedTask = 4;

SaveSystem data = new SaveSystem();
Section.sections = new List<Section>();
Section.sections.Add(new Section(0,0,300,800, State.Section, Color.DARKBLUE));//checklist background
Section.sections.Add(new Section(20,90,260,700, State.Section, Color.DARKGRAY));//checklist background background
Section.sections.Add(new Section(300,0,800,800, State.Section, Color.PURPLE)); //into background
Section.sections.Add(new Section(350, 20, 700, 100, State.Input, Color.DARKPURPLE));//info title
Section.sections.Add(new Section(350, 160, 700, 600, State.Input, Color.DARKPURPLE));//info body



Raylib.InitWindow(1100, 800, "The title of my window");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.WHITE);

    Section.checkMouseOverSection(Section.sections);
    Section.renderButtons(Section.sections);
    Task.renderTasks();





    Raylib.EndDrawing();
}



