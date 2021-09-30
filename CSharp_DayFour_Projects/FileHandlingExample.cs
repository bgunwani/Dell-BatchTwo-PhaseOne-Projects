/*using System;
using System.IO;
using System.Text;

namespace CSharp_DayFour_Projects
{
    class FileHandlingExample
    {
        static void Main(string[] args)
        {
            // Writing File: First Way
            //FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Append);
            //byte[] bdata = Encoding.Default.GetBytes("Hello Everyone");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Content written to the file Successfully.");
            //fileStream.Close();

            // Writing File: Second Way
            //using(FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Append, FileAccess.Write))
            //{
            //    using(StreamWriter streamWriter = new StreamWriter(fileStream))
            //    {
            //        streamWriter.WriteLine("Hello All");
            //        streamWriter.WriteLine("Lets Lean File Handling");
            //        Console.WriteLine("Content written to the file successfully.");
            //    }
            //}

            // Reading File: First Way
            //FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Open, FileAccess.Read);
            //StreamReader streamReader = new StreamReader(fileStream);
            //var data = streamReader.ReadToEnd();
            //Console.WriteLine(data);
            //fileStream.Close();

            // Reading File: Second Way
            //using (FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using(StreamReader streamReader = new StreamReader(fileStream))
            //    {
            //        var data = streamReader.ReadToEnd();
            //        Console.WriteLine(data);
            //    }
            //}

            //TextWriter textWriter = File.CreateText("D:\\data\\info1.txt");
            //textWriter.WriteLine("Hello World");
            //textWriter.WriteLine("Lets Learn C#");
            //textWriter.Close();

            TextReader textReader = File.OpenText("D:\\data\\info1.txt");
            // Console.WriteLine(textReader.ReadToEnd());
            char[] ch = new char[5];
            textReader.ReadBlock(ch, 0, 4);
            Console.WriteLine(ch);
            
            Console.ReadKey();
        }
    }
}
*/