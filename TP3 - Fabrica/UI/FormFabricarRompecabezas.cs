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
using Enum;
namespace UI
{
    public partial class FormFabricarRompecabezas : Form
    {
        Fabrica fabrica;
        public FormFabricarRompecabezas()
        {
            InitializeComponent();
            comBoxCantPiezas.DataSource = ECantPiezas.GetValues(typeof(ECantPiezas));
        }

        public Fabrica Fabrica
        {
            get
            {
                return fabrica;
            }
            set
            {
                fabrica = value;
            }
        }


        private void btnCrearRompecabezas_Click(object sender, EventArgs e)
        {
            try
            {
                int cantUnidades = int.Parse(txtCantUnidades.Text);
                int cantCartonesAntes = fabrica.Inventario.Carton;
                Imagen imagen = null;

                if (radioButton1.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton1.Text);
                }
                else if (radioButton2.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton2.Text);
                }
                else if (radioButton3.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton3.Text);
                }
                else if (radioButton4.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton4.Text);
                }
                else if (radioButton5.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton5.Text);
                }
                else if(radioButton6.Checked)
                {
                    imagen = Imagen.SeleccionarImagen(radioButton6.Text);
                }

                if (fabrica.CrearRompecabezas(cantUnidades, imagen, (ECantPiezas)comBoxCantPiezas.SelectedItem) && fabrica.Inventario.Cajas.Count >= cantUnidades)
                {
                    fabrica.ImprimirCajas(cantUnidades, imagen);
                    fabrica.GuardarEnCaja();
                    MessageBox.Show($"Se agregaron {cantUnidades} unidades\n" +
                        $"Se utilizaron {cantCartonesAntes - fabrica.Inventario.Carton} cartones para la producción");
                    Close();
                }
                else
                {
                    MessageBox.Show("No hay suficiente cartón para la cantidad de rompecabezas que solicito", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           catch (Exception)
            {
                MessageBox.Show("Cantidad invalida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
