using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class FileInputOutput
    {
        static void WriteToFile()
        {
            try
            {
                using(FileStream fs=new FileStream(@"D:\DOTNETJan2021batch\ConsoleApps\Assignment\Assignment\file5.txt",FileMode.Create,FileAccess.ReadWrite))
                {
                    using(StreamWriter sr=new StreamWriter(fs))
                    {
                        string s = "";
                        while(s!="stop")
                        {
                            s =Console.ReadLine();
                            if(s!="stop")
                            {
                                sr.WriteLine(s);
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadToFile()
        {
            try
            {
                using(StreamReader sr=new StreamReader(@"D:\DOTNETJan2021batch\ConsoleApps\Assignment\Assignment\file5.txt"))
                {
                    Console.WriteLine("Contents of File:"+sr.ReadToEnd());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main()
        {
            FileInputOutput.WriteToFile();
            FileInputOutput.ReadToFile();
        }
    }
}
