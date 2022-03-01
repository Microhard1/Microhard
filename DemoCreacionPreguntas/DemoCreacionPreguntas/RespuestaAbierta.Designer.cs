namespace DemoCreacionPreguntas
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
            this.TextoPregunta = new System.Windows.Forms.TextBox();
            
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.textoRespuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // TextoPregunta
            // 
            this.TextoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoPregunta.Location = new System.Drawing.Point(120, 33);
            this.TextoPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.TextoPregunta.Multiline = true;
            this.TextoPregunta.Name = "TextoPregunta";
            this.TextoPregunta.Size = new System.Drawing.Size(537, 66);
            this.TextoPregunta.TabIndex = 2;
            this.TextoPregunta.Text = "Pregunta";
            this.TextoPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextoPregunta.TextChanged += new System.EventHandler(this.TextoPregunta_TextChanged);
            // 
            // crearQuiz
            // 
           
            // imagenPregunta
            // 
            this.imagenPregunta.AccessibleName = "imagenPregunta";
            this.imagenPregunta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagenPregunta.Image = ((System.Drawing.Image)(resources.GetObject("imagenPregunta.Image")));
            this.imagenPregunta.Location = new System.Drawing.Point(477, 117);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(184, 218);
            this.imagenPregunta.TabIndex = 9;
            this.imagenPregunta.TabStop = false;
            // 
            // textoRespuesta
            // 
            this.textoRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRespuesta.Location = new System.Drawing.Point(120, 117);
            this.textoRespuesta.Margin = new System.Windows.Forms.Padding(2);
            this.textoRespuesta.Multiline = true;
            this.textoRespuesta.Name = "textoRespuesta";
            this.textoRespuesta.Size = new System.Drawing.Size(344, 218);
            this.textoRespuesta.TabIndex = 11;
            this.textoRespuesta.Text = "Respuesta";
            this.textoRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RespuestaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 428);
            this.Controls.Add(this.textoRespuesta);
            
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.TextoPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RespuestaAbierta";
            this.Text = "RespuestaAbierta";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoPregunta;
        
        private System.Windows.Forms.PictureBox imagenPregunta;
        private System.Windows.Forms.TextBox textoRespuesta;
    }
}