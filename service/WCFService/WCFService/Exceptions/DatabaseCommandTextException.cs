using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Exceptions
{
    public class DatabaseCommandTextException : Exception
    {
        public override string Message
        {
            get
            {
                return "Hiba az adatbázis utasítás felépítésében";
            }
        }
    }
}