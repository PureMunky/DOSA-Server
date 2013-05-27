using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DOSA
{

    [ServiceContract]
    public interface IApplicationService
    {

        #region Application Passthrough
        // Passthrough allows DOSA to handle any existing registered applications REST services.
        // Allowing a REST call to be made without the need of defining an action.

        // URI Example: http://dosa.servername.net/ToDone
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        object PassthroughJSON(string Application, PassData DOSAData);

        #endregion

        #region Application Action

        #region JSON
        // URI Example: http://dosa.servername.net/ToDone/CreateTask
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        bool ActionJSON(string Application, string Action);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}?test",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        bool ActionJSONTest(string Application, string Action);

        #endregion

        #region XML
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}/xml",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml
            )]
        bool ActionXML(string Application, string Action);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "{Application}/{Action}/xml?test",
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml
            )]
        bool ActionXMLTest(string Application, string Action);

        #endregion

        #endregion

    }

}
