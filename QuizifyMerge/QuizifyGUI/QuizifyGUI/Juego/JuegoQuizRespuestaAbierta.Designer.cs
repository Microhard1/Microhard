
namespace QuizifyGUI
{
    partial class JuegoQuizRespuestaAbierta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraModificarVentana = new System.Windows.Forms.Panel();
            this.BotonesModificarVentana = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tituloQuiz = new System.Windows.Forms.Label();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.botonSiguiente = new MetroSet_UI.Controls.MetroSetButton();
            this.Enunciado = new System.Windows.Forms.Label();
            this.ProgresoQuiz = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.BarraModificarVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraModificarVentana
            // 
            this.BarraModificarVentana.Controls.Add(this.BotonesModificarVentana);
            this.BarraModificarVentana.Controls.Add(this.tituloQuiz);
            this.BarraModificarVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraModificarVentana.Location = new System.Drawing.Point(0, 0);
            this.BarraModificarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraModificarVentana.Name = "BarraModificarVentana";
            this.BarraModificarVentana.Size = new System.Drawing.Size(1167, 41);
            this.BarraModificarVentana.TabIndex = 2;
            // 
            // BotonesModificarVentana
            // 
            this.BotonesModificarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonesModificarVentana.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BotonesModificarVentana.CloseHoverForeColor = System.Drawing.Color.White;
            this.BotonesModificarVentana.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.DisabledForeColor = System.Drawing.Color.DimGray;
            this.BotonesModificarVentana.IsDerivedStyle = true;
            this.BotonesModificarVentana.Location = new System.Drawing.Point(957, 1);
            this.BotonesModificarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonesModificarVentana.MaximizeBox = true;
            this.BotonesModificarVentana.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BotonesModificarVentana.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.MinimizeBox = true;
            this.BotonesModificarVentana.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BotonesModificarVentana.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.Name = "BotonesModificarVentana";
            this.BotonesModificarVentana.Size = new System.Drawing.Size(100, 25);
            this.BotonesModificarVentana.Style = MetroSet_UI.Enums.Style.Light;
            this.BotonesModificarVentana.StyleManager = null;
            this.BotonesModificarVentana.TabIndex = 0;
            this.BotonesModificarVentana.Text = "metroSetControlBox1";
            this.BotonesModificarVentana.ThemeAuthor = "Narwin";
            this.BotonesModificarVentana.ThemeName = "MetroLite";
            // 
            // tituloQuiz
            // 
            this.tituloQuiz.AutoSize = true;
            this.tituloQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloQuiz.Location = new System.Drawing.Point(4, 1);
            this.tituloQuiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloQuiz.Name = "tituloQuiz";
            this.tituloQuiz.Size = new System.Drawing.Size(95, 36);
            this.tituloQuiz.TabIndex = 3;
            this.tituloQuiz.Text = "label1";
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(40, 190);
            this.textBoxRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRespuesta.Multiline = true;
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(480, 426);
            this.textBoxRespuesta.TabIndex = 4;
            this.textBoxRespuesta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonSiguiente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonSiguiente.DisabledForeColor = System.Drawing.Color.Gray;
            this.botonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.botonSiguiente.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.botonSiguiente.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.botonSiguiente.HoverTextColor = System.Drawing.Color.White;
            this.botonSiguiente.IsDerivedStyle = true;
            this.botonSiguiente.Location = new System.Drawing.Point(497, 647);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonSiguiente.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonSiguiente.NormalTextColor = System.Drawing.Color.White;
            this.botonSiguiente.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonSiguiente.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonSiguiente.PressTextColor = System.Drawing.Color.White;
            this.botonSiguiente.Size = new System.Drawing.Size(144, 53);
            this.botonSiguiente.Style = MetroSet_UI.Enums.Style.Light;
            this.botonSiguiente.StyleManager = null;
            this.botonSiguiente.TabIndex = 15;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.ThemeAuthor = "Narwin";
            this.botonSiguiente.ThemeName = "MetroLite";
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(41, 111);
            this.Enunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(122, 44);
            this.Enunciado.TabIndex = 17;
            this.Enunciado.Text = "label1";
            // 
            // ProgresoQuiz
            // 
            this.ProgresoQuiz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ProgresoQuiz.BorderColor = System.Drawing.Color.Black;
            this.ProgresoQuiz.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ProgresoQuiz.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ProgresoQuiz.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.IsDerivedStyle = true;
            this.ProgresoQuiz.Location = new System.Drawing.Point(232, 66);
            this.ProgresoQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgresoQuiz.Maximum = 100;
            this.ProgresoQuiz.Minimum = 0;
            this.ProgresoQuiz.Name = "ProgresoQuiz";
            this.ProgresoQuiz.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.ProgresoQuiz.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.Size = new System.Drawing.Size(725, 23);
            this.ProgresoQuiz.Style = MetroSet_UI.Enums.Style.Light;
            this.ProgresoQuiz.StyleManager = null;
            this.ProgresoQuiz.TabIndex = 18;
            this.ProgresoQuiz.Text = "metroSetProgressBar1";
            this.ProgresoQuiz.ThemeAuthor = null;
            this.ProgresoQuiz.ThemeName = null;
            this.ProgresoQuiz.Value = 0;
            this.ProgresoQuiz.ValueChanged += new MetroSet_UI.Controls.MetroSetProgressBar.ValueChangedEventHandler(this.ProgresoQuiz_ValueChanged);
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPregunta.Location = new System.Drawing.Point(711, 190);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(425, 427);
            this.imagenPregunta.TabIndex = 16;
            this.imagenPregunta.TabStop = false;
            this.imagenPregunta.Click += new System.EventHandler(this.imagenPregunta_Click);
            // 
            // JuegoQuizRespuestaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 734);
            this.Controls.Add(this.ProgresoQuiz);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.BarraModificarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JuegoQuizRespuestaAbierta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoQuizRespuestaAbierta";
            this.Load += new System.EventHandler(this.JuegoQuizRespuestaAbierta_Load);
            this.BarraModificarVentana.ResumeLayout(false);
            this.BarraModificarVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraModificarVentana;
        private MetroSet_UI.Controls.MetroSetControlBox BotonesModificarVentana;
        private System.Windows.Forms.Label tituloQuiz;
        private System.Windows.Forms.TextBox textBoxRespuesta;
        private MetroSet_UI.Controls.MetroSetButton botonSiguiente;
        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.PictureBox imagenPregunta;
        private MetroSet_UI.Controls.MetroSetProgressBar ProgresoQuiz;
    }
}