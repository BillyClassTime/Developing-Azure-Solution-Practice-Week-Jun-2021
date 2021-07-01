using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using Azure.Storage.Blobs;

namespace PhotoSharingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("StorageAccount");
            string containerName = "photos";

            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            container.CreateIfNotExists();

            string blobName = "docs-and-friends-selfie-stick.png";
            //string fileName = @$"D:\Az-204\prac\10\images\{blobName}";
            string fileName = @"D:\Az-204\prac\10\images\docs-and-friends-selfie-stick.png";

            BlobClient blobClient = container.GetBlobClient(blobName);
            blobClient.Upload(fileName,true);

            //var blobs = container.GetBlobs();
            Azure.Pageable<Azure.Storage.Blobs.Models.BlobItem> blobs = container.GetBlobs();

            foreach (var blob in blobs)
            {
                Console.WriteLine($"{blob.Name}  --> Created on:{blob.Properties.CreatedOn:yyyy-MM-dd HH:mm:ss}  Size: {blob.Properties.ContentLength}");
            }

            Console.WriteLine("Fin la ejecución");
        }
    }
}
