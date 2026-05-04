using System;

class CharacterFrequency
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            int count = 1;

            if (str[i] == '0')
                continue;

            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                    str = str.Remove(j, 1).Insert(j, "0");
                }
            }

            Console.WriteLine(str[i] + " = " + count);
        }
    }
}