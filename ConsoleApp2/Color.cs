namespace ConsoleApp2;

public class Color
{
    public int Red;
    public int Green;
    public int Blue;
    public int Alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }    
    
    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }

    public void SetValues(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public double GetGrayScale()
    {
        return (Red + Green + Blue) / 3.0;
    }
}