
namespace QuizifyGUI
{
    partial class CrearQuiz
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BotonBuscarPregunta = new System.Windows.Forms.Button();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SelectorTipoQuiz = new System.Windows.Forms.ComboBox();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonCrearPregunta = new MetroSet_UI.Controls.MetroSetButton();
            this.GridDatosPreguntas = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.BotonBuscarPregunta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 60);
            this.panel2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 17);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(401, 20);
            this.textBox4.TabIndex = 8;
            // 
            // BotonBuscarPregunta
            // 
            this.BotonBuscarPregunta.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BotonBuscarPregunta.ForeColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonBuscarPregunta.Location = new System.Drawing.Point(496, 13);
            this.BotonBuscarPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscarPregunta.Name = "BotonBuscarPregunta";
            this.BotonBuscarPregunta.Size = new System.Drawing.Size(54, 27);
            this.BotonBuscarPregunta.TabIndex = 9;
            this.BotonBuscarPregunta.Text = "Bucar";
            this.BotonBuscarPregunta.UseVisualStyleBackColor = false;
            this.BotonBuscarPregunta.Click += new System.EventHandler(this.BotonBuscarPregunta_Click);
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.checkBox1);
            this.metroSetPanel2.Controls.Add(this.SelectorTipoQuiz);
            this.metroSetPanel2.Controls.Add(this.metroSetDivider2);
            this.metroSetPanel2.Controls.Add(this.textBox1);
            this.metroSetPanel2.Controls.Add(this.BotonCrearPregunta);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(150, 487);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 12;
            this.metroSetPanel2.ThemeAuthor = null;
            this.metroSetPanel2.ThemeName = null;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(12, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Mostrar calificacion";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SelectorTipoQuiz
            // 
            this.SelectorTipoQuiz.FormattingEnabled = true;
            this.SelectorTipoQuiz.Items.AddRange(new object[] {
            "Tipo Test",
            "Respuesta Abierta",
            "Verdadero/Falso"});
            this.SelectorTipoQuiz.Location = new System.Drawing.Point(20, 22);
            this.SelectorTipoQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.SelectorTipoQuiz.Name = "SelectorTipoQuiz";
            this.SelectorTipoQuiz.Size = new System.Drawing.Size(104, 21);
            this.SelectorTipoQuiz.TabIndex = 5;
            this.SelectorTipoQuiz.SelectedIndexChanged += new System.EventHandler(this.SelectorTipoQuiz_SelectedIndexChanged);
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(11, 382);
            this.metroSetDivider2.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(131, 4);
            this.metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 4;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroLite";
            this.metroSetDivider2.Thickness = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 2;
            // 
            // BotonCrearPregunta
            // 
            this.BotonCrearPregunta.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.DisabledForeColor = System.Drawing.Color.Gray;
            this.BotonCrearPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BotonCrearPregunta.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotonCrearPregunta.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BotonCrearPregunta.HoverTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.IsDerivedStyle = true;
            this.BotonCrearPregunta.Location = new System.Drawing.Point(20, 409);
            this.BotonCrearPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCrearPregunta.Name = "BotonCrearPregunta";
            this.BotonCrearPregunta.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.Size = new System.Drawing.Size(104, 36);
            this.BotonCrearPregunta.Style = MetroSet_UI.Enums.Style.Light;
            this.BotonCrearPregunta.StyleManager = null;
            this.BotonCrearPregunta.TabIndex = 1;
            this.BotonCrearPregunta.Text = "Crear Quiz";
            this.BotonCrearPregunta.ThemeAuthor = null;
            this.BotonCrearPregunta.ThemeName = null;
            this.BotonCrearPregunta.Click += new System.EventHandler(this.BotonCrearPregunta_Click);
            // 
            // GridDatosPreguntas
            // 
            this.GridDatosPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.Pregunta});
            this.GridDatosPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDatosPreguntas.Location = new System.Drawing.Point(150, 60);
            this.GridDatosPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.GridDatosPreguntas.Name = "GridDatosPreguntas";
            this.GridDatosPreguntas.ReadOnly = true;
            this.GridDatosPreguntas.RowHeadersWidth = 51;
            this.GridDatosPreguntas.RowTemplate.Height = 24;
            this.GridDatosPreguntas.Size = new System.Drawing.Size(637, 427);
            this.GridDatosPreguntas.TabIndex = 15;
            this.GridDatosPreguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosPreguntas_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Width = 125;
            // 
            // Pregunta
            // 
            this.Pregunta.DataPropertyName = "Pregunta";
            this.Pregunta.FillWeight = 1000F;
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.MinimumWidth = 6;
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            this.Pregunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pregunta.Width = 125;
            // 
            // CrearQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.GridDatosPreguntas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroSetPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearPregunta";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BotonBuscarPregunta;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private System.Windows.Forms.ComboBox SelectorTipoQuiz;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroSet_UI.Controls.MetroSetButton BotonCrearPregunta;
        private System.Windows.Forms.DataGridView GridDatosPreguntas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}