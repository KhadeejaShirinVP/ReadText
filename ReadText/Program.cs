using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Read_Textfile_Project.txt");
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);
            FileInfo fileInfo = new FileInfo(filepath);
            string files = fileInfo.Name;
            string files1 = fileInfo.Extension;
            Console.WriteLine(files);
            Console.WriteLine(files1);
            int c = 2;
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == ' ')
                    c++;
            }
            Console.WriteLine("total no of words:-" + c);
            System.IO.File.Copy(filepath, @"D:\New folder\ReadText.txt", true);
            //File.Delete(@"D:\New folder\ReadText.txt");
            //System.IO.File.Copy(@"C:\moback\readText\\Read_Textfile_Project", @"D:\New folder\ReadText.txt", true);

        }
    }
}
