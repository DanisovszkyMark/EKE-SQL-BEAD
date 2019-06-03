using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Exceptions
{
    public class DatabaseConnectionException : Exception
    {
        public override string Message
        {
            get
            {
                return "Hiba a szerver kapcsolatban.";
            }
        }
    }
}