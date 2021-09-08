using ejercicio_3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3.Negocio
{
    class NClsCajero
    {
        public String Ciclo(Cajero monto)
        {

            while (monto.Valor == 1)
            {
                Console.WriteLine("Digite la cantidad a retirar");
                int x = Convert.ToInt32(Console.ReadLine());


                if (x % 5 == 0)
                {
                    Console.WriteLine("su trnsaccion a sido aprobada\n"+
                        "el monto a retirar es de " +monto.Valor);

                    Console.WriteLine("pulse 0 si desea terminar, si desea continuar presione cualquier numero");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 0)
                    {
                        monto.Valor = monto.Valor + 1;
                    }

                    else
                    {
                        monto.Valor = monto.Valor;
                    }
                }
                else
                {

                    Console.WriteLine("no se puede realizar la transaccion solicitada");

                    Console.WriteLine("pulse la tecla2 para salir, si desea continuar presione cualquier otro número");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 2)
                    {
                        monto.Valor = monto.Valor + 1;
                    }

                    else
                    {
                        monto.Valor = monto.Valor;
                    }
                }

            }
            return "";

        }
    }
}
