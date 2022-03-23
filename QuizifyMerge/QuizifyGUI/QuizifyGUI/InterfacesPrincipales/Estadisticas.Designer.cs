
namespace QuizifyGUI.InterfacesPrincipales
{
    partial class Estadisticas
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
            this.GridDatosPreguntas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BotonBuscarPregunta = new System.Windows.Forms.Button();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.SelectorTipoQuiz = new System.Windows.Forms.ComboBox();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosPreguntas)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridDatosPreguntas
            // 
            this.GridDatosPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta,
            this.Nota});
            this.GridDatosPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDatosPreguntas.Location = new System.Drawing.Point(200, 74);
            this.GridDatosPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridDatosPreguntas.Name = "GridDatosPreguntas";
            this.GridDatosPreguntas.ReadOnly = true;
            this.GridDatosPreguntas.RowHeadersWidth = 51;
            this.GridDatosPreguntas.RowTemplate.Height = 24;
            this.GridDatosPreguntas.Size = new System.Drawing.Size(766, 486);
            this.GridDatosPreguntas.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.BotonBuscarPregunta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 74);
            this.panel2.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 21);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(533, 22);
            this.textBox4.TabIndex = 8;
            // 
            // BotonBuscarPregunta
            // 
            this.BotonBuscarPregunta.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BotonBuscarPregunta.ForeColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonBuscarPregunta.Location = new System.Drawing.Point(661, 16);
            this.BotonBuscarPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonBuscarPregunta.Name = "BotonBuscarPregunta";
            this.BotonBuscarPregunta.Size = new System.Drawing.Size(72, 33);
            this.BotonBuscarPregunta.TabIndex = 9;
            this.BotonBuscarPregunta.Text = "Bucar";
            this.BotonBuscarPregunta.UseVisualStyleBackColor = false;
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.label5);
            this.metroSetPanel2.Controls.Add(this.label6);
            this.metroSetPanel2.Controls.Add(this.label3);
            this.metroSetPanel2.Controls.Add(this.label4);
            this.metroSetPanel2.Controls.Add(this.label2);
            this.metroSetPanel2.Controls.Add(this.label1);
            this.metroSetPanel2.Controls.Add(this.SelectorTipoQuiz);
            this.metroSetPanel2.Controls.Add(this.metroSetDivider2);
            this.metroSetPanel2.Controls.Add(this.textBox1);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(200, 560);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 17;
            this.metroSetPanel2.ThemeAuthor = null;
            this.metroSetPanel2.ThemeName = null;
            // 
            // SelectorTipoQuiz
            // 
            this.SelectorTipoQuiz.FormattingEnabled = true;
            this.SelectorTipoQuiz.Items.AddRange(new object[] {
            "Tipo Test",
            "Respuesta Abierta",
            "Verdadero/Falso"});
            this.SelectorTipoQuiz.Location = new System.Drawing.Point(27, 202);
            this.SelectorTipoQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectorTipoQuiz.Name = "SelectorTipoQuiz";
            this.SelectorTipoQuiz.Size = new System.Drawing.Size(137, 24);
            this.SelectorTipoQuiz.TabIndex = 5;
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(15, 470);
            this.metroSetDivider2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(175, 4);
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
            this.textBox1.Location = new System.Drawing.Point(27, 261);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Pregunta
            // 
            this.Pregunta.DataPropertyName = "Pregunta";
            this.Pregunta.FillWeight = 1000F;
            this.Pregunta.HeaderText = "Nombre del alumno";
            this.Pregunta.MinimumWidth = 6;
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            this.Pregunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pregunta.Width = 125;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nota media ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(142, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(142, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suspensos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(142, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aprobados";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 560);
            this.Controls.Add(this.GridDatosPreguntas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroSetPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosPreguntas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatosPreguntas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BotonBuscarPregunta;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private System.Windows.Forms.ComboBox SelectorTipoQuiz;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}