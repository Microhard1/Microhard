
namespace DemoCreacionPreguntas
{
    partial class PaginaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.Borde = new System.Windows.Forms.Panel();
            this.botonRestaurarTamaño = new System.Windows.Forms.Button();
            this.botonMinimizar = new System.Windows.Forms.Button();
            this.botonMaximizar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonRespuestaAbierta = new System.Windows.Forms.Button();
            this.tipoTest = new System.Windows.Forms.Button();
            this.BotonVerdaderoFalso = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Borde.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Borde
            // 
            this.Borde.BackColor = System.Drawing.SystemColors.Highlight;
            this.Borde.Controls.Add(this.botonRestaurarTamaño);
            this.Borde.Controls.Add(this.botonMinimizar);
            this.Borde.Controls.Add(this.botonMaximizar);
            this.Borde.Controls.Add(this.botonCerrar);
            this.Borde.Dock = System.Windows.Forms.DockStyle.Top;
            this.Borde.Location = new System.Drawing.Point(0, 0);
            this.Borde.Margin = new System.Windows.Forms.Padding(2);
            this.Borde.Name = "Borde";
            this.Borde.Size = new System.Drawing.Size(909, 31);
            this.Borde.TabIndex = 0;
            // 
            // botonRestaurarTamaño
            // 
            this.botonRestaurarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRestaurarTamaño.Location = new System.Drawing.Point(801, 6);
            this.botonRestaurarTamaño.Margin = new System.Windows.Forms.Padding(2);
            this.botonRestaurarTamaño.Name = "botonRestaurarTamaño";
            this.botonRestaurarTamaño.Size = new System.Drawing.Size(47, 23);
            this.botonRestaurarTamaño.TabIndex = 3;
            this.botonRestaurarTamaño.Text = "[ ]";
            this.botonRestaurarTamaño.UseVisualStyleBackColor = true;
            this.botonRestaurarTamaño.Visible = false;
            this.botonRestaurarTamaño.Click += new System.EventHandler(this.button4_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Location = new System.Drawing.Point(739, 6);
            this.botonMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(47, 23);
            this.botonMinimizar.TabIndex = 2;
            this.botonMinimizar.Text = "_";
            this.botonMinimizar.UseVisualStyleBackColor = true;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMaximizar.Location = new System.Drawing.Point(801, 6);
            this.botonMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.Size = new System.Drawing.Size(47, 23);
            this.botonMaximizar.TabIndex = 1;
            this.botonMaximizar.Text = "[    ]";
            this.botonMaximizar.UseVisualStyleBackColor = true;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Location = new System.Drawing.Point(853, 6);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(47, 23);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonRespuestaAbierta);
            this.panel2.Controls.Add(this.tipoTest);
            this.panel2.Controls.Add(this.BotonVerdaderoFalso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 48);
            this.panel2.TabIndex = 1;
            // 
            // BotonRespuestaAbierta
            // 
            this.BotonRespuestaAbierta.AutoSize = true;
            this.BotonRespuestaAbierta.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonRespuestaAbierta.Location = new System.Drawing.Point(284, 0);
            this.BotonRespuestaAbierta.Margin = new System.Windows.Forms.Padding(2);
            this.BotonRespuestaAbierta.Name = "BotonRespuestaAbierta";
            this.BotonRespuestaAbierta.Size = new System.Drawing.Size(323, 48);
            this.BotonRespuestaAbierta.TabIndex = 2;
            this.BotonRespuestaAbierta.Text = "RESPUESTA ABIERTA";
            this.BotonRespuestaAbierta.UseVisualStyleBackColor = true;
            this.BotonRespuestaAbierta.Click += new System.EventHandler(this.BotonRespuestaAbierta_Click);
            // 
            // tipoTest
            // 
            this.tipoTest.AutoSize = true;
            this.tipoTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.tipoTest.Location = new System.Drawing.Point(0, 0);
            this.tipoTest.Margin = new System.Windows.Forms.Padding(2);
            this.tipoTest.Name = "tipoTest";
            this.tipoTest.Size = new System.Drawing.Size(299, 48);
            this.tipoTest.TabIndex = 1;
            this.tipoTest.Text = "TIPO TEST";
            this.tipoTest.UseVisualStyleBackColor = true;
            this.tipoTest.Click += new System.EventHandler(this.tipoTest_Click);
            // 
            // BotonVerdaderoFalso
            // 
            this.BotonVerdaderoFalso.AutoSize = true;
            this.BotonVerdaderoFalso.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonVerdaderoFalso.Location = new System.Drawing.Point(607, 0);
            this.BotonVerdaderoFalso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonVerdaderoFalso.Name = "BotonVerdaderoFalso";
            this.BotonVerdaderoFalso.Size = new System.Drawing.Size(302, 48);
            this.BotonVerdaderoFalso.TabIndex = 0;
            this.BotonVerdaderoFalso.Text = "VERDADERO/FALSO";
            this.BotonVerdaderoFalso.UseVisualStyleBackColor = true;
            this.BotonVerdaderoFalso.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 79);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(909, 490);
            this.panelContenedor.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Borde;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 569);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Borde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaginaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Borde.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Borde;
        private System.Windows.Forms.Button botonMinimizar;
        private System.Windows.Forms.Button botonMaximizar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonRespuestaAbierta;
        private System.Windows.Forms.Button tipoTest;
        private System.Windows.Forms.Button BotonVerdaderoFalso;
        private System.Windows.Forms.Button botonRestaurarTamaño;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

