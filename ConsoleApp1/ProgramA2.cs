using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class PracticeArrays
{
    public void ArrayCopying()
    {
        int[] s = new int[10];
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = i;
        }

        int[] d = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            d[i] = s[i];
            Console.WriteLine($"{i}: {s[i]} is copied to {d[i]}");
        }
    }

    public void GroceryList()
    {
        ArrayList list = new ArrayList(); 
        do
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            char symbol = (char) Console.Read();
            if (symbol == '+')
            {
                list.Add(Console.ReadLine().Trim());
            }
            else if (symbol == '-')
            {
                char nextSymbol = (char)Console.Read();
                if ( nextSymbol == '-')
                {
                    list = new ArrayList();
                }
                else
                {
                    list.Remove((nextSymbol + Console.ReadLine()).Trim());
                }
                
            }
            else
            {
                continue;
            }
            Console.WriteLine("----------Grocery List:-----------");
            foreach (String line in list)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------------");
        } while (true);
    }

    public static bool isPrime(int num)
    {
        if (num == 1)
            return false;
        for (int j = 2; j < num; j++)
        {
            if (num % j == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        int[] results = new int[endNum - startNum + 1];
        int lastIndex = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (isPrime(i))
            {
                results[lastIndex++] = i;
            }
        }
        
        int[] truncResults = new int[lastIndex];
        Array.Copy(results, truncResults, lastIndex);
        Console.WriteLine(string.Join(", ", truncResults));
        return truncResults;
    }

    public int[] EnterArray()
    {
        Console.WriteLine("Enter array:");
        string arrayStringInput = Console.ReadLine();
        string[] arrayString = arrayStringInput.Split(' ');
        int[] arrayInt = new int[arrayString.Length];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayInt[i] = Int32.Parse(arrayString[i]);
        }

        return arrayInt;
    }

    public void CaculateSum()
    {
        int[] arrayInt = EnterArray();
        
        int[] sumArray = new int[arrayInt.Length];
        Console.WriteLine("Enter K:");
        int kInput = Int32.Parse(Console.ReadLine());
        
        for (int i = 0; i < sumArray.Length; i++)
        {
            int sum = 0;
            for (int j = 1; j <= kInput; j++)
            {
                int index;
                if ((i - j) % arrayInt.Length < 0)
                {
                    index = arrayInt.Length + (i - j) % arrayInt.Length;
                }
                else
                {
                    index = (i - j) % arrayInt.Length;
                }
                // Console.Write(i + "-" + j + " " + index + " ");
                sum += arrayInt[index];
                // Console.Write(arrayInt[index] + " ");
            }
            Console.WriteLine();
            sumArray[i] = sum;
        }
        
        Console.WriteLine(string.Join(" ", sumArray));
    }

    public void FindLongest()
    {
        int[] arrayInt = EnterArray();

        int longest = 1;
        int[] longestSub = new int[arrayInt.Length];
        longestSub[0] = 1;
        int longestInt = arrayInt[0];
        
        for (int i = 1; i < arrayInt.Length; i++)
        {
            if (arrayInt[i] == arrayInt[i-1])
            {
                longestSub[i] = longestSub[i - 1] + 1;
                if (longestSub[i] > longest)
                {
                    longestInt = arrayInt[i];
                    longest = longestSub[i];
                }
            }
            else
            {
                longestSub[i] = 1;
            }
        }

        for (int i = 0; i < longest; i++)
        {
            Console.Write(longestInt + " ");
        }
        Console.WriteLine();
    }

    public void FindMostFrequency()
    {
        int[] arrayInt = EnterArray();
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < arrayInt.Length; i++)
        {
            if (freq.ContainsKey(arrayInt[i]))
            {
                freq[arrayInt[i]] += 1;
            }
            else
            {
                freq.Add(arrayInt[i], 1);
            }
        }

        List<int> freqValues = freq.Values.ToList();
        freqValues.Sort();
        freqValues.Reverse();
        int mostFreq = freqValues[0];
        List<KeyValuePair<int, int>> mostFreqPairs = new List<KeyValuePair<int, int>>();
        foreach (var pair in freq)
        {
            int value = pair.Value;
            if (value == mostFreq)
            {
                mostFreqPairs.Add(pair);
            }
        }

        if (mostFreqPairs.Count == 1)
        {
            Console.WriteLine($"The number {mostFreqPairs[0].Key} is the most frequent (occurs {mostFreqPairs[0].Value} times)");
        }
        else
        {
            Console.Write("The numbers ");
            for (int i = 0; i < mostFreqPairs.Count; i++)
            {
                Console.Write(mostFreqPairs[i].Key);
                if (i == mostFreqPairs.Count - 2)
                {
                    Console.Write(" and " + mostFreqPairs[i+1].Key);
                    break;
                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine($" have the same maximal frequency (each occurs {mostFreqPairs[0].Value} times). The leftmost of them is {mostFreqPairs[0].Key} .");
        }
    }
}

public class PracticeStrings
{
    public void ReverseString()
    {
        string readInput = Console.ReadLine();
        char[] chars = readInput.ToCharArray();
        Array.Reverse(chars);
        string output = new string(chars);
        Console.WriteLine("method1: " + output);
        Console.Write("method2: ");
        for (int i = readInput.Length-1; i >= 0; i--)
        {
            Console.Write(readInput[i]);
        }
        Console.WriteLine();
    }

    public void SplitAndReverse()
    {
        string readInput = Console.ReadLine();
        char[] separator = new[]
        {
            ',',
            '.',
            ';',
            ':',
            '=',
            '(',
            ')',
            '&',
            '[',
            ']',
            '"',
            '\'',
            '\\',
            '/',
            '!',
            '?'
        };
        string[] tokens = readInput.Split(' ');
        Console.WriteLine(string.Join(",", tokens));
        List<int> pos = new List<int>();
        List<char> sym = new List<char>();
        int count = 1;
        for (int i = 0; i < tokens.Length; i++)
        {
            for (int j = 0; j < tokens[i].Length; j++)
            {
                // Console.Write(tokens[i][j] + " ");
                if (separator.Contains(tokens[i][j]))
                {
                    pos.Add(i+count++);
                    sym.Add(tokens[i][j]);
                    // Console.WriteLine(i + "-[" + tokens[i][j] + "]");
                    tokens[i] = tokens[i].Remove(j,1);
                    
                }
                
            }
        }

        List<string> sentence = tokens.ToList();
        sentence.Reverse();
        for (int i = 0; i < pos.Count; i++)
        {
            sentence.Insert(pos[i], sym[i].ToString());
        }

        foreach (var word  in sentence)
        {
            Console.Write(word + " ");
        }
    }

    public bool isPalindromes(string word)
    {
        int length = word.Length;
        if (length == 1)
            return true;
        for (int j = 0; j < length / 2; j++)
        {
            // Console.Write(word[j] + " ");
            if (word[j] != word[length - 1 - j])
            {
                return false;
            }
        }

        return true;
    }

    public void FindPalindromes()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        string[] tokens = Regex.Matches(input, "\\w+")
            .Cast<Match>().Select(x => x.Value).ToArray();
        SortedSet<string> palins = new SortedSet<string>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (isPalindromes(tokens[i]))
            {
                palins.Add(tokens[i]);
            }
                
            
        }

        Console.WriteLine(string.Join(", ", palins));
    }

    public void ParseURL()
    {
        Console.WriteLine("Enter an url:");
        string input = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";
        string[] split1 = input.Split("://");
        
        Console.WriteLine();
        string[] split2;
        if (split1.Length == 2)
        {
            split2 = split1[1].Split("/",2);
            protocol = split1[0];
        }
        else
        {
            split2 = input.Split("/", 2);
        }

        if (split2.Length == 2)
        {
            server = split2[0];
            resource = split2[1];
        }
        else
        {
            server = split2[0];
        }
        
        Console.WriteLine($"[Protocol] = \"{protocol}\" \n [Server] = \"{server}\" \n [Resource] = \"{resource}\"");
    }
}