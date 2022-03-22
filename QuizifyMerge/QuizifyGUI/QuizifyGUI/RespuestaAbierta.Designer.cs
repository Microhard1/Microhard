
namespace QuizifyGUI
{
    partial class RespuestaAbierta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespuestaAbierta));
            this.metroSetRichTextBox1 = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.metroSetTextBox3 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.botonAñadirImagen = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetRichTextBox1
            // 
            this.metroSetRichTextBox1.AutoWordSelection = false;
            this.metroSetRichTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroSetRichTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetRichTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRichTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetRichTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetRichTextBox1.IsDerivedStyle = true;
            this.metroSetRichTextBox1.Lines = null;
            this.metroSetRichTextBox1.Location = new System.Drawing.Point(23, 101);
            this.metroSetRichTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetRichTextBox1.MaxLength = 32767;
            this.metroSetRichTextBox1.Name = "metroSetRichTextBox1";
            this.metroSetRichTextBox1.ReadOnly = false;
            this.metroSetRichTextBox1.Size = new System.Drawing.Size(304, 246);
            this.metroSetRichTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRichTextBox1.StyleManager = null;
            this.metroSetRichTextBox1.TabIndex = 13;
            this.metroSetRichTextBox1.Text = resources.GetString("metroSetRichTextBox1.Text");
            this.metroSetRichTextBox1.ThemeAuthor = "Narwin";
            this.metroSetRichTextBox1.ThemeName = "MetroLite";
            this.metroSetRichTextBox1.WordWrap = true;
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPregunta.Location = new System.Drawing.Point(495, 101);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(279, 325);
            this.imagenPregunta.TabIndex = 12;
            this.imagenPregunta.TabStop = false;
            this.imagenPregunta.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // metroSetTextBox3
            // 
            this.metroSetTextBox3.AutoCompleteCustomSource = null;
            this.metroSetTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox3.Image = null;
            this.metroSetTextBox3.IsDerivedStyle = true;
            this.metroSetTextBox3.Lines = null;
            this.metroSetTextBox3.Location = new System.Drawing.Point(0, 0);
            this.metroSetTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSetTextBox3.MaxLength = 32767;
            this.metroSetTextBox3.Multiline = false;
            this.metroSetTextBox3.Name = "metroSetTextBox3";
            this.metroSetTextBox3.ReadOnly = false;
            this.metroSetTextBox3.Size = new System.Drawing.Size(800, 49);
            this.metroSetTextBox3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox3.StyleManager = null;
            this.metroSetTextBox3.TabIndex = 11;
            this.metroSetTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox3.ThemeAuthor = "Narwin";
            this.metroSetTextBox3.ThemeName = "MetroLite";
            this.metroSetTextBox3.UseSystemPasswordChar = false;
            this.metroSetTextBox3.WatermarkText = "PREGUNTA";
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
            this.botonAñadirImagen.Location = new System.Drawing.Point(97, 373);
            this.botonAñadirImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonAñadirImagen.Name = "botonAñadirImagen";
            this.botonAñadirImagen.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.botonAñadirImagen.NormalTextColor = System.Drawing.Color.White;
            this.botonAñadirImagen.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonAñadirImagen.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.botonAñadirImagen.PressTextColor = System.Drawing.Color.White;
            this.botonAñadirImagen.Size = new System.Drawing.Size(144, 53);
            this.botonAñadirImagen.Style = MetroSet_UI.Enums.Style.Light;
            this.botonAñadirImagen.StyleManager = null;
            this.botonAñadirImagen.TabIndex = 14;
            this.botonAñadirImagen.Text = "Añadir imagen";
            this.botonAñadirImagen.ThemeAuthor = "Narwin";
            this.botonAñadirImagen.ThemeName = "MetroLite";
            this.botonAñadirImagen.Click += new System.EventHandler(this.botonAñadirImagen_Click);
            // 
            // RespuestaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAñadirImagen);
            this.Controls.Add(this.metroSetRichTextBox1);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.metroSetTextBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RespuestaAbierta";
            this.Text = "RespuestaAbierta";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetRichTextBox metroSetRichTextBox1;
        private System.Windows.Forms.PictureBox imagenPregunta;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox3;
        private MetroSet_UI.Controls.MetroSetButton botonAñadirImagen;
    }
}