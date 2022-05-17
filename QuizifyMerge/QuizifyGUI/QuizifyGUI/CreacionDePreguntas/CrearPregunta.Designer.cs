
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
            this.label3 = new System.Windows.Forms.Label();
            this.NombrePregunta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDesc = new System.Windows.Forms.Label();
            this.Descripcion = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.SelectorTipoQuiz = new System.Windows.Forms.ComboBox();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.BotonCrearPregunta = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCentralPreguntas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroSetPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.label3);
            this.metroSetPanel2.Controls.Add(this.NombrePregunta);
            this.metroSetPanel2.Controls.Add(this.label2);
            this.metroSetPanel2.Controls.Add(this.LabelDesc);
            this.metroSetPanel2.Controls.Add(this.Descripcion);
            this.metroSetPanel2.Controls.Add(this.SelectorTipoQuiz);
            this.metroSetPanel2.Controls.Add(this.metroSetDivider2);
            this.metroSetPanel2.Controls.Add(this.BotonCrearPregunta);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(200, 606);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 7;
            this.metroSetPanel2.ThemeAuthor = null;
            this.metroSetPanel2.ThemeName = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre de la pregunta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NombrePregunta
            // 
            this.NombrePregunta.Location = new System.Drawing.Point(25, 103);
            this.NombrePregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombrePregunta.Name = "NombrePregunta";
            this.NombrePregunta.Size = new System.Drawing.Size(137, 22);
            this.NombrePregunta.TabIndex = 9;
            this.NombrePregunta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de pregunta";
            // 
            // LabelDesc
            // 
            this.LabelDesc.AutoSize = true;
            this.LabelDesc.ForeColor = System.Drawing.Color.Black;
            this.LabelDesc.Location = new System.Drawing.Point(23, 169);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Size = new System.Drawing.Size(82, 17);
            this.LabelDesc.TabIndex = 6;
            this.LabelDesc.Text = "Descripcion";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoWordSelection = false;
            this.Descripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Descripcion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Descripcion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Descripcion.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Descripcion.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Descripcion.IsDerivedStyle = true;
            this.Descripcion.Lines = null;
            this.Descripcion.Location = new System.Drawing.Point(25, 197);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descripcion.MaxLength = 32767;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = false;
            this.Descripcion.Size = new System.Drawing.Size(139, 277);
            this.Descripcion.Style = MetroSet_UI.Enums.Style.Light;
            this.Descripcion.StyleManager = null;
            this.Descripcion.TabIndex = 0;
            this.Descripcion.ThemeAuthor = "Narwin";
            this.Descripcion.ThemeName = "MetroLite";
            this.Descripcion.WordWrap = true;
            this.Descripcion.TextChanged += new MetroSet_UI.Controls.MetroSetRichTextBox.TextChangedEventHandler(this.metroSetRichTextBox1_TextChanged);
            // 
            // SelectorTipoQuiz
            // 
            this.SelectorTipoQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorTipoQuiz.FormattingEnabled = true;
            this.SelectorTipoQuiz.Items.AddRange(new object[] {
            "Tipo Test",
            "Respuesta Abierta",
            "Verdadero/Falso"});
            this.SelectorTipoQuiz.Location = new System.Drawing.Point(25, 28);
            this.SelectorTipoQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectorTipoQuiz.Name = "SelectorTipoQuiz";
            this.SelectorTipoQuiz.Size = new System.Drawing.Size(137, 24);
            this.SelectorTipoQuiz.TabIndex = 5;
            this.SelectorTipoQuiz.SelectedIndexChanged += new System.EventHandler(this.SelectorTipoQuiz_SelectedIndexChanged);
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(12, 478);
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
            this.BotonCrearPregunta.Location = new System.Drawing.Point(27, 495);
            this.BotonCrearPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCrearPregunta.Name = "BotonCrearPregunta";
            this.BotonCrearPregunta.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BotonCrearPregunta.NormalTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BotonCrearPregunta.PressTextColor = System.Drawing.Color.White;
            this.BotonCrearPregunta.Size = new System.Drawing.Size(139, 44);
            this.BotonCrearPregunta.Style = MetroSet_UI.Enums.Style.Light;
            this.BotonCrearPregunta.StyleManager = null;
            this.BotonCrearPregunta.TabIndex = 1;
            this.BotonCrearPregunta.Text = "Crear Pregunta";
            this.BotonCrearPregunta.ThemeAuthor = null;
            this.BotonCrearPregunta.ThemeName = null;
            this.BotonCrearPregunta.Click += new System.EventHandler(this.BotonCrearPregunta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PanelCentralPreguntas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 532);
            this.panel1.TabIndex = 10;
            // 
            // PanelCentralPreguntas
            // 
            this.PanelCentralPreguntas.BackColor = System.Drawing.Color.Turquoise;
            this.PanelCentralPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentralPreguntas.Location = new System.Drawing.Point(0, 0);
            this.PanelCentralPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCentralPreguntas.Name = "PanelCentralPreguntas";
            this.PanelCentralPreguntas.Size = new System.Drawing.Size(801, 532);
            this.PanelCentralPreguntas.TabIndex = 0;
            this.PanelCentralPreguntas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentralPreguntas_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 74);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroSetPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 606);
            this.panel3.TabIndex = 12;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearQuiz";
            this.metroSetPanel2.ResumeLayout(false);
            this.metroSetPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetButton BotonCrearPregunta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox SelectorTipoQuiz;
        private System.Windows.Forms.Panel PanelCentralPreguntas;
        private MetroSet_UI.Controls.MetroSetRichTextBox Descripcion;
        private System.Windows.Forms.Label LabelDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombrePregunta;
        private System.Windows.Forms.Label label3;
    }
}