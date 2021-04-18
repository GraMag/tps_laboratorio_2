using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la operacion solicitada y activa el boton "Convertir a Binario"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString("0.##");
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirABinario.BackColor = Color.HotPink;
            this.btnConvertirABinario.ForeColor = Color.Crimson;
        }

        /// <summary>
        /// Llama al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el programa, consultandole previamente al usuario si esta seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult restult = MessageBox.Show("Esta seguro que desea cerrar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
            if(restult == DialogResult.OK)
            {
                this.Close();   
            }
        }

        /// <summary>
        /// Reinicia todos los parametros y bloquea los botons de conversion
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.txtNumero2.Clear();
            this.lblResultado.Text = string.Empty;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.BackColor = Color.Crimson;
            this.btnConvertirABinario.ForeColor = Color.HotPink;
            this.btnConvertirADecimal.BackColor = Color.Crimson;
            this.btnConvertirADecimal.ForeColor = Color.HotPink;
        }

        /// <summary>
        /// Toma los datos ingresados en la calculadora para realizar la operacion
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        /// <summary>
        /// Convierte el resultado de la operacion de numero decimal a numero binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = true;
            this.btnConvertirABinario.BackColor = Color.Crimson;
            this.btnConvertirABinario.ForeColor = Color.HotPink;
            this.btnConvertirADecimal.BackColor = Color.HotPink;
            this.btnConvertirADecimal.ForeColor = Color.Crimson;
        }

        /// <summary>
        /// Reconvierte el numero convertido a binario en un numero decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.BackColor = Color.HotPink;
            this.btnConvertirABinario.ForeColor = Color.Crimson;
            this.btnConvertirADecimal.BackColor = Color.Crimson;
            this.btnConvertirADecimal.ForeColor = Color.HotPink;

        }
    }   
}
