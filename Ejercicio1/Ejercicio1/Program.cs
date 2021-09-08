using Ejercicio1.Entidad;
using Ejercicio1.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrse el valor de la compra ");
            double Compra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese un numero del 1 al 7 para definir que dia dela semana\n " +
                " tomando en cuenta que domingo es representado por el numero 1 ");
            int Dia = int.Parse(Console.ReadLine());

            ClsCompra clsCompra = new ClsCompra(Compra, Dia);

            NClsCompra nClsCompra = new NClsCompra();

            Console.WriteLine(nClsCompra.Descuento(clsCompra));
            Console.ReadLine();

        }
    }
}
