using Moq;
using System;

public interface IService
{
    int GetData();
}

class Program
{
    static void Main()
    {
        var mock = new Mock<IService>();
        mock.Setup(x => x.GetData()).Returns(100);

        Console.WriteLine(mock.Object.GetData()); // Output: 100
    }
}