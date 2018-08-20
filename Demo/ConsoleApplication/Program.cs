using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient proxy = new WebClient();
            string serviceURL = "http://localhost:51707/MyService.svc/showmessage";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
            string rValue = obj.ReadObject(stream) as string;

            Console.Write(rValue);
            Console.ReadKey();
        }
    }
}
