using System;

namespace Ejercicio1DeFrancoCastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinacion de las variables
            decimal pesos = 230, euros = 1.17M, dolares, conversion;
            //Carga de datos
            try 
            {
                Console.WriteLine("Ingrese la cantidad de dolares que dispone para comprar pesos");
                dolares = decimal.Parse(Console.ReadLine());
                //Conversion a pesos en el mercado oficial
                conversion = dolares * pesos;
                Console.WriteLine($"Usted puede comprar ${conversion} en el mercado oficial");
                //Conversion a pesos en el mercado paralelo
                conversion = dolares * (pesos+50);
                Console.WriteLine($"Usted puede comprar ${conversion} en el mercado paralelo");
                //Conversion a euros
                conversion = dolares * euros;
                Console.WriteLine($"Ustedes puede comprar {conversion} euros");

            }
            catch {Console.WriteLine("Informacion no valida"); }  
        }
    }
}
