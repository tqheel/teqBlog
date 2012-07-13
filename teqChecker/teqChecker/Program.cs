using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.Net.Configuration;
using System.IO;
using System.Web;

namespace teqChecker
{
    class Program
    {
        private static string monitorDir = ConfigurationManager.AppSettings["DirectoryToMonitor"];
        private static string copyToDir = ConfigurationManager.AppSettings["CopyToDirectory"];

        static void Main(string[] args)
        {
            //Check monitored folder and move all files to images folder
            if (!Directory.Exists(copyToDir))
            {
                //Create the target directory if it does not exist
                Directory.CreateDirectory(copyToDir);
            }
            string[] files = Directory.GetFiles(monitorDir);
            foreach (string f in files)
            {
                string fileName = Path.GetFileName(f);
                fileName += fileName.Replace(" ", "_");
                string destFileName = Path.Combine(copyToDir, fileName);
                File.Copy(f, destFileName,false);
            }

            
        }
    }
}
