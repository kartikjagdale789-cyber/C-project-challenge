using System;

class RoleAuth
{
    static void Main()
    {
        Console.Write("Enter role (admin/user): ");
        string role = Console.ReadLine();

        if (role == "admin")
            Console.WriteLine("Access Granted: Full Control");
        else if (role == "user")
            Console.WriteLine("Access Granted: Limited Access");
        else
            Console.WriteLine("Access Denied");
    }
}