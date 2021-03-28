using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Data
{
    public class ConnectionString
    {
        static string account = CloudConfigurationManager.GetSetting("ffkstorage");
        static string key = CloudConfigurationManager.GetSetting("StorageAccountKey");
       

        public static CloudStorageAccount GetConnectionString()
        {
            string connectionString = string.Format($"DefaultEndpointsProtocol=https;AccountName={account};AccountKey={key}");
            return CloudStorageAccount.Parse(connectionString);
        }

    }
}
