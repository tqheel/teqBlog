﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace teqChecker
{
    class Resize
    {
        /// <summary>
        /// method for resizing an image
        /// ***Adapted from PsycoCoder's snippet at: http://www.dreamincode.net/code/snippet1986.htm (Thanks!)
        /// </summary>
        /// <param name="img">the image to resize</param>
        /// <param name="percentage">Percentage of change (i.e for 105% of the original provide 105)</param>
        /// <returns></returns>
        public static void ResizeImage(string sourcefileName, string destinationFileName, int percentage)
        {
            Image img = Image.FromFile(sourcefileName);
            //get the height and width of the image
            int originalW = img.Width;
            int originalH = img.Height;

            //get the new size based on the percentage change
            int resizedW = originalW * percentage/100;
            int resizedH = originalH * percentage/100;

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            Console.WriteLine("Saving resized image: " + destinationFileName);
            bmp.Save(destinationFileName,ImageFormat.Jpeg);
        }

    }
}
