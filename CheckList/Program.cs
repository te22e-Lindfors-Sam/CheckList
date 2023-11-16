using Raylib_cs;


SaveSystem data = new SaveSystem();

Raylib.InitWindow(800, 600, "The title of my window");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.WHITE);

    Raylib.DrawCircle(100, 100, 100, Color.MAGENTA);

    if (Raylib.IsKeyReleased(KeyboardKey.KEY_U))
    {
        data = new SaveSystem();
    }

    if (Raylib.IsKeyReleased(KeyboardKey.KEY_I))
    {
        Console.WriteLine(data.graphicsSettings.mainColor);
        data.Save(data);
    }

    Raylib.EndDrawing();
}