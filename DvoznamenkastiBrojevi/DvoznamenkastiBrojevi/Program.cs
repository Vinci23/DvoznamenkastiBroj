using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvoznamenkastiBrojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prviBroj = 0;
            int drugiBroj = 0;
            int treciBroj = 0;
            Console.WriteLine("Unesi tri dvoznamenkasta broja:" + "\n");


            prviBroj = Convert.ToInt32(Console.ReadLine());
            drugiBroj = Convert.ToInt32(Console.ReadLine());
            treciBroj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ");

            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine(prviBroj);
            }


            if (drugiBroj > treciBroj && drugiBroj > prviBroj)
            {
                Console.WriteLine(drugiBroj);
            }

            if (treciBroj > drugiBroj && treciBroj > prviBroj)
            {
                Console.WriteLine(treciBroj);
            }




            Console.ReadKey();
        }
    }
}
