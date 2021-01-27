using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string user1= "";
           

            while (user1!="stop")
            {
               

                Console.WriteLine("Please enter content of the file.....");

                string user = Console.ReadLine();
                File.AppendAllText("static.txt", user);
                 //File.WriteAllText("static.txt", user);
                Console.WriteLine("Contents of the file : " + File.ReadAllText("static.txt"));
                // File.AppendText("static.txt");
                //IEnumerable<string> f = File.ReadLines("static.txt");
                //foreach(var v in f)
                //{
                //    Console.WriteLine($"{v}");
                //}
                //Console.WriteLine("New content to be appended");
                //string user2 =Console.ReadLine();
                // File.OpenWrite("static.txt");
                Console.WriteLine("Do you want to continue/stop:");
                user1 = Console.ReadLine();

            }
            Console.WriteLine("GoodBye....");
        }
    }
}
