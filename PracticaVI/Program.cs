using System;
using System.Collections.Generic;

namespace PracticaVI
{
    delegate bool MiDelegado(int numero);
    class Program
    {
        private static List<int> _listadoDeNumeros = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Listado de números");
            _listadoDeNumeros.Pares().ForEach(r => Console.WriteLine(r));
            Console.ReadKey();
        }

        public bool EsImPar(int num)
        {
            return (num % 2) != 0;
        }

        public double CalcularITBIS(double precio)
        {
            return (precio * 18) / 100;
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
