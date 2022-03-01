
namespace DemoCreacionPreguntas
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
            System.Windows.Forms.RadioButton radioButton1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerdaderoFalso));
            this.TextoPregunta = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.crearQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // TextoPregunta
            // 
            this.TextoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoPregunta.Location = new System.Drawing.Point(83, 27);
            this.TextoPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.TextoPregunta.Multiline = true;
            this.TextoPregunta.Name = "TextoPregunta";
            this.TextoPregunta.Size = new System.Drawing.Size(537, 66);
            this.TextoPregunta.TabIndex = 1;
            this.TextoPregunta.Text = "Pregunta";
            this.TextoPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radioButton1.Location = new System.Drawing.Point(83, 148);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(184, 72);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Verdadero";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(83, 226);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 72);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Falso";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.AccessibleName = "imagenPregunta";
            this.imagenPregunta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagenPregunta.Image = ((System.Drawing.Image)(resources.GetObject("imagenPregunta.Image")));
            this.imagenPregunta.Location = new System.Drawing.Point(436, 123);
            this.imagenPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(184, 218);
            this.imagenPregunta.TabIndex = 5;
            this.imagenPregunta.TabStop = false;
            // 
            // crearQuiz
            // 
            this.crearQuiz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.crearQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.crearQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crearQuiz.BorderRadius = 0;
            this.crearQuiz.ButtonText = "CREAR";
            this.crearQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.crearQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.crearQuiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("crearQuiz.Iconimage")));
            this.crearQuiz.Iconimage_right = null;
            this.crearQuiz.Iconimage_right_Selected = null;
            this.crearQuiz.Iconimage_Selected = null;
            this.crearQuiz.IconMarginLeft = 0;
            this.crearQuiz.IconMarginRight = 0;
            this.crearQuiz.IconRightVisible = true;
            this.crearQuiz.IconRightZoom = 0D;
            this.crearQuiz.IconVisible = true;
            this.crearQuiz.IconZoom = 90D;
            this.crearQuiz.IsTab = false;
            this.crearQuiz.Location = new System.Drawing.Point(436, 355);
            this.crearQuiz.Name = "crearQuiz";
            this.crearQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.crearQuiz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.crearQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.crearQuiz.selected = false;
            this.crearQuiz.Size = new System.Drawing.Size(184, 48);
            this.crearQuiz.TabIndex = 8;
            this.crearQuiz.Text = "CREAR";
            this.crearQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crearQuiz.Textcolor = System.Drawing.Color.White;
            this.crearQuiz.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // VerdaderoFalso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 415);
            this.Controls.Add(this.crearQuiz);
            this.Controls.Add(this.imagenPregunta);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(radioButton1);
            this.Controls.Add(this.TextoPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerdaderoFalso";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoPregunta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox imagenPregunta;
        private Bunifu.Framework.UI.BunifuFlatButton crearQuiz;
    }
}