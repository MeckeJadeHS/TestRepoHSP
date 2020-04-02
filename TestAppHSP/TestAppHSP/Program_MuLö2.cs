using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHSP
{
    class Program
    {
        static int derSummand = 2;

        private static void VL4_Funktionen()
        {
            int summe = Plus(3);
            summe = Plus(3, 4);
            summe = Plus(3, 4, 5);
        }

        private static int Plus(int v)
        {
            return v + derSummand;
        }

        private static int Plus(int v1, int v2, int v3 = 0)
        {
            return v1 + v2 + v3;
        }


        static void Main(string[] args)
        {
            VL4_Funktionen();
        }

    }
}