using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidad
{
    class ClsCompra
    {
        private string dia;
        private double compra;
        private double descuento;
        private double total1;
        private double total2;

        public ClsCompra(string dia, double compra, double descuento, double total1, double total2)
        {
            this.Dia = dia;
            this.Compra = compra;
            this.Descuento = descuento;
            this.Total1 = total1;
            this.Total2 = total2;
        }

        public string Dia { get => dia; set => dia = value; }
        public double Compra { get => compra; set => compra = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Total1 { get => total1; set => total1 = value; }
        public double Total2 { get => total2; set => total2 = value; }
    }
}
