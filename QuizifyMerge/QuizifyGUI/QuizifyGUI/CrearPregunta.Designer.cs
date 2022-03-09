
namespace QuizifyGUI
{
    partial class CrearPregunta
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
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.SelectorTipoQuiz = new System.Windows.Forms.ComboBox();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.BotonCrearPregunta = new MetroSet_UI.Controls.MetroSetButton();
            this.BotonBuscarPregunta = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCentralPreguntas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroSetRichTextBox1 = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Puntuacion = new System.Windows.Forms.TextBox();
            this.metroSetPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.Puntuacion);
            this.metroSetPanel2.Controls.Add(this.label2);
            this.metroSetPanel2.Controls.Add(this.label1);
            this.metroSetPanel2.Controls.Add(this.Descripcion);
            this.metroSetPanel2.Controls.Add(this.metroSetRichTextBox1);
            this.metroSetPanel2.Controls.Add(this.SelectorTipoQuiz);
            this.metroSetPanel2.Controls.Add(this.metroSetDivider2);
            this.metroSetPanel2.Controls.Add(this.BotonCrearPregunta);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(200, 606);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 7;
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
            this.SelectorTipoQuiz.Location = new System.Drawing.Point(26, 50);
            this.SelectorTipoQuiz.Name = "SelectorTipoQuiz";
            this.SelectorTipoQuiz.Size = new System.Drawing.Size(138, 24);
            this.SelectorTipoQuiz.TabIndex = 5;
            this.SelectorTipoQuiz.SelectedIndexChanged += new System.EventHandler(this.SelectorTipoQuiz_SelectedIndexChanged);
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(12, 483);
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
            this.BotonCrearPregunta.Location = new System.Drawing.Point(26, 529);
            this.BotonCrearPregunta.Name = "BotonCrearPregunta";
            this.BotonCrearPregunta.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.Size = new System.Drawing.Size(138, 44);
            this.BotonCrearPregunta.Style = MetroSet_UI.Enums.Style.Light;
            this.BotonCrearPregunta.StyleManager = null;
            this.BotonCrearPregunta.TabIndex = 1;
            this.BotonCrearPregunta.Text = "Crear Pregunta";
            this.BotonCrearPregunta.ThemeAuthor = null;
            this.BotonCrearPregunta.ThemeName = null;
            this.BotonCrearPregunta.Click += new System.EventHandler(this.BotonCrearPregunta_Click);
            // 
            // BotonBuscarPregunta
            // 
            this.BotonBuscarPregunta.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.ForeColor = System.Drawing.Color.Transparent;
            this.BotonBuscarPregunta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonBuscarPregunta.Location = new System.Drawing.Point(662, 16);
            this.BotonBuscarPregunta.Name = "BotonBuscarPregunta";
            this.BotonBuscarPregunta.Size = new System.Drawing.Size(43, 33);
            this.BotonBuscarPregunta.TabIndex = 9;
            this.BotonBuscarPregunta.Text = "W";
            this.BotonBuscarPregunta.UseVisualStyleBackColor = false;
            this.BotonBuscarPregunta.Click += new System.EventHandler(this.BotonBuscarPregunta_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(533, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PanelCentralPreguntas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 532);
            this.panel1.TabIndex = 10;
            // 
            // PanelCentralPreguntas
            // 
            this.PanelCentralPreguntas.BackColor = System.Drawing.Color.DarkRed;
            this.PanelCentralPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentralPreguntas.Location = new System.Drawing.Point(0, 0);
            this.PanelCentralPreguntas.Name = "PanelCentralPreguntas";
            this.PanelCentralPreguntas.Size = new System.Drawing.Size(801, 532);
            this.PanelCentralPreguntas.TabIndex = 0;
            this.PanelCentralPreguntas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentralPreguntas_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.BotonBuscarPregunta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 74);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroSetPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 606);
            this.panel3.TabIndex = 12;
            // 
            // metroSetRichTextBox1
            // 
            this.metroSetRichTextBox1.AutoWordSelection = false;
            this.metroSetRichTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRichTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetRichTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRichTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetRichTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetRichTextBox1.IsDerivedStyle = true;
            this.metroSetRichTextBox1.Lines = null;
            this.metroSetRichTextBox1.Location = new System.Drawing.Point(26, 200);
            this.metroSetRichTextBox1.MaxLength = 32767;
            this.metroSetRichTextBox1.Name = "metroSetRichTextBox1";
            this.metroSetRichTextBox1.ReadOnly = false;
            this.metroSetRichTextBox1.Size = new System.Drawing.Size(138, 277);
            this.metroSetRichTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRichTextBox1.StyleManager = null;
            this.metroSetRichTextBox1.TabIndex = 0;
            this.metroSetRichTextBox1.ThemeAuthor = "Narwin";
            this.metroSetRichTextBox1.ThemeName = "MetroLite";
            this.metroSetRichTextBox1.WordWrap = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.ForeColor = System.Drawing.Color.Black;
            this.Descripcion.Location = new System.Drawing.Point(23, 170);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puntuacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de pregunta";
            // 
            // Puntuacion
            // 
            this.Puntuacion.Location = new System.Drawing.Point(26, 130);
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Size = new System.Drawing.Size(138, 22);
            this.Puntuacion.TabIndex = 0;
            // 
            // CrearPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearQuiz";
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetButton BotonCrearPregunta;
        private System.Windows.Forms.Button BotonBuscarPregunta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox SelectorTipoQuiz;
        private System.Windows.Forms.Panel PanelCentralPreguntas;
        private MetroSet_UI.Controls.MetroSetRichTextBox metroSetRichTextBox1;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Puntuacion;
    }
}