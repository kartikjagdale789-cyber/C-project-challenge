using System;
using System.IO;

class FileCRUD
{
    static string filePath = "data.txt";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Create\n2. Read\n3. Update\n4. Delete\n5. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter data: ");
                    string data = Console.ReadLine();
                    File.AppendAllText(filePath, data + "\n");
                    break;

                case 2:
                    if (File.Exists(filePath))
                        Console.WriteLine(File.ReadAllText(filePath));
                    break;

                case 3:
                    File.WriteAllText(filePath, "Updated Content");
                    break;

                case 4:
                    File.Delete(filePath);
                    Console.WriteLine("File Deleted");
                    break;

                case 5:
                    return;
            }
        }
    }
}