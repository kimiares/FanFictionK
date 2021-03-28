using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using FFK.Data;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure;

namespace FFK.Services
{
    public  class UploadingPhotos
    {
        public static void UploadImage(string path, string filename)
        {
             string account = "ffkstorage";
             string key = "6p9tgJIIWyijBxnBw+MBu6+SgQA/2wWtRmblieNajx7Q8c1x6n2ZsEAukxVfO20A17HcYc3TIs3oRQba//GpSg==";



            var fileBytes = System.IO.File.ReadAllBytes(path + filename);
            var cloudStorageAccount = CloudStorageAccount.Parse(key);
        }

    }
}
