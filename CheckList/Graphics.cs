using Raylib_cs;

public class Graphics
{
    public Color mainColor { get; set; }
    public Color subColor { get; set; }
    public Color textColor { get; set; }

    public Graphics(Color mainColor, Color subColor, Color textColor)
    {
        this.mainColor = mainColor;
        this.subColor = subColor;
        this.textColor = textColor;
    }



}