using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL5_103022400122
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String nim = "103022400122";
            DataGeneric<String> data = new DataGeneric<string>(nim);
            data.PrintData();
            Console.ReadLine();
        }
    }
}
