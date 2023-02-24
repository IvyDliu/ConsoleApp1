namespace ConsoleApp2;

public class Fibonacci
{
    public static void RunFibonacci(int num)
    {
        for (int i = 1; i < num+1; i++)
        {
            int fib = DoFibonacci(i);
            Console.Write(fib + " ");
        }
    }
    
    public static int DoFibonacci(int num)
    {
        if (num == 1)
        {
            // Console.Write(1);
            return 1;
        }

        if (num == 2)
        {
            // Console.Write(" " + 1);
            return 1;
        }
        int fib = DoFibonacci(num - 2) + DoFibonacci(num - 1);
        return fib;
    }
}