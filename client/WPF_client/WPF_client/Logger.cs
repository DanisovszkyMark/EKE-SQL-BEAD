using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace WPF_client
{
    public static class Logger
    {
        private static string filename = ConfigurationManager.AppSettings["filenameForLogger"].ToString();
        private static string doctype = ConfigurationManager.AppSettings["documentTypeForLogger"].ToString();

        private static StreamWriter sw;
        private static bool opened = false;

        public static void Log(string message)
        {
            if (sw == null)
            {
                sw = new StreamWriter(filename + doctype, true);
                sw.WriteLine("///// Log /////");
                sw.WriteLine("Time \t\t\t| Message");
                opened = true;
            }
            else if (!opened) sw = new StreamWriter(filename + doctype, true);

            sw.WriteLine(DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString() + "\t| " + message);

            sw.Close();
            opened = false;
        }
    }
}
