using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DOSA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IApplicationService" in both code and config file together.
    [ServiceContract]
    public interface IApplicationService
    {

        #region Application Action

        #region JSON
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        bool ActionJSON(string Application, string Action, string Data);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}?test",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        bool ActionJSONTest(string Application, string Action, string Data);

        #endregion

        #region XML
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml
            )]
        bool ActionXML(string Application, string Action, string Data);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}?test",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml
            )]
        bool ActionXMLTest(string Application, string Action, string Data);

        #endregion

        #endregion

    }
}
