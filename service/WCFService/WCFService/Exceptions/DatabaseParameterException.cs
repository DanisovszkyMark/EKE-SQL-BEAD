using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Exceptions
{
    public class DatabaseParameterException : Exception
    {
        public override string Message
        {
            get
            {
                return "Hiba az adatbázis utasítás paraméterezésében.";
            }
        }
    }
}