using System;

namespace test
{

    class Program
    {
        public const double CTF = 32.0;
        public const double NBF = 9.0/5;
        public const double FBN = 5.0/9;
        public const double K0 = 273.15;
        public const double RC = 491.67;

      
        public static double CelsjusToFarenhait(double temp)
        {                       
            return (temp * NBF) + CTF;
        }
        public static double CelsjusToKelvin(double temp)
        {
            return temp + K0;            
        }
        public static double CelsjusToRankine(double temp)
        { 
            return (temp * NBF) + RC;
        }
        public static double FarenhaitToCelsjus(double temp)
        {
            return (temp - CTF) * FBN;
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
            return temp - K0;
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
            return (temp - RC) * FBN;
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
            Char TemperatureImputType = 'C';
            Double TemperatureImputValue = 0;
            do
            {
                Console.WriteLine("wybierz jednostek temperatury : \n" +
                    "C - Celsjus \n" +
                    "F - Farenhait \n" +
                    "K - Kelvin \n" +
                    "R - Ten co pierwsze slysze XD \n:"
                    );

                TemperatureImputType = Console.ReadLine()[0];

            } while (   TemperatureImputType != 'C' && 
                        TemperatureImputType != 'F' &&
                        TemperatureImputType != 'K' &&
                        TemperatureImputType != 'R' && 
                        TemperatureImputType != 'c' &&                        
                        TemperatureImputType != 'f' &&                       
                        TemperatureImputType != 'k' &&                       
                        TemperatureImputType != 'r'
                        );
            Console.WriteLine("Podaj wartosc temperatury :\n" + TemperatureImputType + " :");
            TemperatureImputValue = Double.Parse(Console.ReadLine());

            switch (TemperatureImputType)
            {
                case 'c':
                case 'C':
                    {
                        Console.WriteLine(
                            "Temperatura wynosi :" +
                            "\nF : " + CelsjusToFarenhait(TemperatureImputValue) +
                            "\nK : " + CelsjusToKelvin(TemperatureImputValue) +
                            "\nR : " + CelsjusToRankine(TemperatureImputValue)
                            );
                        break;
                    }
                case 'f':
                case 'F':
                    {
                        Console.WriteLine(
                            "Temperatura wynosi :" +
                            "\nC : " + FarenhaitToCelsjus(TemperatureImputValue) +
                            "\nK : " + FarenhaitToKelvin(TemperatureImputValue) +
                            "\nR : " + FarenhaitToRankine(TemperatureImputValue)
                            );
                        break;
                    }
                case 'k':
                case 'K':
                    {
                        Console.WriteLine(
                            "Temperatura wynosi :" +
                            "\nC : " + KelvinToCelsjus(TemperatureImputValue) +
                            "\nF : " + KelvinToFarenhait(TemperatureImputValue) +
                            "\nR : " + KelvinToRankine(TemperatureImputValue)
                            );
                        break;
                    }
                case 'r':
                case 'R':
                    {
                        Console.WriteLine(
                            "Temperatura wynosi :" +
                            "\nC : " + RankineToCelsjus(TemperatureImputValue) +
                            "\nF : " + RankineToFarenhait(TemperatureImputValue) +
                            "\nK : " + RankineToKelvin(TemperatureImputValue)
                            );
                        break;
                    }
            }
        }
    }
}
