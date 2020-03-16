using System;
using System.IO;

namespace Practice_CopyBinFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Source file path:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter destination file path: ");
            string dest = Console.ReadLine();
            try
            {
                StreamCopyFile(source, dest);
                Console.WriteLine("File is successfully copied");
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("Invalid Source path or Destination path");
            }
        }

        static void StreamCopyFile(string source, string dest)
        {
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source);
                writer = new StreamWriter(dest);
                int length;
                char[] buffer = new char[1024];
                while((length = reader.Read(buffer)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("Invalid input or output path");
            }
            finally
            {
                reader.Close();
                writer.Close();
            }
        }
    }
}
