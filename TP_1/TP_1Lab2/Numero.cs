using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1Lab2
{
    class Numero
    {
        private double _num;

        public Numero()
        {
            this._num = 0;
        }

        public Numero(double numero)
        {
            this._num = numero;
        }

        private void setNumero(string numero)
        {
            this._num = validarNumero(numero);
        }

        public Numero(string numero)
        {
            setNumero(numero);
        }

        public double getNumero()
        {
            return this._num;
        }

        private double validarNumero(string numero)
        {
            double num = 0;
            double.TryParse(numero, out num);
            return num;
        }
    }
}
