using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment
{
    class BinaryWriterClass
    {
        static void Main()
        {
            //C# BinaryWriter Class is using for write primitive types 
            //as binary values in a specific encoding stream. 
            //C# BinaryWriter Object works with Stream Objects that 
            //provide access to the underlying bytes. For creating a BinaryWriter Object , 
            //you have to first create a FileStream Object and then pass BinaryWriter to 
            //the constructor method .


            FileStream fs = new FileStream(@"d:\file5.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter b = new BinaryWriter(fs);
            int a = 19;
            string f = "We are writing Binary writer";
            b.Write(a);
            b.Write(f);
            b.Close();
            fs.Close();
            //Binary Reader
            FileStream fr = new FileStream(@"d:\file5.txt", FileMode.Open);
            BinaryReader br = new BinaryReader(fr);
            Console.WriteLine($"Binary reader content in int :{br.ReadInt32()}");
            Console.WriteLine($"Binary reader content in string:{br.ReadString()}");
            br.Close();
            //MemoryStream
            Console.WriteLine("MemoryStream-------");
           // byte[] fileContents = File.ReadAllBytes("file5.txt");
            using (MemoryStream memoryStream = new MemoryStream(a))
            {
                using (TextReader textReader = new StreamReader(memoryStream))
                {
                    string line;
                    while ((line = textReader.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            //Bufferedstream
            //Adds a buffering layer to read and write operations on another stream.
            //This class cannot be inherited.
            // The BufferedStream class can be used to either read data or write data but
            //it cannot be used to perform both read and write operations together.
        }
    }
}
