
namespace QuizifyGUI
{
    partial class JuegoQuiz
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
            this.BotonesModificarVentana = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tituloQuiz = new System.Windows.Forms.Label();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.BarraModificarVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraModificarVentana
            // 
            this.BarraModificarVentana.Controls.Add(this.BotonesModificarVentana);
            this.BarraModificarVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraModificarVentana.Location = new System.Drawing.Point(0, 0);
            this.BarraModificarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BarraModificarVentana.Name = "BarraModificarVentana";
            this.BarraModificarVentana.Size = new System.Drawing.Size(793, 33);
            this.BarraModificarVentana.TabIndex = 1;
            // 
            // BotonesModificarVentana
            // 
            this.BotonesModificarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonesModificarVentana.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BotonesModificarVentana.CloseHoverForeColor = System.Drawing.Color.White;
            this.BotonesModificarVentana.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.BotonesModificarVentana.DisabledForeColor = System.Drawing.Color.DimGray;
            this.BotonesModificarVentana.IsDerivedStyle = true;
            this.BotonesModificarVentana.Location = new System.Drawing.Point(636, 1);
            this.BotonesModificarVentana.Margin = new System.Windows.Forms.Padding(2);
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
            // tituloQuiz
            // 
            this.tituloQuiz.AutoSize = true;
            this.tituloQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloQuiz.Location = new System.Drawing.Point(310, 44);
            this.tituloQuiz.Name = "tituloQuiz";
            this.tituloQuiz.Size = new System.Drawing.Size(152, 55);
            this.tituloQuiz.TabIndex = 2;
            this.tituloQuiz.Text = "label1";
            this.tituloQuiz.Click += new System.EventHandler(this.tituloQuiz_Click);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnunciado.Location = new System.Drawing.Point(44, 120);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(86, 31);
            this.labelEnunciado.TabIndex = 3;
            this.labelEnunciado.Text = "label1";
            this.labelEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JuegoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 496);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.tituloQuiz);
            this.Controls.Add(this.BarraModificarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegoQuiz";
            this.Text = "JuegoQuiz";
            this.Load += new System.EventHandler(this.JuegoQuiz_Load);
            this.BarraModificarVentana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraModificarVentana;
        private MetroSet_UI.Controls.MetroSetControlBox BotonesModificarVentana;
        private System.Windows.Forms.Label tituloQuiz;
        private System.Windows.Forms.Label labelEnunciado;
    }
}