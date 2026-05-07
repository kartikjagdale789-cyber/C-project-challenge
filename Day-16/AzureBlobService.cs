using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;

class AzureBlobService
{
    static string connectionString = "your_connection_string";
    static string containerName = "files";

    public static async Task UploadAsync(string filePath)
    {
        BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
        await container.CreateIfNotExistsAsync();

        BlobClient blob = container.GetBlobClient(Path.GetFileName(filePath));

        using FileStream fs = File.OpenRead(filePath);
        await blob.UploadAsync(fs, true);

        Console.WriteLine("File Uploaded to Azure Blob");
    }
}