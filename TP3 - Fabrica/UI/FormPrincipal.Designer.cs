namespace UI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabCarton = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.richTxtBoxStock = new System.Windows.Forms.RichTextBox();
            this.tabCartones = new System.Windows.Forms.TabPage();
            this.lblCantCartonesStock = new System.Windows.Forms.Label();
            this.btnAgregarCarton = new System.Windows.Forms.Button();
            this.txtBoxCantCarton = new System.Windows.Forms.TextBox();
            this.lblCantidadCarton = new System.Windows.Forms.Label();
            this.tabFabricar = new System.Windows.Forms.TabPage();
            this.panelFabricarCajas = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelWarningCajas = new System.Windows.Forms.Label();
            this.labelNumCajas = new System.Windows.Forms.Label();
            this.buttonHacerCajas = new System.Windows.Forms.Button();
            this.textBoxCantCajas = new System.Windows.Forms.TextBox();
            this.labelCantCajas = new System.Windows.Forms.Label();
            this.btnRompecabezas = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabCarton.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabCartones.SuspendLayout();
            this.tabFabricar.SuspendLayout();
            this.panelFabricarCajas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblNombre.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Yellow;
            this.lblNombre.Location = new System.Drawing.Point(-3, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(379, 68);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Puzzlesito";
            // 
            // tabCarton
            // 
            this.tabCarton.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCarton.Controls.Add(this.tabStock);
            this.tabCarton.Controls.Add(this.tabCartones);
            this.tabCarton.Controls.Add(this.tabFabricar);
            this.tabCarton.Location = new System.Drawing.Point(13, 133);
            this.tabCarton.Name = "tabCarton";
            this.tabCarton.SelectedIndex = 0;
            this.tabCarton.Size = new System.Drawing.Size(380, 227);
            this.tabCarton.TabIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.btnGuardar);
            this.tabStock.Controls.Add(this.richTxtBoxStock);
            this.tabStock.Location = new System.Drawing.Point(4, 28);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(372, 195);
            this.tabStock.TabIndex = 2;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // richTxtBoxStock
            // 
            this.richTxtBoxStock.Location = new System.Drawing.Point(0, 0);
            this.richTxtBoxStock.Name = "richTxtBoxStock";
            this.richTxtBoxStock.Size = new System.Drawing.Size(369, 190);
            this.richTxtBoxStock.TabIndex = 0;
            this.richTxtBoxStock.Text = "";
            // 
            // tabCartones
            // 
            this.tabCartones.Controls.Add(this.lblCantCartonesStock);
            this.tabCartones.Controls.Add(this.btnAgregarCarton);
            this.tabCartones.Controls.Add(this.txtBoxCantCarton);
            this.tabCartones.Controls.Add(this.lblCantidadCarton);
            this.tabCartones.Location = new System.Drawing.Point(4, 28);
            this.tabCartones.Name = "tabCartones";
            this.tabCartones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCartones.Size = new System.Drawing.Size(372, 195);
            this.tabCartones.TabIndex = 0;
            this.tabCartones.Text = "Cargar Cartón";
            this.tabCartones.UseVisualStyleBackColor = true;
            // 
            // lblCantCartonesStock
            // 
            this.lblCantCartonesStock.AutoSize = true;
            this.lblCantCartonesStock.Location = new System.Drawing.Point(42, 45);
            this.lblCantCartonesStock.Name = "lblCantCartonesStock";
            this.lblCantCartonesStock.Size = new System.Drawing.Size(20, 17);
            this.lblCantCartonesStock.TabIndex = 6;
            this.lblCantCartonesStock.Text = "...";
            // 
            // btnAgregarCarton
            // 
            this.btnAgregarCarton.Location = new System.Drawing.Point(240, 79);
            this.btnAgregarCarton.Name = "btnAgregarCarton";
            this.btnAgregarCarton.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarCarton.TabIndex = 5;
            this.btnAgregarCarton.Text = "Agregar";
            this.btnAgregarCarton.UseVisualStyleBackColor = true;
            this.btnAgregarCarton.Click += new System.EventHandler(this.btnAgregarCarton_Click);
            // 
            // txtBoxCantCarton
            // 
            this.txtBoxCantCarton.Location = new System.Drawing.Point(121, 88);
            this.txtBoxCantCarton.Name = "txtBoxCantCarton";
            this.txtBoxCantCarton.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCantCarton.TabIndex = 4;
            // 
            // lblCantidadCarton
            // 
            this.lblCantidadCarton.AutoSize = true;
            this.lblCantidadCarton.Location = new System.Drawing.Point(47, 91);
            this.lblCantidadCarton.Name = "lblCantidadCarton";
            this.lblCantidadCarton.Size = new System.Drawing.Size(68, 17);
            this.lblCantidadCarton.TabIndex = 3;
            this.lblCantidadCarton.Text = "Cantidad:";
            // 
            // tabFabricar
            // 
            this.tabFabricar.Controls.Add(this.panelFabricarCajas);
            this.tabFabricar.Controls.Add(this.btnRompecabezas);
            this.tabFabricar.Controls.Add(this.btnCajas);
            this.tabFabricar.Location = new System.Drawing.Point(4, 28);
            this.tabFabricar.Name = "tabFabricar";
            this.tabFabricar.Padding = new System.Windows.Forms.Padding(3);
            this.tabFabricar.Size = new System.Drawing.Size(372, 195);
            this.tabFabricar.TabIndex = 1;
            this.tabFabricar.Text = "Fabricar";
            this.tabFabricar.UseVisualStyleBackColor = true;
            // 
            // panelFabricarCajas
            // 
            this.panelFabricarCajas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFabricarCajas.Controls.Add(this.btnVolver);
            this.panelFabricarCajas.Controls.Add(this.labelWarningCajas);
            this.panelFabricarCajas.Controls.Add(this.labelNumCajas);
            this.panelFabricarCajas.Controls.Add(this.buttonHacerCajas);
            this.panelFabricarCajas.Controls.Add(this.textBoxCantCajas);
            this.panelFabricarCajas.Controls.Add(this.labelCantCajas);
            this.panelFabricarCajas.Location = new System.Drawing.Point(6, 22);
            this.panelFabricarCajas.Name = "panelFabricarCajas";
            this.panelFabricarCajas.Size = new System.Drawing.Size(372, 167);
            this.panelFabricarCajas.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(318, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(28, 24);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "<";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelWarningCajas
            // 
            this.labelWarningCajas.AutoSize = true;
            this.labelWarningCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarningCajas.ForeColor = System.Drawing.Color.Red;
            this.labelWarningCajas.Location = new System.Drawing.Point(3, 102);
            this.labelWarningCajas.Name = "labelWarningCajas";
            this.labelWarningCajas.Size = new System.Drawing.Size(188, 15);
            this.labelWarningCajas.TabIndex = 11;
            this.labelWarningCajas.Text = "*Se utiliza un cartón cada 2 cajas";
            // 
            // labelNumCajas
            // 
            this.labelNumCajas.AutoSize = true;
            this.labelNumCajas.Location = new System.Drawing.Point(36, 23);
            this.labelNumCajas.Name = "labelNumCajas";
            this.labelNumCajas.Size = new System.Drawing.Size(20, 17);
            this.labelNumCajas.TabIndex = 10;
            this.labelNumCajas.Text = "...";
            // 
            // buttonHacerCajas
            // 
            this.buttonHacerCajas.Location = new System.Drawing.Point(234, 57);
            this.buttonHacerCajas.Name = "buttonHacerCajas";
            this.buttonHacerCajas.Size = new System.Drawing.Size(75, 41);
            this.buttonHacerCajas.TabIndex = 9;
            this.buttonHacerCajas.Text = "Agregar";
            this.buttonHacerCajas.UseVisualStyleBackColor = true;
            this.buttonHacerCajas.Click += new System.EventHandler(this.buttonHacerCajas_Click);
            // 
            // textBoxCantCajas
            // 
            this.textBoxCantCajas.Location = new System.Drawing.Point(115, 66);
            this.textBoxCantCajas.Name = "textBoxCantCajas";
            this.textBoxCantCajas.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantCajas.TabIndex = 8;
            // 
            // labelCantCajas
            // 
            this.labelCantCajas.AutoSize = true;
            this.labelCantCajas.Location = new System.Drawing.Point(41, 69);
            this.labelCantCajas.Name = "labelCantCajas";
            this.labelCantCajas.Size = new System.Drawing.Size(68, 17);
            this.labelCantCajas.TabIndex = 7;
            this.labelCantCajas.Text = "Cantidad:";
            // 
            // btnRompecabezas
            // 
            this.btnRompecabezas.BackColor = System.Drawing.Color.White;
            this.btnRompecabezas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRompecabezas.BackgroundImage")));
            this.btnRompecabezas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRompecabezas.Location = new System.Drawing.Point(190, 28);
            this.btnRompecabezas.Name = "btnRompecabezas";
            this.btnRompecabezas.Size = new System.Drawing.Size(176, 135);
            this.btnRompecabezas.TabIndex = 1;
            this.btnRompecabezas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRompecabezas.UseVisualStyleBackColor = false;
            this.btnRompecabezas.Click += new System.EventHandler(this.btnRompecabezas_Click);
            // 
            // btnCajas
            // 
            this.btnCajas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCajas.BackgroundImage")));
            this.btnCajas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCajas.Location = new System.Drawing.Point(6, 28);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(178, 135);
            this.btnCajas.TabIndex = 0;
            this.btnCajas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCajas.UseVisualStyleBackColor = true;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(246, 139);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 372);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tabCarton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magali Gracia 2D";
            this.tabCarton.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabCartones.ResumeLayout(false);
            this.tabCartones.PerformLayout();
            this.tabFabricar.ResumeLayout(false);
            this.panelFabricarCajas.ResumeLayout(false);
            this.panelFabricarCajas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCarton;
        private System.Windows.Forms.TabPage tabCartones;
        private System.Windows.Forms.TabPage tabFabricar;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.Label lblCantCartonesStock;
        private System.Windows.Forms.Button btnAgregarCarton;
        private System.Windows.Forms.TextBox txtBoxCantCarton;
        private System.Windows.Forms.Label lblCantidadCarton;
        private System.Windows.Forms.Button btnRompecabezas;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.RichTextBox richTxtBoxStock;
        private System.Windows.Forms.Panel panelFabricarCajas;
        private System.Windows.Forms.Label labelNumCajas;
        private System.Windows.Forms.Button buttonHacerCajas;
        private System.Windows.Forms.TextBox textBoxCantCajas;
        private System.Windows.Forms.Label labelCantCajas;
        private System.Windows.Forms.Label labelWarningCajas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}

