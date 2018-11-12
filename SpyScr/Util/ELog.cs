using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyScr.Util
{
    public static class ELog
    {
        public static void Save(object obj, Exception ex)
        {
            string fecha = System.DateTime.Now.ToString("yyyyMMdd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string Path = ConfigurationManager.AppSettings["Path"].ToString();
            string path = $@"{Path}\log\{fecha}.txt";

            StreamWriter sw = new StreamWriter(path, true);

            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(obj.GetType().FullName + " " + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }

        public static void SaveString(string titulo, string mensaje)
        {
            string fecha = System.DateTime.Now.ToString("yyyyMMdd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string Path = ConfigurationManager.AppSettings["Path"].ToString();
            string path = $@"{Path}\log\{fecha}.txt";

            StreamWriter sw = new StreamWriter(path, true);

            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(titulo + " " + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + mensaje);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}
