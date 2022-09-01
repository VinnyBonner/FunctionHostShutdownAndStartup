using System;
using System.IO;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HostShutdownStartupExample
{
    public class BlobTrigger1
    {
        [FunctionName("BlobTrigger1")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "BlobStorageConStr")]Stream myBlob, string name, CancellationToken cancellationToken, ILogger log)
        {
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    log.LogInformation("A cancellation token was received. Taking precautionary actions.");
                    //Take precautions like noting how far along you are with processing the batch

                    // Send notification via email or http request

                    // Log cancellation is happening in a table storage                    

                    log.LogInformation("Precautionary activities --complete--.");
                }
                else
                {
                    //business logic as usual
                    log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
                    //Do Stuff
                }
            }
            catch (Exception ex)
            {
                log.LogError($"Something unexpected happened: {ex.Message}");
                throw;
            }
        }
    }
}
