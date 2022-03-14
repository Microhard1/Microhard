
namespace QuizifyGUI
{
    partial class VerdaderoFalso
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
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.BotonFalso = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EnunciadoVerdaderoFalso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.botonAñadirImagen = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.Location = new System.Drawing.Point(203, 62);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(205, 176);
            this.imagenPregunta.TabIndex = 7;
            this.imagenPregunta.TabStop = false;
            this.imagenPregunta.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BotonFalso
            // 
            this.BotonFalso.AutoSize = true;
            this.BotonFalso.BackColor = System.Drawing.Color.Red;
            this.BotonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFalso.ForeColor = System.Drawing.Color.White;
            this.BotonFalso.Location = new System.Drawing.Point(431, 301);
            this.BotonFalso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonFalso.Name = "BotonFalso";
            this.BotonFalso.Size = new System.Drawing.Size(109, 33);
            this.BotonFalso.TabIndex = 6;
            this.BotonFalso.TabStop = true;
            this.BotonFalso.Text = "FALSO";
            this.BotonFalso.UseVisualStyleBackColor = false;
            this.BotonFalso.CheckedChanged += new System.EventHandler(this.BotonFalso_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Lime;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(30, 301);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 33);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VERDADERO";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // EnunciadoVerdaderoFalso
            // 
            this.EnunciadoVerdaderoFalso.AutoCompleteCustomSource = null;
            this.EnunciadoVerdaderoFalso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EnunciadoVerdaderoFalso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EnunciadoVerdaderoFalso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnunciadoVerdaderoFalso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EnunciadoVerdaderoFalso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnunciadoVerdaderoFalso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.EnunciadoVerdaderoFalso.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnunciadoVerdaderoFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnunciadoVerdaderoFalso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.EnunciadoVerdaderoFalso.Image = null;
            this.EnunciadoVerdaderoFalso.IsDerivedStyle = true;
            this.EnunciadoVerdaderoFalso.Lines = null;
            this.EnunciadoVerdaderoFalso.Location = new System.Drawing.Point(0, 0);
            this.EnunciadoVerdaderoFalso.Margin = new System.Windows.Forms.Padding(2);
            this.EnunciadoVerdaderoFalso.MaxLength = 32767;
            this.EnunciadoVerdaderoFalso.Multiline = false;
            this.EnunciadoVerdaderoFalso.Name = "EnunciadoVerdaderoFalso";
            this.EnunciadoVerdaderoFalso.ReadOnly = false;
            this.EnunciadoVerdaderoFalso.Size = new System.Drawing.Size(600, 40);
            this.EnunciadoVerdaderoFalso.Style = MetroSet_UI.Enums.Style.Light;
            this.EnunciadoVerdaderoFalso.StyleManager = null;
            this.EnunciadoVerdaderoFalso.TabIndex = 4;
            this.EnunciadoVerdaderoFalso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EnunciadoVerdaderoFalso.ThemeAuthor = "Narwin";
            this.EnunciadoVerdaderoFalso.ThemeName = "MetroLite";
            this.EnunciadoVerdaderoFalso.UseSystemPasswordChar = false;
            this.EnunciadoVerdaderoFalso.WatermarkText = "PREGUNTA";
            this.EnunciadoVerdaderoFalso.Click += new System.EventHandler(this.EnunciadoVerdaderoFalso_Click);
            // 
            // botonAñadirImagen
            // 
            this.botonAñadirImagen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.DisabledForeColor = System.Drawing.Color.Gray;
            this.botonAñadirImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.botonAñadirImagen.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.botonAñadirImagen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.botonAñadirImagen.HoverTextColor = System.Drawing.Color.White;
            this.botonAñadirImagen.IsDerivedStyle = true;
            this.botonAñadirImagen.Location = new System.Drawing.Point(250, 256);
            this.botonAñadirImagen.Name = "botonAñadirImagen";
            this.botonAñadirImagen.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.NormalTextColor = System.Drawing.Color.White;
            this.botonAñadirImagen.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonAñadirImagen.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonAñadirImagen.PressTextColor = System.Drawing.Color.White;
            this.botonAñadirImagen.Size = new System.Drawing.Size(108, 43);
            this.botonAñadirImagen.Style = MetroSet_UI.Enums.Style.Light;
            this.botonAñadirImagen.StyleManager = null;
            this.botonAñadirImagen.TabIndex = 15;
            this.botonAñadirImagen.Text = "Añadir imagen";
            this.botonAñadirImagen.ThemeAuthor = "Narwin";
            this.botonAñadirImagen.ThemeName = "MetroLite";
            this.botonAñadirImagen.Click += new System.EventHandler(this.botonAñadirImagen_Click);
            // 
            // VerdaderoFalso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.botonAñadirImagen);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.BotonFalso);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.EnunciadoVerdaderoFalso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerdaderoFalso";
            this.Text = "VerdaderoFalso";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPregunta;
        private System.Windows.Forms.RadioButton BotonFalso;
        private System.Windows.Forms.RadioButton radioButton1;
        private MetroSet_UI.Controls.MetroSetTextBox EnunciadoVerdaderoFalso;
        private MetroSet_UI.Controls.MetroSetButton botonAñadirImagen;
    }
}