
namespace DemoCreacionPreguntas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoTest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonMaximizar = new System.Windows.Forms.Button();
            this.botonMinimizar = new System.Windows.Forms.Button();
            this.botonRestaurarTamaño = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.botonRestaurarTamaño);
            this.panel1.Controls.Add(this.botonMinimizar);
            this.panel1.Controls.Add(this.botonMaximizar);
            this.panel1.Controls.Add(this.botonCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.tipoTest);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 59);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(982, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "VERDADERO/FALSO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoTest
            // 
            this.tipoTest.AutoSize = true;
            this.tipoTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.tipoTest.Location = new System.Drawing.Point(0, 0);
            this.tipoTest.Name = "tipoTest";
            this.tipoTest.Size = new System.Drawing.Size(90, 59);
            this.tipoTest.TabIndex = 1;
            this.tipoTest.Text = "TIPO TEST";
            this.tipoTest.UseVisualStyleBackColor = true;
            this.tipoTest.Click += new System.EventHandler(this.tipoTest_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(819, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "RESPUESTA ABIERTA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // botonCerrar
            // 
            this.botonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Location = new System.Drawing.Point(906, 7);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(63, 28);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonMaximizar
            // 
            this.botonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMaximizar.Location = new System.Drawing.Point(837, 7);
            this.botonMaximizar.Name = "botonMaximizar";
            this.botonMaximizar.Size = new System.Drawing.Size(63, 28);
            this.botonMaximizar.TabIndex = 1;
            this.botonMaximizar.Text = "[    ]";
            this.botonMaximizar.UseVisualStyleBackColor = true;
            this.botonMaximizar.Click += new System.EventHandler(this.botonMaximizar_Click);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMinimizar.Location = new System.Drawing.Point(755, 7);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(63, 28);
            this.botonMinimizar.TabIndex = 2;
            this.botonMinimizar.Text = "_";
            this.botonMinimizar.UseVisualStyleBackColor = true;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonRestaurarTamaño
            // 
            this.botonRestaurarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRestaurarTamaño.Location = new System.Drawing.Point(837, 7);
            this.botonRestaurarTamaño.Name = "botonRestaurarTamaño";
            this.botonRestaurarTamaño.Size = new System.Drawing.Size(63, 28);
            this.botonRestaurarTamaño.TabIndex = 3;
            this.botonRestaurarTamaño.Text = "[ ]";
            this.botonRestaurarTamaño.UseVisualStyleBackColor = true;
            this.botonRestaurarTamaño.Visible = false;
            this.botonRestaurarTamaño.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 97);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(982, 480);
            this.panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 577);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonMinimizar;
        private System.Windows.Forms.Button botonMaximizar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button tipoTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonRestaurarTamaño;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

