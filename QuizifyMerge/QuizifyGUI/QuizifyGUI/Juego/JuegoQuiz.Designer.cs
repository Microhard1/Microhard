
namespace QuizifyGUI
{
    partial class JuegoQuiz
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
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.ProgresoQuiz = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.BarraModificarVentana.SuspendLayout();
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
            this.BarraModificarVentana.Size = new System.Drawing.Size(1057, 41);
            this.BarraModificarVentana.TabIndex = 1;
            // 
            // BotonesModificarVentana
            // 
            this.BotonesModificarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonesModificarVentana.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BotonesModificarVentana.CloseHoverForeColor = System.Drawing.Color.White;
            this.BotonesModificarVentana.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.DisabledForeColor = System.Drawing.Color.DimGray;
            this.BotonesModificarVentana.IsDerivedStyle = true;
            this.BotonesModificarVentana.Location = new System.Drawing.Point(848, 1);
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
            this.tituloQuiz.TabIndex = 2;
            this.tituloQuiz.Text = "label1";
            this.tituloQuiz.Click += new System.EventHandler(this.tituloQuiz_Click);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnunciado.Location = new System.Drawing.Point(190, 115);
            this.labelEnunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(109, 39);
            this.labelEnunciado.TabIndex = 3;
            this.labelEnunciado.Text = "label1";
            this.labelEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Lime;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(197, 442);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(208, 35);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VERDADERO";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Red;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(613, 442);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 35);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "FALSO";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(907, 533);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(100, 28);
            this.botonSiguiente.TabIndex = 6;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // ProgresoQuiz
            // 
            this.ProgresoQuiz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.IsDerivedStyle = true;
            this.ProgresoQuiz.Location = new System.Drawing.Point(197, 62);
            this.ProgresoQuiz.Maximum = 100;
            this.ProgresoQuiz.Minimum = 0;
            this.ProgresoQuiz.Name = "ProgresoQuiz";
            this.ProgresoQuiz.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.ProgresoQuiz.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.Size = new System.Drawing.Size(626, 23);
            this.ProgresoQuiz.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProgresoQuiz.StyleManager = null;
            this.ProgresoQuiz.TabIndex = 25;
            this.ProgresoQuiz.Text = "metroSetProgressBar1";
            this.ProgresoQuiz.ThemeAuthor = "Narwin";
            this.ProgresoQuiz.ThemeName = "MetroDark";
            this.ProgresoQuiz.Value = 0;
            this.ProgresoQuiz.ValueChanged += new MetroSet_UI.Controls.MetroSetProgressBar.ValueChangedEventHandler(this.ProgresoQuiz_ValueChanged);
            // 
            // JuegoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 610);
            this.Controls.Add(this.ProgresoQuiz);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.BarraModificarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JuegoQuiz";
            this.Text = "JuegoQuiz";
            this.Load += new System.EventHandler(this.JuegoQuiz_Load);
            this.BarraModificarVentana.ResumeLayout(false);
            this.BarraModificarVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraModificarVentana;
        private MetroSet_UI.Controls.MetroSetControlBox BotonesModificarVentana;
        private System.Windows.Forms.Label tituloQuiz;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button botonSiguiente;
        private MetroSet_UI.Controls.MetroSetProgressBar ProgresoQuiz;
    }
}