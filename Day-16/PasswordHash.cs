using System;
using System.Security.Cryptography;
using System.Text;

class PasswordHash
{
    public static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    static void Main()
    {
        string hash = HashPassword("mypassword");
        Console.WriteLine(hash);
    }
}