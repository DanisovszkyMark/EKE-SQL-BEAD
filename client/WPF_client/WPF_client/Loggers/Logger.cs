﻿using System;
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

        public static void Log(string logType, string message)
        {
            try
            {
                if (sw == null)
                {
                    sw = new StreamWriter(filename + doctype, true);
                    sw.WriteLine("///// Log /////");
                    sw.WriteLine("Time \t\t\t| LogType \t| Message");
                    opened = true;
                }
                else if (!opened) sw = new StreamWriter(filename + doctype, true);

                sw.WriteLine(DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString() + "\t| [" + logType + "]\t|" + message);

                sw.Close();
                opened = false;
            }
            catch (Exception)
            {

            }
        }

        public static void Info(string message)
        {
            Log("INFO", message);
        }

        public static void Error(string message)
        {
            Log("ERROR", message);
        }

        public static void Close()
        {
            sw.Close();
        }

        /// <summary>
        /// Only if the logger was once used
        /// </summary>
        public static void OpenAgain()
        {
            sw = new StreamWriter(filename + doctype, true);
        }
    }
}
