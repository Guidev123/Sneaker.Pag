using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker.Pag
{
    public class SneakerPagService
    {
        public readonly string ApiKey;
        public readonly string EncryptionKey;

        public SneakerPagService(string apiKey, string encryptionKey)
        {
            ApiKey = apiKey;
            EncryptionKey = encryptionKey;
        }
    }
}
