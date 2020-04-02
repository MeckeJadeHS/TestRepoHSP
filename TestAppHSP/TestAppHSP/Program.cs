using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHSP
{
    class Program
    {
        static int zweiterSummand = 2;

        static void StringOps()
        {
            String myStr = "Hallo Thalea";
            int ii = myStr.Length;
            double myDouble = 0.5d;
            String nextStr = myStr.Replace("Thalea", "Theo");
            // myStr = myStr.Replace("Thalea", "Theo");

            String[] strArray = myStr.Split('a');

            // Console.WriteLine(String.Format("Testausgabe: {0:00.00}", myDouble));
            // Console.ReadKey();
        }

        #region Summe
        public static void VL4_Funktionen()
        {
            int summe = Plus(3, 4);
            summe = Plus(3, 4, 5);
            summe = Plus(3);
        }

        private static int Plus(int v1, int v2 , int v3 = 0)
        {
            return v1 + v2 + v3;
        }

        private static int Plus(int summand1)
        {
            int res = 0;
            res = summand1 + zweiterSummand;
            return res;
        }
        #endregion

        static void Main(string[] args)
        {
            StringOps();
            // VL4_Funktionen();
        }



    }
}
