using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL5_103022400122
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            String nama = "Albert";
            halo.SapaUser(nama);
            Console.ReadLine();
        }
    }
}
