using Ejercicio1.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Negocio
{
    class NClsCompra
    {   
        public String descuento(ClsCompra Cls)
        {
            Cls.Descuento = (0.15 * Cls.Compra);
            Cls.Total1 = (Cls.Descuento - Cls.Compra);
            Cls.Total2 = (Cls.Compra);
            {
                if (Cls.Dia == martes || Cls.Dia == viernes)

            }


  
        }
            


    }
}
