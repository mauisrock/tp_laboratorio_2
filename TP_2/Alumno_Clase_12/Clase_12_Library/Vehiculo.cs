﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }

        EMarca _marca;
        string _patente;
        ConsoleColor _color;

        // <summary>
        // Retornará la cantidad de ruedas del vehículo
        // </summary>
        public abstract short CantidadRuedas { get; }
        /// <summary>
        /// Constructor de Vehiculo.
        /// </summary>
        /// <param name="marca">Marca del Vehiculo</param>
        /// <param name="patente">Patente del Vehiculo</param>
        /// <param name="color">Color del Vehiculo</param>
        public Vehiculo(EMarca marca, string patente, ConsoleColor color)
        {
            this._color = color;
            this._marca = marca;
            this._patente = patente;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (v1._patente.Equals(v2._patente))
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}