using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSA
{
    [Serializable]
    public class User
    {
        public string Name;
        public string Server; // TODO: create DOSA Server Object
        public int ID; // PK
    }
}