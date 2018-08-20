using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization.Json;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            WebClient proxy = new WebClient();
            string serviceURL = "http://localhost:51707/MyService.svc/showmessage";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
            string rValue = obj.ReadObject(stream) as string;

            Console.Write(rValue);
        }

       
        
        
    }
}
