using ejercicio_3.Entidades;
using ejercicio_3.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero = new Cajero();
            NClsCajero nClsCajero = new NClsCajero();

            Console.WriteLine("Escriba 1 si quiere sacar dinero ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Cajero dinero = new Cajero(cantidad);

            Console.WriteLine(nClsCajero.Ciclo(dinero));
        }
    }
}
