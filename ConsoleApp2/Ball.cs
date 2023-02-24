namespace ConsoleApp2;

public class Ball
{
    public int Size;
    public Color Color;
    public int ThrowCount;

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size != 0)
        {
            ThrowCount += 1;
        }
    }

    public int GetThrowCount()
    {
        return ThrowCount;
    }
    
    // this is main method
    public static void Demo()
    {
        Color black = new Color(0, 0, 0);
        Ball ball1 = new Ball(20, black);
        Ball ball2 = new Ball(40, black);
        Ball ball3 = new Ball(12, black);
        ball1.Pop();
        Console.WriteLine(ball2.GetThrowCount());
        ball3.Throw();
        ball2.Throw();
        Console.WriteLine(ball2.GetThrowCount());
        ball3.Pop();
        ball3.Throw();
        Console.WriteLine(ball3.GetThrowCount());
    }
}