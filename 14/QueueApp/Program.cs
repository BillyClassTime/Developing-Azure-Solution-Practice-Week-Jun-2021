using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace QueueApp
{
    class Program
    {
        private const string connectionString = "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=staprac14bmvb;AccountKey=m09a9uJXVIw/ggEA3kdk8ZXLGCAT43GDZnUE8u5yGCT6OWRBLXMnGQ4fiJARJOPpFEyAdLCA9qYlb/7R6Wd1xA==";
        static async Task Main(string[] args)
        {
            if (args.Length >0)
            {
                string value = String.Join(" ",args);
                //SendArticleAsync(value).Wait();
                await SendArticleAsync(value);
                Console.WriteLine("Argumentos recibidos");
            }
            else
            {
                string value = await ReceiveArticleAsync();
                //Console.WriteLine("QueueApp \"Message to Send\" \nDebera poner el mensaje a enviar como argumento");
                Console.WriteLine($"Recibido:{value}");
            }
        }
        static async Task SendArticleAsync(string newMessage)
        {
            CloudQueue queue = GetQueue("newqueue");
            bool createQueue = await queue.CreateIfNotExistsAsync();
            if (createQueue)
                Console.WriteLine ("La cola de nuevos articulos ha sido creada");

            CloudQueueMessage articleMessage = new CloudQueueMessage(newMessage);
            await queue.AddMessageAsync(articleMessage);
            Console.WriteLine("Mensaje añadido a la cola");
        }
        static async Task<string> ReceiveArticleAsync()
        {
            CloudQueue queue = GetQueue("newqueue");
            bool exists = await queue.ExistsAsync();
            if (exists)
            {
                    CloudQueueMessage recuperaArticulo = await queue.GetMessageAsync();
                    if (recuperaArticulo != null)
                    {
                        string newMessage = recuperaArticulo.AsString;
                        await queue.DeleteMessageAsync(recuperaArticulo);
                        return newMessage;
                    }
                    return "Cola de almacenamiento vacia";
            }
            else
            {
                return "Cola de almacenamiento no creada";
            }

        }
        static CloudQueue GetQueue(string nombreCola)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            return queueClient.GetQueueReference(nombreCola);
        }
    }
}
