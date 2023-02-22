// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1;

public class HackerName
{
    public void AskName()
    {
        Console.WriteLine("What is favorite color?");
        String color = Console.ReadLine();
        Console.WriteLine("What is your astrology sign?");
        String astr = Console.ReadLine();
        Console.WriteLine("What is your street number?");
        String street = Console.ReadLine();
        Console.WriteLine($"Your hacker name is ... {color}{astr}{street}");
    }
}

public class PracticeNumbers
{
    public void Question1()
    {
        String[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long",
            "ulong", "float", "double", "decimal"};
        int[] sizes = { 8, 8, 16, 16, 32, 32, 64, 64, 4, 8, 16};
        String[] mins =
        {
            "-128", "0", "-32768", "0", "-2147483648", "0", "-9,223,372,036,854,775,808", "0",
            "±1.5 x 10^45", "±5.0 × 10^324", "±1.0 x 10^28"
        };
        String[] maxs = { "127", "255", "32767", "65535", "2,147,483,647", "4,294,967,295", 
            "9,223,372,036,854,775,807", "18,446,744,073,709,551,615", "±3.4 x 10^38", "±1.7 × 10^308", "±7.9228 x 10^28"
        };
        Console.WriteLine("{0,-10} {1,-10} {2, -30} {3, -30}", "Types", "Size", "Min", "Max");
        for (int i = 0; i < types.Length; i++)
        {
            Console.WriteLine("{0,-10} {1,-10} {2, -30} {3, -30}", types[i], sizes[i], mins[i], maxs[i]);
        }

    }

    public void Question2()
    {
        Console.WriteLine("Enter number of centuries");
        ulong century =  Convert.ToUInt64(Console.ReadLine());
        ulong year = century * 100;
        ulong day = year * 365;
        ulong hours = day * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milisec = seconds * 1000;
        ulong microsec = milisec * 1000;
        ulong nanosec = microsec * 1000;
        Console.WriteLine($"{century} centuries = {year} years = {day} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");

    }
    
}

public class PracticeLoops
{
    public void Question1()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            if (i == 255)
            {
                Console.WriteLine("max reached");
                break;
            }
            Console.WriteLine(i);
        }
    }

    public void Question3GuessNumber()
    {
        Console.WriteLine("Guess a number between 1 and 3");
        int correctNumber = new Random().Next(3) + 1;
        int guessedNumber = int.Parse(Console.ReadLine());
        while (correctNumber != guessedNumber)
        {
            if (guessedNumber > 3 || guessedNumber < 1)
            {
                Console.WriteLine("Your guess must be between 1 and 3");
            }

            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Guess lower");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Guess higher");
            }
            guessedNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Bingo");
        return;
    }

    public void Question2Pyramid(int width)
    {
        if (width % 2 == 0)
        {
            Console.WriteLine("width must be odd");
            return;
        }

        int level = width / 2 + 1;
        for (int i = 0; i < level; i++)
        {
            int spaces = (width - (1 + i * 2)) / 2;
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 1 + i * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void Question4Days(DateTime birthDay)
    {
        DateTime currentDay = DateTime.Today;
        int days = (int) (currentDay - birthDay).TotalDays;
        int daysToNextAnniversary = 10000 - (days % 10000); 
        Console.WriteLine($"You are {days} days old, {daysToNextAnniversary} days to your next anniversary");
    }

    public void Question5Greeting()
    {
        int currentTime = DateTime.Now.Hour;
        Console.WriteLine("The time is " + currentTime + " o'clock");
        if (currentTime >= 0 && currentTime < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (currentTime >= 12 && currentTime < 15)
        {
            Console.WriteLine("Good Afternoon");
        }
        else if (currentTime >= 15 && currentTime < 20)
        {
            Console.WriteLine("Good Evening");
        }
        else if (currentTime >= 20 && currentTime <= 24)
        {
            Console.WriteLine("Good Night");
        }
    }

    public void Question6Count()
    {
        int limit = 24;
        for (int i = 1; i < 5; i++)
        {
            for (int j = 0; j < limit + 1; j+=i)
            {
                Console.Write(j);
                if (j == limit)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(",");
                }
            }
            
        }
    }
}

public class Test
{
    public static void Main()
    {
        HackerName hackerName = new HackerName();
        // hackerName.AskName();
        PracticeNumbers practiceNumbers = new PracticeNumbers();
        // practiceNumbers.Question1();
        // practiceNumbers.Question2();
        PracticeLoops practiceLoops = new PracticeLoops();
        // practiceLoops.Question1();
        // practiceLoops.Question3GuessNumber();
        // practiceLoops.Question2Pyramid(9);
        // practiceLoops.Question4Days( DateTime.Parse("1999/01/30"));
        // practiceLoops.Question5Greeting();
        // practiceLoops.Question6Count();
        PracticeArrays practiceArrays = new PracticeArrays();
        // practiceArrays.ArrayCopying();
        // practiceArrays.GroceryList();
        // PracticeArrays.FindPrimesInRange(1, 20);
        // practiceArrays.CaculateSum();
        // practiceArrays.FindLongest();
        // practiceArrays.FindMostFrequency();
        PracticeStrings practiceStrings = new PracticeStrings();
        // practiceStrings.ReverseString();
        // practiceStrings.SplitAndReverse();
        // practiceStrings.FindPalindromes();
        practiceStrings.ParseURL();
    }
    
    
    
    
    
    
}