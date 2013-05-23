using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DOSA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ApplicationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ApplicationService.svc or ApplicationService.svc.cs at the Solution Explorer and start debugging.
    public class ApplicationService : IApplicationService
    {

        #region Application Action

        #region Tests

        public bool ActionTest(string Application, string Action, string Data)
        {
            return true;
        }

        public bool ActionJSONTest(string Applictaion, string Action, string Data)
        {
            return this.ActionTest(Applictaion, Action, Data);
        }

        public bool ActionXMLTest(string Applictaion, string Action, string Data)
        {
            return this.ActionTest(Applictaion, Action, Data);
        }

        #endregion

        #region Functional

        public bool Action(string Application, string Action, string Data)
        {
            return true;
        }

        public bool ActionJSON(string Applictaion, string Action, string Data)
        {
            return this.Action(Applictaion, Action, Data);
        }

        public bool ActionXML(string Applictaion, string Action, string Data)
        {
            return this.Action(Applictaion, Action, Data);
        }

        #endregion

        #endregion

    }
}
