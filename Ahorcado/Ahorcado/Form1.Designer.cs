namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAbecedario = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.botonIniciarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDibujoAhorcado = new System.Windows.Forms.PictureBox();
            this.botonJugar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botonIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujoAhorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonJugar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAbecedario
            // 
            this.panelAbecedario.BackColor = System.Drawing.Color.Transparent;
            this.panelAbecedario.Location = new System.Drawing.Point(32, 560);
            this.panelAbecedario.Name = "panelAbecedario";
            this.panelAbecedario.Size = new System.Drawing.Size(1120, 184);
            this.panelAbecedario.TabIndex = 0;
            // 
            // panelPalabra
            // 
            this.panelPalabra.BackColor = System.Drawing.Color.Transparent;
            this.panelPalabra.Location = new System.Drawing.Point(34, 336);
            this.panelPalabra.Name = "panelPalabra";
            this.panelPalabra.Size = new System.Drawing.Size(736, 144);
            this.panelPalabra.TabIndex = 2;
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Location = new System.Drawing.Point(536, 420);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(144, 24);
            this.comboBoxDificultad.TabIndex = 5;
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.botonIniciarSesion.Image = global::Ahorcado.Properties.Resources.account_circle_line;
            this.botonIniciarSesion.Location = new System.Drawing.Point(1120, 690);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(48, 56);
            this.botonIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonIniciarSesion.TabIndex = 4;
            this.botonIniciarSesion.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ahorcado.Properties.Resources.tituloOnePiece;
            this.pictureBox1.Location = new System.Drawing.Point(72, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxDibujoAhorcado
            // 
            this.pictureBoxDibujoAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDibujoAhorcado.Location = new System.Drawing.Point(776, 144);
            this.pictureBoxDibujoAhorcado.Name = "pictureBoxDibujoAhorcado";
            this.pictureBoxDibujoAhorcado.Size = new System.Drawing.Size(408, 416);
            this.pictureBoxDibujoAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDibujoAhorcado.TabIndex = 6;
            this.pictureBoxDibujoAhorcado.TabStop = false;
            // 
            // botonJugar
            // 
            this.botonJugar.BackColor = System.Drawing.Color.Transparent;
            this.botonJugar.Image = global::Ahorcado.Properties.Resources.image_removebg_preview;
            this.botonJugar.Location = new System.Drawing.Point(512, 330);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(184, 80);
            this.botonJugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonJugar.TabIndex = 1;
            this.botonJugar.TabStop = false;
            this.botonJugar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxDibujoAhorcado);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.panelAbecedario);
            this.Controls.Add(this.panelPalabra);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.botonIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujoAhorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonJugar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelAbecedario;
        private System.Windows.Forms.PictureBox botonJugar;
        private System.Windows.Forms.FlowLayoutPanel panelPalabra;
        private System.Windows.Forms.PictureBox botonIniciarSesion;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.PictureBox pictureBoxDibujoAhorcado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

