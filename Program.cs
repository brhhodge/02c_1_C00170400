// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02c_1
using System;

namespace _02c_1_C00170400
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Dirt[] samples = new Dirt[10];
            PopulateDirtArray(samples);


        }

        static void PopulateDirtArray(Dirt[] d)
        {
            Random r = new Random();
            for (int i = 0; i <= d.Length; i++)
            {
                d[i] = new Dirt(  r.NextDouble() * d.Length, r.NextDouble() * d.Length );
                //Random r = new Random();
                Func<double, double, double> Total = (double x, double y) =>
                {
                    z = Total(d[i].GetSand(), d[i].GetClay());

                    
                };
                
            }

        }
    }
}
