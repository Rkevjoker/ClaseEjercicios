using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidad
{
    class ClsCompra
    {
        private int dia;
        private double compra;
        private double descuento;
        private double total;

        public ClsCompra()
        {
        }

        public ClsCompra(double compra, int dia)
        {
            this.compra = compra;
            this.dia = dia;
        }

        public ClsCompra(int dia, double compra, double descuento, double total)
        {
            this.Dia = dia;
            this.Compra = compra;
            this.Descuento = descuento;
            this.Total = total;
        }

        public int Dia { get => dia; set => dia = value; }
        public double Compra { get => compra; set => compra = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Total { get => total; set => total = value; }
    }
}
