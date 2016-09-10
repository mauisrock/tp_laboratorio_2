using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList; //Elimina la entrada de datos del ComboBox
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.Text = "";
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            Numero primerOp = new Numero(txtNumero1.Text);
            Numero segundoOp = new Numero(txtNumero2.Text);

            string operador;
            double resultado = 0;

            operador = calculadora.validarOperador(cmbOperacion.Text);
            resultado = calculadora.operar(primerOp, segundoOp, operador);
            lblResultado.Text = calculadora.operar(primerOp, segundoOp, operador).ToString();

            if (resultado.ToString() == double.PositiveInfinity.ToString()) //Si hubo división por 0,
                lblResultado.Text = "Error";                                //Escribo "Error" en el label de resultado.
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
