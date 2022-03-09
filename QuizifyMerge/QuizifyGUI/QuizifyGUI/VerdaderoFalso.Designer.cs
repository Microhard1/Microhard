
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BotonFalso = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EnunciadoVerdaderoFalso = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(253, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 217);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BotonFalso
            // 
            this.BotonFalso.AutoSize = true;
            this.BotonFalso.BackColor = System.Drawing.Color.Red;
            this.BotonFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFalso.ForeColor = System.Drawing.Color.White;
            this.BotonFalso.Location = new System.Drawing.Point(575, 370);
            this.BotonFalso.Name = "BotonFalso";
            this.BotonFalso.Size = new System.Drawing.Size(134, 40);
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
            this.radioButton1.Location = new System.Drawing.Point(40, 370);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(226, 40);
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
            this.EnunciadoVerdaderoFalso.MaxLength = 32767;
            this.EnunciadoVerdaderoFalso.Multiline = false;
            this.EnunciadoVerdaderoFalso.Name = "EnunciadoVerdaderoFalso";
            this.EnunciadoVerdaderoFalso.ReadOnly = false;
            this.EnunciadoVerdaderoFalso.Size = new System.Drawing.Size(800, 49);
            this.EnunciadoVerdaderoFalso.Style = MetroSet_UI.Enums.Style.Light;
            this.EnunciadoVerdaderoFalso.StyleManager = null;
            this.EnunciadoVerdaderoFalso.TabIndex = 4;
            this.EnunciadoVerdaderoFalso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EnunciadoVerdaderoFalso.ThemeAuthor = "Narwin";
            this.EnunciadoVerdaderoFalso.ThemeName = "MetroLite";
            this.EnunciadoVerdaderoFalso.UseSystemPasswordChar = false;
            this.EnunciadoVerdaderoFalso.WatermarkText = "PREGUNTA";
            // 
            // VerdaderoFalso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BotonFalso);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.EnunciadoVerdaderoFalso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerdaderoFalso";
            this.Text = "VerdaderoFalso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton BotonFalso;
        private System.Windows.Forms.RadioButton radioButton1;
        private MetroSet_UI.Controls.MetroSetTextBox EnunciadoVerdaderoFalso;
    }
}