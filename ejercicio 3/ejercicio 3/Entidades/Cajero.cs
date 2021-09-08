using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3.Entidades
{
    class Cajero
    {
        private int valor;

        public Cajero()
        {
        }

        public Cajero(int valor)
        {
            this.valor = valor;
        }

        public int Valor { get => valor; set => valor = value; }
    }
}
