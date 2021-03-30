using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace workingWithImages
{
    class Program
    {
        static void Main(string[] args)
        {
        	string imageFolder = Path.Combine(
		  Environment.CurrentDirectory, "images");

		IEnumarable<string> images = 
		  Directory.EnumarateFiles(imagesFolder);

		foreach(string imagePath in images)
		{
			string.thumbnailPath = Path.Combine(
			  Environment.CurrentDirectory, "images",
		       	  Path.GetFileWithoutExtension(imagePath)
			  + "-thumbnail" + Path.GetExtension(imagePath));
		
			using  (Image image = Image.Load(imagePath))
			{
				image.Mutate(x => x.Resize(image.width
			}
		}

	}
    }
}
