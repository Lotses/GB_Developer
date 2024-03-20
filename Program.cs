using System;

class Program
{
    static void Main()
    {
        string[] initialArray = { "apple", "1234", "dot", "babushka", "_test_text" };
        string[] newArray = new string[initialArray.Length];
        int newIndex = 0;

        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                newArray[newIndex] = initialArray[i];
                newIndex++;
            }
        }

        Array.Resize(ref newArray, newIndex);

        Console.WriteLine("New array with strings of length <= 3:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}
