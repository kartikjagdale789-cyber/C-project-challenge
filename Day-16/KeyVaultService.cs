using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

class KeyVaultService
{
    public static void GetSecret()
    {
        var client = new SecretClient(
            new Uri("https://yourvault.vault.azure.net/"),
            new DefaultAzureCredential());

        KeyVaultSecret secret = client.GetSecret("MySecret");

        Console.WriteLine(secret.Value);
    }
}