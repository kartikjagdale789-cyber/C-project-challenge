using System;
using System.Security.Cryptography;
using System.Text;

class SecureCoding {
    static void Main() {
        string password = "MyPassword123";

        using (SHA256 sha = SHA256.Create()) {
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            Console.WriteLine(Convert.ToBase64String(hash));
        }
    }
}
