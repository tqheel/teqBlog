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
        private static string stagingDir = ConfigurationManager.AppSettings["StagingDirectory"];

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
               
                string destFileName = Path.Combine(copyToDir, fileName);
                destFileName = destFileName.Replace(" ", "_");
                
                File.Copy(f, destFileName,true);
                //if file is a jpg image, then resize it
                if (Path.GetExtension(f) == "jpg")
                {
                    Resize.ResizeImage(destFileName, 25);
                }
            }

            
        }
    }
}
