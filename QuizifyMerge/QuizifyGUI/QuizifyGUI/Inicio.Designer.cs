
namespace QuizifyGUI
{
    partial class Inicio
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
            this.BotonInicio = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.NavbarIzquierda = new System.Windows.Forms.Panel();
            this.NavbarSuperior = new System.Windows.Forms.Panel();
            this.BotonPerfil = new MetroSet_UI.Controls.MetroSetBadge();
            this.BotonesModificarVentana = new MetroSet_UI.Controls.MetroSetControlBox();
            this.BotonCrearPregunta = new System.Windows.Forms.Button();
            this.BotonCrearQuiz = new System.Windows.Forms.Button();
            this.BotonRealizarQuiz = new System.Windows.Forms.Button();
            this.BotonEstadisticas = new System.Windows.Forms.Button();
            this.BotonAjustes = new System.Windows.Forms.Button();
            this.BarraModificarVentana.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.NavbarIzquierda.SuspendLayout();
            this.NavbarSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraModificarVentana
            // 
            this.BarraModificarVentana.Controls.Add(this.BotonesModificarVentana);
            this.BarraModificarVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraModificarVentana.Location = new System.Drawing.Point(0, 0);
            this.BarraModificarVentana.Name = "BarraModificarVentana";
            this.BarraModificarVentana.Size = new System.Drawing.Size(1309, 41);
            this.BarraModificarVentana.TabIndex = 0;
            // 
            // BotonInicio
            // 
            this.BotonInicio.Location = new System.Drawing.Point(566, 6);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(121, 72);
            this.BotonInicio.TabIndex = 4;
            this.BotonInicio.Text = "Inicio";
            this.BotonInicio.UseVisualStyleBackColor = true;
            this.BotonInicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.NavbarIzquierda);
            this.PanelPrincipal.Controls.Add(this.NavbarSuperior);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 41);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1309, 623);
            this.PanelPrincipal.TabIndex = 1;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // NavbarIzquierda
            // 
            this.NavbarIzquierda.Controls.Add(this.BotonAjustes);
            this.NavbarIzquierda.Controls.Add(this.BotonRealizarQuiz);
            this.NavbarIzquierda.Controls.Add(this.BotonEstadisticas);
            this.NavbarIzquierda.Controls.Add(this.BotonCrearQuiz);
            this.NavbarIzquierda.Controls.Add(this.BotonCrearPregunta);
            this.NavbarIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavbarIzquierda.Location = new System.Drawing.Point(0, 81);
            this.NavbarIzquierda.Name = "NavbarIzquierda";
            this.NavbarIzquierda.Size = new System.Drawing.Size(163, 542);
            this.NavbarIzquierda.TabIndex = 0;
            // 
            // NavbarSuperior
            // 
            this.NavbarSuperior.BackColor = System.Drawing.Color.Aqua;
            this.NavbarSuperior.Controls.Add(this.BotonPerfil);
            this.NavbarSuperior.Controls.Add(this.BotonInicio);
            this.NavbarSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarSuperior.Location = new System.Drawing.Point(0, 0);
            this.NavbarSuperior.Name = "NavbarSuperior";
            this.NavbarSuperior.Size = new System.Drawing.Size(1309, 81);
            this.NavbarSuperior.TabIndex = 2;
            // 
            // BotonPerfil
            // 
            this.BotonPerfil.BackColor = System.Drawing.Color.Transparent;
            this.BotonPerfil.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            this.BotonPerfil.BadgeText = "3";
            this.BotonPerfil.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BotonPerfil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.BotonPerfil.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.BotonPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BotonPerfil.HoverBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.BotonPerfil.HoverBadgeTextColor = System.Drawing.Color.White;
            this.BotonPerfil.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BotonPerfil.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BotonPerfil.HoverTextColor = System.Drawing.Color.White;
            this.BotonPerfil.IsDerivedStyle = true;
            this.BotonPerfil.Location = new System.Drawing.Point(1087, 0);
            this.BotonPerfil.Name = "BotonPerfil";
            this.BotonPerfil.NormalBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonPerfil.NormalBadgeTextColor = System.Drawing.Color.White;
            this.BotonPerfil.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BotonPerfil.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BotonPerfil.NormalTextColor = System.Drawing.Color.Black;
            this.BotonPerfil.PressBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.BotonPerfil.PressBadgeTextColor = System.Drawing.Color.White;
            this.BotonPerfil.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BotonPerfil.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BotonPerfil.PressTextColor = System.Drawing.Color.White;
            this.BotonPerfil.Size = new System.Drawing.Size(113, 72);
            this.BotonPerfil.Style = MetroSet_UI.Enums.Style.Light;
            this.BotonPerfil.StyleManager = null;
            this.BotonPerfil.TabIndex = 3;
            this.BotonPerfil.Text = "Perfil";
            this.BotonPerfil.ThemeAuthor = "Narwin";
            this.BotonPerfil.ThemeName = "MetroLite";
            this.BotonPerfil.Click += new System.EventHandler(this.metroSetBadge1_Click);
            // 
            // BotonesModificarVentana
            // 
            this.BotonesModificarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonesModificarVentana.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BotonesModificarVentana.CloseHoverForeColor = System.Drawing.Color.White;
            this.BotonesModificarVentana.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.DisabledForeColor = System.Drawing.Color.DimGray;
            this.BotonesModificarVentana.IsDerivedStyle = true;
            this.BotonesModificarVentana.Location = new System.Drawing.Point(1100, 1);
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
            // BotonCrearPregunta
            // 
            this.BotonCrearPregunta.BackColor = System.Drawing.Color.Aqua;
            this.BotonCrearPregunta.Location = new System.Drawing.Point(3, 25);
            this.BotonCrearPregunta.Name = "BotonCrearPregunta";
            this.BotonCrearPregunta.Size = new System.Drawing.Size(163, 79);
            this.BotonCrearPregunta.TabIndex = 3;
            this.BotonCrearPregunta.Text = "Crear Pregunta";
            this.BotonCrearPregunta.UseVisualStyleBackColor = false;
            this.BotonCrearPregunta.Click += new System.EventHandler(this.BotonCrearPregunta_Click);
            // 
            // BotonCrearQuiz
            // 
            this.BotonCrearQuiz.BackColor = System.Drawing.Color.Aqua;
            this.BotonCrearQuiz.Location = new System.Drawing.Point(3, 125);
            this.BotonCrearQuiz.Name = "BotonCrearQuiz";
            this.BotonCrearQuiz.Size = new System.Drawing.Size(163, 79);
            this.BotonCrearQuiz.TabIndex = 8;
            this.BotonCrearQuiz.Text = "Crear Quiz";
            this.BotonCrearQuiz.UseVisualStyleBackColor = false;
            this.BotonCrearQuiz.Click += new System.EventHandler(this.BotonCrearQuiz_Click);
            // 
            // BotonRealizarQuiz
            // 
            this.BotonRealizarQuiz.BackColor = System.Drawing.Color.Aqua;
            this.BotonRealizarQuiz.Location = new System.Drawing.Point(3, 237);
            this.BotonRealizarQuiz.Name = "BotonRealizarQuiz";
            this.BotonRealizarQuiz.Size = new System.Drawing.Size(163, 79);
            this.BotonRealizarQuiz.TabIndex = 9;
            this.BotonRealizarQuiz.Text = "Realizar Quiz";
            this.BotonRealizarQuiz.UseVisualStyleBackColor = false;
            this.BotonRealizarQuiz.Click += new System.EventHandler(this.BotonRealizarQuiz_Click);
            // 
            // BotonEstadisticas
            // 
            this.BotonEstadisticas.BackColor = System.Drawing.Color.Aqua;
            this.BotonEstadisticas.Location = new System.Drawing.Point(3, 358);
            this.BotonEstadisticas.Name = "BotonEstadisticas";
            this.BotonEstadisticas.Size = new System.Drawing.Size(163, 79);
            this.BotonEstadisticas.TabIndex = 11;
            this.BotonEstadisticas.Text = "Estadisticas";
            this.BotonEstadisticas.UseVisualStyleBackColor = false;
            this.BotonEstadisticas.Click += new System.EventHandler(this.BotonEstadisticas_Click);
            // 
            // BotonAjustes
            // 
            this.BotonAjustes.BackColor = System.Drawing.Color.Aqua;
            this.BotonAjustes.Location = new System.Drawing.Point(64, 494);
            this.BotonAjustes.Name = "BotonAjustes";
            this.BotonAjustes.Size = new System.Drawing.Size(96, 45);
            this.BotonAjustes.TabIndex = 12;
            this.BotonAjustes.Text = "Ajustes";
            this.BotonAjustes.UseVisualStyleBackColor = false;
            this.BotonAjustes.Click += new System.EventHandler(this.BotonAjustes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 664);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.BarraModificarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.BarraModificarVentana.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.NavbarIzquierda.ResumeLayout(false);
            this.NavbarSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraModificarVentana;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel NavbarIzquierda;
        private System.Windows.Forms.Panel NavbarSuperior;
        private MetroSet_UI.Controls.MetroSetBadge BotonPerfil;
        private MetroSet_UI.Controls.MetroSetControlBox BotonesModificarVentana;
        private System.Windows.Forms.Button BotonCrearQuiz;
        private System.Windows.Forms.Button BotonCrearPregunta;
        private System.Windows.Forms.Button BotonAjustes;
        private System.Windows.Forms.Button BotonRealizarQuiz;
        private System.Windows.Forms.Button BotonEstadisticas;
    }
}