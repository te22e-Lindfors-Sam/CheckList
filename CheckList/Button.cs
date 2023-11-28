using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

class Section
{
    public static List<Section> sections;
    public int posX;
    public int posY;
    public int sizeX;
    public int sizeY;
    public Color color;
    public string text;
    public State state;
    public Section(int posX, int posY, int sizeX, int sizeY, State state, Color color)
    {
        this.posX = posX;
        this.posY = posY;
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        this.state = state;
        this.color = color;
    }


    public static void renderButtons(List<Section> list)
    {
        for (int i = 0; i < list.Count(); i++)
        {
            Raylib.DrawRectangle(list[i].posX, list[i].posY, list[i].sizeX, list[i].sizeY, list[i].color);
        }
    }

    public static void checkMouseOverSection(List<Section> list)
    {
        Vector2 mousePos = Raylib.GetMousePosition();
        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i].posX <= mousePos.X && list[i].posX + list[i].sizeX >= mousePos.X && list[i].posY <= mousePos.Y && list[i].posY + list[i].sizeY >= mousePos.Y)
            {
                list[i].MouseHovering();
            }
        }
    }

    public void MouseHovering()
    {
        if (state == State.Button)
        {
            if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_BUTTON_LEFT))
            {

            }
        }
        else if (state == State.Input)
        {
            string output = "";
            int key = Raylib.GetCharPressed();
            while (key > 0)
            {
                // NOTE: Only allow keys in range [32..125]
                if ((key >= 32) && (key <= 125))
                {
                    output += (char)key;
                }

                key = Raylib.GetCharPressed();  // Check next character in the queue
            }

            // if (IsKeyPressed(KEY_BACKSPACE))
            // {
            //     Task.tasks[Task.selectedTask].taskName.Length;
            // }
            Task.tasks[Task.selectedTask].taskName += output;
        }
    }

}

public enum State { Button, Section, Input };