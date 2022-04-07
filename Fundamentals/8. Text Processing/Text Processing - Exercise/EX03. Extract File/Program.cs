using System;
using System.Collections.Generic;
using System.Linq;

namespace EX03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //string[] fileInfo = input
            //    .Split('\\')
            //    .Last()
            //    .Split('.')
            //    .ToArray();
            //string fileName = string.Join(".", fileInfo
            //    .Take(fileInfo.Length - 1));
            //string fileExtension = fileInfo.Last();

            string fileINfo = input.Substring(input.LastIndexOf('\\') + 1);
            int dotIndex = fileINfo.LastIndexOf('.');
            string fileName = fileINfo.Substring(0, dotIndex);
            string fileExtension = fileINfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
