
namespace QuizifyGUI
{
    partial class JuegoQuizMultiopcion
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
            this.components = new System.ComponentModel.Container();
            this.siguientePregunta = new MetroSet_UI.Controls.MetroSetButton();
            this.Opcion4 = new System.Windows.Forms.RadioButton();
            this.Opcion3 = new System.Windows.Forms.RadioButton();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.ProgresoQuiz = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.BarraModificarVentana = new System.Windows.Forms.Panel();
            this.BotonesModificarVentana = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tituloQuiz = new System.Windows.Forms.Label();
            this.Enunciado = new System.Windows.Forms.Label();
            this.EnviarTest = new MetroSet_UI.Controls.MetroSetButton();
            this.TiempoQuiz = new System.Windows.Forms.Timer(this.components);
            this.labelTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.BarraModificarVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // siguientePregunta
            // 
            this.siguientePregunta.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.siguientePregunta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.siguientePregunta.DisabledForeColor = System.Drawing.Color.Gray;
            this.siguientePregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.siguientePregunta.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.siguientePregunta.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.siguientePregunta.HoverTextColor = System.Drawing.Color.White;
            this.siguientePregunta.IsDerivedStyle = true;
            this.siguientePregunta.Location = new System.Drawing.Point(401, 520);
            this.siguientePregunta.Margin = new System.Windows.Forms.Padding(4);
            this.siguientePregunta.Name = "siguientePregunta";
            this.siguientePregunta.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.siguientePregunta.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.siguientePregunta.NormalTextColor = System.Drawing.Color.White;
            this.siguientePregunta.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.siguientePregunta.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.siguientePregunta.PressTextColor = System.Drawing.Color.White;
            this.siguientePregunta.Size = new System.Drawing.Size(144, 53);
            this.siguientePregunta.Style = MetroSet_UI.Enums.Style.Light;
            this.siguientePregunta.StyleManager = null;
            this.siguientePregunta.TabIndex = 23;
            this.siguientePregunta.Text = "Siguiente";
            this.siguientePregunta.ThemeAuthor = "Narwin";
            this.siguientePregunta.ThemeName = "MetroLite";
            this.siguientePregunta.Click += new System.EventHandler(this.siguientePregunta_Click);
            // 
            // Opcion4
            // 
            this.Opcion4.AutoSize = true;
            this.Opcion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion4.Location = new System.Drawing.Point(80, 428);
            this.Opcion4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.Size = new System.Drawing.Size(176, 40);
            this.Opcion4.TabIndex = 22;
            this.Opcion4.TabStop = true;
            this.Opcion4.Text = "OPCION 4";
            this.Opcion4.UseVisualStyleBackColor = true;
            this.Opcion4.CheckedChanged += new System.EventHandler(this.Opcion4_CheckedChanged);
            // 
            // Opcion3
            // 
            this.Opcion3.AutoSize = true;
            this.Opcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion3.Location = new System.Drawing.Point(80, 334);
            this.Opcion3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(176, 40);
            this.Opcion3.TabIndex = 21;
            this.Opcion3.TabStop = true;
            this.Opcion3.Text = "OPCION 3";
            this.Opcion3.UseVisualStyleBackColor = true;
            this.Opcion3.CheckedChanged += new System.EventHandler(this.Opcion3_CheckedChanged);
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.Location = new System.Drawing.Point(630, 160);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(279, 308);
            this.imagenPregunta.TabIndex = 20;
            this.imagenPregunta.TabStop = false;
            // 
            // Opcion2
            // 
            this.Opcion2.AutoSize = true;
            this.Opcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion2.Location = new System.Drawing.Point(80, 245);
            this.Opcion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(176, 40);
            this.Opcion2.TabIndex = 19;
            this.Opcion2.TabStop = true;
            this.Opcion2.Text = "OPCION 2";
            this.Opcion2.UseVisualStyleBackColor = true;
            this.Opcion2.CheckedChanged += new System.EventHandler(this.Opcion2_CheckedChanged);
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSize = true;
            this.Opcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion1.Location = new System.Drawing.Point(80, 161);
            this.Opcion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(176, 40);
            this.Opcion1.TabIndex = 18;
            this.Opcion1.TabStop = true;
            this.Opcion1.Text = "OPCION 1";
            this.Opcion1.UseVisualStyleBackColor = true;
            this.Opcion1.CheckedChanged += new System.EventHandler(this.Opcion1_CheckedChanged);
            // 
            // ProgresoQuiz
            // 
            this.ProgresoQuiz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProgresoQuiz.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.IsDerivedStyle = true;
            this.ProgresoQuiz.Location = new System.Drawing.Point(164, 56);
            this.ProgresoQuiz.Maximum = 100;
            this.ProgresoQuiz.Minimum = 0;
            this.ProgresoQuiz.Name = "ProgresoQuiz";
            this.ProgresoQuiz.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.ProgresoQuiz.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ProgresoQuiz.Size = new System.Drawing.Size(626, 23);
            this.ProgresoQuiz.Style = MetroSet_UI.Enums.Style.Dark;
            this.ProgresoQuiz.StyleManager = null;
            this.ProgresoQuiz.TabIndex = 24;
            this.ProgresoQuiz.Text = "metroSetProgressBar1";
            this.ProgresoQuiz.ThemeAuthor = "Narwin";
            this.ProgresoQuiz.ThemeName = "MetroDark";
            this.ProgresoQuiz.Value = 0;
            this.ProgresoQuiz.ValueChanged += new MetroSet_UI.Controls.MetroSetProgressBar.ValueChangedEventHandler(this.ProgresoQuiz_ValueChanged);
            // 
            // BarraModificarVentana
            // 
            this.BarraModificarVentana.Controls.Add(this.BotonesModificarVentana);
            this.BarraModificarVentana.Controls.Add(this.tituloQuiz);
            this.BarraModificarVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraModificarVentana.Location = new System.Drawing.Point(0, 0);
            this.BarraModificarVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraModificarVentana.Name = "BarraModificarVentana";
            this.BarraModificarVentana.Size = new System.Drawing.Size(944, 41);
            this.BarraModificarVentana.TabIndex = 25;
            // 
            // BotonesModificarVentana
            // 
            this.BotonesModificarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonesModificarVentana.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BotonesModificarVentana.CloseHoverForeColor = System.Drawing.Color.White;
            this.BotonesModificarVentana.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.DisabledForeColor = System.Drawing.Color.DimGray;
            this.BotonesModificarVentana.IsDerivedStyle = true;
            this.BotonesModificarVentana.Location = new System.Drawing.Point(734, 1);
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
            // Enunciado
            // 
            this.Enunciado.AutoSize = true;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.Location = new System.Drawing.Point(13, 100);
            this.Enunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(122, 44);
            this.Enunciado.TabIndex = 26;
            this.Enunciado.Text = "label1";
            // 
            // EnviarTest
            // 
            this.EnviarTest.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnviarTest.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnviarTest.DisabledForeColor = System.Drawing.Color.Gray;
            this.EnviarTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EnviarTest.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.EnviarTest.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.EnviarTest.HoverTextColor = System.Drawing.Color.White;
            this.EnviarTest.IsDerivedStyle = true;
            this.EnviarTest.Location = new System.Drawing.Point(704, 520);
            this.EnviarTest.Margin = new System.Windows.Forms.Padding(4);
            this.EnviarTest.Name = "EnviarTest";
            this.EnviarTest.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnviarTest.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnviarTest.NormalTextColor = System.Drawing.Color.White;
            this.EnviarTest.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.EnviarTest.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.EnviarTest.PressTextColor = System.Drawing.Color.White;
            this.EnviarTest.Size = new System.Drawing.Size(144, 53);
            this.EnviarTest.Style = MetroSet_UI.Enums.Style.Light;
            this.EnviarTest.StyleManager = null;
            this.EnviarTest.TabIndex = 27;
            this.EnviarTest.Text = "Enviar test";
            this.EnviarTest.ThemeAuthor = "Narwin";
            this.EnviarTest.ThemeName = "MetroLite";
            this.EnviarTest.Click += new System.EventHandler(this.EnviarTest_Click);
            // 
            // TiempoQuiz
            // 
            this.TiempoQuiz.Enabled = true;
            this.TiempoQuiz.Interval = 1000;
            this.TiempoQuiz.Tick += new System.EventHandler(this.TiempoQuiz_Tick);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(819, 56);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(90, 25);
            this.labelTiempo.TabIndex = 28;
            this.labelTiempo.Text = "00:00:00";
            this.labelTiempo.Click += new System.EventHandler(this.labelTiempo_Click);
            // 
            // JuegoQuizMultiopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 595);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.EnviarTest);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.BarraModificarVentana);
            this.Controls.Add(this.ProgresoQuiz);
            this.Controls.Add(this.siguientePregunta);
            this.Controls.Add(this.Opcion4);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.Opcion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegoQuizMultiopcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoQuizMultiopcion";
            this.Load += new System.EventHandler(this.JuegoQuizMultiopcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.BarraModificarVentana.ResumeLayout(false);
            this.BarraModificarVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton siguientePregunta;
        private System.Windows.Forms.RadioButton Opcion4;
        private System.Windows.Forms.RadioButton Opcion3;
        private System.Windows.Forms.PictureBox imagenPregunta;
        private System.Windows.Forms.RadioButton Opcion2;
        private System.Windows.Forms.RadioButton Opcion1;
        private MetroSet_UI.Controls.MetroSetProgressBar ProgresoQuiz;
        private System.Windows.Forms.Panel BarraModificarVentana;
        private MetroSet_UI.Controls.MetroSetControlBox BotonesModificarVentana;
        private System.Windows.Forms.Label tituloQuiz;
        private System.Windows.Forms.Label Enunciado;
        private MetroSet_UI.Controls.MetroSetButton EnviarTest;
        private System.Windows.Forms.Timer TiempoQuiz;
        private System.Windows.Forms.Label labelTiempo;
    }
}