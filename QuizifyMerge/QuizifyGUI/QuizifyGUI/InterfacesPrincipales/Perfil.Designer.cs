
namespace QuizifyGUI
{
    partial class Perfil
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.LabelCorreoElectronico = new System.Windows.Forms.Label();
            this.LabelNombreUsuario = new System.Windows.Forms.Label();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(492, 353);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 9;
            this.metroSetLabel1.Text = "Nivel";
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // metroSetProgressBar1
            // 
            this.metroSetProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.IsDerivedStyle = true;
            this.metroSetProgressBar1.Location = new System.Drawing.Point(392, 394);
            this.metroSetProgressBar1.Maximum = 100;
            this.metroSetProgressBar1.Minimum = 0;
            this.metroSetProgressBar1.Name = "metroSetProgressBar1";
            this.metroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.Size = new System.Drawing.Size(318, 23);
            this.metroSetProgressBar1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetProgressBar1.StyleManager = null;
            this.metroSetProgressBar1.TabIndex = 8;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = null;
            this.metroSetProgressBar1.ThemeName = null;
            this.metroSetProgressBar1.Value = 50;
            // 
            // LabelCorreoElectronico
            // 
            this.LabelCorreoElectronico.AutoSize = true;
            this.LabelCorreoElectronico.Location = new System.Drawing.Point(461, 299);
            this.LabelCorreoElectronico.Name = "LabelCorreoElectronico";
            this.LabelCorreoElectronico.Size = new System.Drawing.Size(164, 17);
            this.LabelCorreoElectronico.TabIndex = 7;
            this.LabelCorreoElectronico.Text = "PacoAlumno@gmail.com";
            // 
            // LabelNombreUsuario
            // 
            this.LabelNombreUsuario.AutoSize = true;
            this.LabelNombreUsuario.Location = new System.Drawing.Point(500, 241);
            this.LabelNombreUsuario.Name = "LabelNombreUsuario";
            this.LabelNombreUsuario.Size = new System.Drawing.Size(92, 17);
            this.LabelNombreUsuario.TabIndex = 6;
            this.LabelNombreUsuario.Text = "Paco Paquito";
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenPregunta.Location = new System.Drawing.Point(420, 11);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(258, 205);
            this.imagenPregunta.TabIndex = 13;
            this.imagenPregunta.TabStop = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 568);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.LabelCorreoElectronico);
            this.Controls.Add(this.LabelNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
        private System.Windows.Forms.Label LabelCorreoElectronico;
        private System.Windows.Forms.Label LabelNombreUsuario;
        private System.Windows.Forms.PictureBox imagenPregunta;
    }
}