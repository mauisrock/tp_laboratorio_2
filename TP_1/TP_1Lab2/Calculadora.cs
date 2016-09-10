using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1Lab2
{
    class Calculadora
    {
        public double operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1.getNumero() + num2.getNumero();
                    break;
                case "-":
                    resultado = num1.getNumero() - num2.getNumero();
                    break;
                case "*":
                    resultado = num1.getNumero() * num2.getNumero();
                    break;
                case "/":
                    if (num2.getNumero() == 0)
                        resultado = double.PositiveInfinity;
                    else
                        resultado = num1.getNumero() / num2.getNumero();
                    break;
            }
            return resultado;
        }

        public string validarOperador(string operador)
        {
            string valido = operador;

            switch (operador)
            {
                case "-":
                    valido = "-";
                    break;
                case "*":
                    valido = "*";
                    break;
                case "/":
                    valido = "/";
                    break;
                default:
                    valido = "+";
                    break;
            }

            return valido;
        }

    }
}
