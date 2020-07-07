using System;

namespace test
{

    class Program
    {
        public static double CelsjusToFarenhait(double temp)
        {                       
            return (temp * 9/5) + 32;
        }
        public static double CelsjusToKelvin(double temp)
        {
            return temp + 273.15;            
        }
        public static double CelsjusToRankine(double temp)
        { 
            return (temp * 9/5) + 491.67;
        }
        public static double FarenhaitToCelsjus(double temp)
        {
            return (temp - 32) * 5/9;
        }
        public static double FarenhaitToKelvin(double temp)
        {
            return CelsjusToKelvin(FarenhaitToCelsjus(temp));
        }
        public static double FarenhaitToRankine(double temp)
        {
            return CelsjusToRankine(FarenhaitToCelsjus(temp));
        }
        public static double KelvinToCelsjus(double temp)
        {
            return temp - 273.15;
        }
        public static double KelvinToFarenhait(double temp)
        {
            return CelsjusToFarenhait(KelvinToCelsjus(temp));
        }
        public static double KelvinToRankine(double temp)
        {
            return CelsjusToRankine(KelvinToCelsjus(temp));
        }
        public static double RankineToCelsjus(double temp)
        {
            return (temp - 491.67) * 5/9;
        }
        public static double RankineToFarenhait(double temp)
        {
            return CelsjusToFarenhait(RankineToCelsjus(temp));
        }
        public static double RankineToKelvin(double temp)
        {
            return CelsjusToKelvin(RankineToCelsjus(temp));
        }
        static void Main(string[] args)
        {
            double tem;
            tem = FarenhaitToCelsjus(10);            
            Console.WriteLine("wynik "+tem);
        }
    }
}
