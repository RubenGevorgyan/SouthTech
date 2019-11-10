using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ST
{
    static class ReadWriteTxt
    {
        public static  string[] Read(string dest)
        {
            
            return File.ReadAllLines(dest);
        }

        public static  void Write(string dest,string[] data)
        {
            File.WriteAllLines(dest, data);
        }
    }
}
