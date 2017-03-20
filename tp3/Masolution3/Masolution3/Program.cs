using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masolution3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dossiers = System.IO.Directory.GetDirectories(@"C:\");
            foreach(var dossier in dossiers)
            {
                Console.WriteLine(dossier);
            }
            Console.Read();
        }
    }
}
