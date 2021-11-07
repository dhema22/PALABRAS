using System;
using System.Collections.Generic;
using System.Text;

namespace PALABRAS
{
    class Program
    {
        private static char b;

        static void Main()
        {
            MayusculaMinuscula();
            PmayusculaPminuscula();
            EspacioentreLetras();
        }

        public static void MayusculaMinuscula()
        {
            string palabra1;
            string palabraM;
            string palabraminuscula;
            Console.Write("Ingrese palabra: ");
            palabra1 = Console.ReadLine();
            palabraM = palabra1.ToUpper();
            palabraminuscula = palabra1.ToLower();
            Console.WriteLine("modificado a mayuscula, {0}, modificado a minusculas, {1}.", palabraM, palabraminuscula);
            Console.WriteLine("\t");
        }

        public static void PmayusculaPminuscula()
        {
            string firstcapital;
            string primeraletra;
            string primeramayuscula;
            string restopalabra;
            string primeraminuscula;
            int conteo;
            Console.Write("Ingrese palabra para modificación de la primera letra: ");
            firstcapital = Console.ReadLine();
            primeraletra = firstcapital.Substring(0, 1);
            primeraletra = primeraletra.ToUpper();
            firstcapital = firstcapital.Remove(0, 1);
            conteo = firstcapital.Length;
            restopalabra = firstcapital.Substring(0,firstcapital.Length);
            restopalabra = restopalabra.ToLower();
            primeramayuscula = primeraletra + restopalabra;
            Console.WriteLine("La palabra con la primera letra en mayuscula es: {0}", primeramayuscula);
            primeraletra = primeraletra.ToLower();
            restopalabra = restopalabra.ToUpper();
            primeraminuscula = primeraletra + restopalabra;
            Console.WriteLine("La palabra con la primera letra en minúscula es: {0}", primeraminuscula);
            Console.WriteLine("\t");

        }

        public static void EspacioentreLetras()
        {
            string añade;
            int longitud;
            Console.Write("Ingrese palabra para añadir espacios:");
            añade = Console.ReadLine();
            longitud = añade.Length;
            Console.WriteLine(añade.Replace(añade.Substring(0,longitud), " "));
        }
    }

    //crea un espacio blanco que va recorriendo el string hasta el final 
    //List<string> espacio = new List<string>() { };
    //for(int i = 1; i <= longitud; i++)
    //{
    //    añadeespacio = añade.Insert(i, " ");
    //    espacio.Add(añadeespacio);
    //}
    //espacio.ForEach(i => Console.WriteLine("{0}", i));
}
