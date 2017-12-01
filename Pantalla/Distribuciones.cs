using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public enum _Distribucion
    {
        Uniforme, Normal, Poisson, Exponencial
    }
    public class Distribuciones
    {
        public static double Uniforme(double a, double b, double rnd)
        {
            double x = 0;
            x = a + (b - a) * rnd;
            return x;
        }

        public static double Exponencial(double lambda, double rnd)
        {
            double x = 0;
            x = Math.Log(1 - rnd) / (-lambda);
            return x;
        }

        public static double[] Normal(double mu, double sigma, double rnd1, double rnd2)
        {
            double[] numeros = new double[2];

            double x1 = 0;
            double x2 = 0;

            x1 = Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2) * sigma + mu;
            numeros[0] = x1;

            x2 = Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2) * sigma + mu;
            numeros[1] = x2;

            return numeros;
        }
    }
}

