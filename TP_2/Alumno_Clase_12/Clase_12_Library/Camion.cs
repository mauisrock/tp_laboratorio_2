﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clase_12_Library_2;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Camion : Vehiculo
    {
        public Camion(Vehiculo.EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color)
        {
        }
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>
        public override short CantidadRuedas
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Muestra las caracteristicas de camion
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}