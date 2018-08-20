using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebService
{
    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        [WebGet(UriTemplate = "ShowMessage", ResponseFormat = WebMessageFormat.Json)]
        string ShowMessage();
    }
}
