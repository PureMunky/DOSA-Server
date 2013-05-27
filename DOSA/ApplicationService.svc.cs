using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DOSA
{
    
    public class ApplicationService : IApplicationService
    {

        #region Application Passthrough
        // Passthrough allows DOSA to handle any existing registered applications REST services.
        // Allowing a REST call to be made without the need of defining an action.

        public object PassthroughJSON(string Application, PassData DOSAData)
        {
            Application a = new Application();
            a.Name = Application;
            
            //Application["DOSARoot"] + a.URI //TODO: fire a local REST call.
            

            return new object();
        }

        #endregion

        #region Application Action

        #region Tests

        public bool ActionTest(string Application, string Action)
        {
            return true;
        }

        public bool ActionJSONTest(string Applictaion, string Action)
        {
            return this.ActionTest(Applictaion, Action);
        }

        public bool ActionXMLTest(string Applictaion, string Action)
        {
            return this.ActionTest(Applictaion, Action);
        }

        #endregion

        #region Functional

        public bool Action(string Application, string Action)
        {
            return true;
        }

        public bool ActionJSON(string Applictaion, string Action)
        {
            return this.Action(Applictaion, Action);
        }

        public bool ActionXML(string Applictaion, string Action)
        {
            return this.Action(Applictaion, Action);
        }

        #endregion

        #endregion

    }

}
