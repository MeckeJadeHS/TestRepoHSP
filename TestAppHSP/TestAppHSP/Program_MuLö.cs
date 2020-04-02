using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppHSP
{
    class Program
    {
        #region Global Lokal Variablen 

        Double globaleVariable = 9.5;
        Double unklareVariable = 8;

        static public void GlobalLokalVars()
        {
            Double lokaleVariable = 5.0;  // eine lokale Variable
            Double unklareVariable = 4;   // global oder lokal?

            Console.WriteLine("Wert von lokaleVariable: " + lokaleVariable);
            Console.WriteLine("Wert von unklareVariable: " + unklareVariable);
        }
        #endregion

        #region VL4_Fkt
        static public void VL4_Funktionen()
        {
            // Funktionsaufruf 
            int a_int = Plus(2, 3);
            float a_float = Plus(2.0f, 3.0f);
        }

        /* Plus Alternativen
        static public int Plus(int x, int y)
        {
            return Plus(x, y, 0);
        }

        static public int Plus(int x, int y, int z)
        {
            return x + y + z;
        }
        */

        static public int Plus(int x, int y, int z = 0)
        {
            return x + y + z;
        }

        static public float Plus(float x, float y)
        {
            return x + y;
        }
        #endregion

        static void Main(string[] args)
        {
            GlobalLokalVars();
            VL4_Funktionen();
        }

    }
}
