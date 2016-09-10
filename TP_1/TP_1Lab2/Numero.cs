using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1Lab2
{
    class Numero
    {
        private double num;

        public Numero()
        {
            this.num = 0;
        }

        public Numero(double numero)
        {
            this.num = numero;
        }

        private void setNumero(string numero)
        {
            this.num = validarNumero(numero);
        }

        public Numero(string numero)
        {
            setNumero(numero);
        }

        public double getNumero()
        {
            return this.num;
        }

        private double validarNumero(string numero)
        {
            double num = 0;
            double.TryParse(numero, out num);
            return num;
        }
    }
}
