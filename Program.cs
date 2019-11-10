using System;
using System.Text;
using System.IO;
using System.Collections;
using ST;
using System.Text.RegularExpressions;

namespace SouthTech
{
    enum Priority
    {
        Speed,
        Memory,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Priority priority;
            Console.WriteLine("What is your .txt file destination");
            string dest = Console.ReadLine();
            Console.WriteLine("Do you prioritze memory or speed? Memory:1|Speed:0");
            priority = Enum.Parse<Priority>(Console.ReadLine());

            while (!File.Exists(dest))
            {
                Console.WriteLine("Wrong Input:What is your .txt file destination");
                dest = Console.ReadLine();
            }
            string [] data = ReadWriteTxt.Read(dest);
            FactorySort factory = new FactorySort();
            ISort sort = factory.ChooseSort(data,priority);
            sort._data = data;
            sort.Sort();
            string NewDest = dest.Remove(dest.Length - 4) + "_sorted.txt";
            ReadWriteTxt.Write(NewDest, sort._data);
        }
    }

}