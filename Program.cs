using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //halloWriter();
        //Console.WriteLine(sumTwoNumbers(10, 20));
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(2);
        ints.Add(2);
        ints.Add(3);
        ints.Add(3);
        Console.WriteLine(NumberOfDuplicatesInList(ints));
    }


    private static void halloWriter()
    {
        Console.WriteLine("hallo:");
        Console.WriteLine("user");
    }

    private static int sumTwoNumbers(int a, int b)
    {
        return a + b;
    }

    private static int NumberOfDuplicatesInList(List<int> list)
    {
        Hashtable hashtable = new Hashtable();
        foreach (int i in list)
        {
            if (hashtable.ContainsKey(i))
            {
                int value = (int)hashtable[i];
                hashtable.Remove(i);
                value++;
                hashtable.Add(i, value);
            }
            else
            {
                hashtable.Add(i, 1);
            }
        }
        int result = list.Count - hashtable.Count;
        return result;
    }
}

