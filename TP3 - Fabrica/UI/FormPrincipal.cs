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

namespace UI
{
    public partial class FormPrincipal : Form
    {
        Fabrica fabrica;

        public string Fabrica
        {
            get
            {
                return fabrica.Nombre;
            }
            set
            {
                fabrica.Nombre = value;
            }
        }

        public FormPrincipal()
        {
            try
            {
                InitializeComponent();
                
                fabrica = new Fabrica(); 
                lblNombre.Text = fabrica.Nombre;
                richTxtBoxStock.ReadOnly = true;
                lblCantCartonesStock.Text = $"Hay {fabrica.Inventario.Carton} cartones disponibles";
                panelFabricarCajas.Hide();
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Fabrica de rompecabezas.txt";
                Archivos archivos = new Archivos(ruta);
                richTxtBoxStock.Text = archivos.Leer();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para guardar en la ubicación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.FileNotFoundException)
            {
                richTxtBoxStock.Text = fabrica.Inventario.ToString();
            }
            catch (Exception)
            {
              MessageBox.Show("Sucedio un error inesperado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Al tocar el botón se agregan cartones a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAgregarCarton_Click(object sender, EventArgs e)
        {
            int.TryParse(txtBoxCantCarton.Text, out int cantidad);
            if (!fabrica.Inventario.AgregarCarton(cantidad))
            {
                MessageBox.Show("Cantidad invalida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblCantCartonesStock.Text = $"Hay {fabrica.Inventario.Carton} cartones disponibles";
            richTxtBoxStock.Text = fabrica.Inventario.ToString();
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            Volver(false);
            labelNumCajas.Text = $"Hay {fabrica.Inventario.Cajas.Count} cajas vacias.";
            richTxtBoxStock.Text = fabrica.Inventario.ToString();
        }

        private void btnRompecabezas_Click(object sender, EventArgs e)
        {
            FormFabricarRompecabezas puzzles = new FormFabricarRompecabezas();
            puzzles.Fabrica = fabrica;
            puzzles.ShowDialog();
            fabrica = puzzles.Fabrica;
            this.lblCantCartonesStock.Text = $"Hay {fabrica.Inventario.Carton} cartones disponibles";
            richTxtBoxStock.Text = fabrica.Inventario.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHacerCajas_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxCantCajas.Text, out int cantidad);
            DialogResult respuesta = DialogResult.OK;
            if (cantidad > 1)
            {
                if (cantidad % 2 != 0)
                {
                    respuesta = MessageBox.Show($"No es posible hacer {cantidad} cajas. \nDesea fabricar {cantidad - 1}?", "Cantidad impar!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                if (respuesta == DialogResult.OK)
                {
                    int cajas = fabrica.ArmarCajas(cantidad);
                    if(cajas == 0)
                    {
                        MessageBox.Show("Carton insuficiente", "No hay carton!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Se agregaron {cajas} cajas al inventario \nSe utilizaron {cajas / 2} unidades de cartón", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTxtBoxStock.Text = fabrica.Inventario.ToString();
                        lblCantCartonesStock.Text = $"Hay {fabrica.Inventario.Carton} cartones disponibles";
                        Volver(true);
                    } 
                }
            }
            else            
            { 
                MessageBox.Show("Cantidad invalida", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver(true);
        }

        private void Volver(bool estado)
        {
            if (estado)
            {
                btnCajas.Show();
                btnRompecabezas.Show();
                panelFabricarCajas.Hide();
            } else
            {
                btnCajas.Hide();
                btnRompecabezas.Hide();
                panelFabricarCajas.Show();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Fabrica de rompecabezas.txt";
                //string path = ".";
                Archivos archivos = new Archivos(ruta);
                archivos.Guardar(richTxtBoxStock.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para guardar en la ubicación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Sucedio un error inesperado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
