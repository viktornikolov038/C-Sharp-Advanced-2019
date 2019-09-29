using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams_Demo
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var fileNameAndPath = "../../text.txt";
            var encoding = Encoding.UTF8;
            var append = true;
            var stream = new StreamWriter(fileNameAndPath,append,encoding);
            using (stream)
            {
                stream.AutoFlush = true;
                stream.WriteLine("Next Line");
            }
            
        }
    }
}
