using System;

class DotNetDeployment {
    static void Main() {
        Console.WriteLine("Application is ready for deployment!");

        Console.WriteLine("Steps:");
        Console.WriteLine("1. dotnet build");
        Console.WriteLine("2. dotnet publish -c Release");
        Console.WriteLine("3. Deploy to server or cloud");
    }
}