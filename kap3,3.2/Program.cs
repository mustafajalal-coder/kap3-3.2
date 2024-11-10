using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kap3_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("´har du gått ut gymnasiet? (j/n);");
            string gymnasiestatus = Console.ReadLine().ToLower();

            Console.Write("hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiestatus == "j" && ålder < 22)

            {
                Console.WriteLine("vi vill gärna anställa dig ");


            }
            else
            {
                Console.WriteLine("vi letar efter någon annan personal just nu, tyvärr");
            }



        }
           
    }   
}
