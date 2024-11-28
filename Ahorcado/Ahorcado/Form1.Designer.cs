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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAbecedario = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.buttonSalirLogin = new System.Windows.Forms.Button();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelAniadirPalabra = new System.Windows.Forms.Panel();
            this.buttonCancelarAniadirPalabra = new System.Windows.Forms.Button();
            this.textBoxNuevaPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAniadirPalabra = new System.Windows.Forms.Button();
            this.labelIntentosRestantes = new System.Windows.Forms.Label();
            this.pictureBoxLuffy = new System.Windows.Forms.PictureBox();
            this.pictureBoxPirata = new System.Windows.Forms.PictureBox();
            this.pictureBoxZoro = new System.Windows.Forms.PictureBox();
            this.botonIniciarSesionAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.pictureBoxDibujoAhorcado = new System.Windows.Forms.PictureBox();
            this.botonJugar = new System.Windows.Forms.PictureBox();
            this.groupBoxInicioSesion.SuspendLayout();
            this.panelAniadirPalabra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuffy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonIniciarSesionAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujoAhorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonJugar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAbecedario
            // 
            this.panelAbecedario.BackColor = System.Drawing.Color.Transparent;
            this.panelAbecedario.Location = new System.Drawing.Point(40, 560);
            this.panelAbecedario.Name = "panelAbecedario";
            this.panelAbecedario.Size = new System.Drawing.Size(976, 184);
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
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxInicioSesion.Controls.Add(this.buttonSalirLogin);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxContrasenia);
            this.groupBoxInicioSesion.Controls.Add(this.label1);
            this.groupBoxInicioSesion.Controls.Add(this.labelUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.textBoxUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.buttonIniciarSesion);
            this.groupBoxInicioSesion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(360, 330);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(368, 152);
            this.groupBoxInicioSesion.TabIndex = 8;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Inicia Sesión";
            // 
            // buttonSalirLogin
            // 
            this.buttonSalirLogin.Location = new System.Drawing.Point(200, 112);
            this.buttonSalirLogin.Name = "buttonSalirLogin";
            this.buttonSalirLogin.Size = new System.Drawing.Size(104, 31);
            this.buttonSalirLogin.TabIndex = 5;
            this.buttonSalirLogin.Text = "Salir";
            this.buttonSalirLogin.UseVisualStyleBackColor = true;
            this.buttonSalirLogin.Click += new System.EventHandler(this.buttonSalirLogin_Click);
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(176, 72);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(168, 22);
            this.textBoxContrasenia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(24, 32);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(72, 22);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(176, 32);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(168, 22);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(40, 112);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(104, 31);
            this.buttonIniciarSesion.TabIndex = 0;
            this.buttonIniciarSesion.Text = "Login";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // panelAniadirPalabra
            // 
            this.panelAniadirPalabra.BackColor = System.Drawing.Color.SkyBlue;
            this.panelAniadirPalabra.Controls.Add(this.buttonCancelarAniadirPalabra);
            this.panelAniadirPalabra.Controls.Add(this.textBoxNuevaPalabra);
            this.panelAniadirPalabra.Controls.Add(this.label2);
            this.panelAniadirPalabra.Controls.Add(this.buttonAniadirPalabra);
            this.panelAniadirPalabra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panelAniadirPalabra.Location = new System.Drawing.Point(370, 330);
            this.panelAniadirPalabra.Name = "panelAniadirPalabra";
            this.panelAniadirPalabra.Size = new System.Drawing.Size(352, 152);
            this.panelAniadirPalabra.TabIndex = 9;
            // 
            // buttonCancelarAniadirPalabra
            // 
            this.buttonCancelarAniadirPalabra.Location = new System.Drawing.Point(192, 104);
            this.buttonCancelarAniadirPalabra.Name = "buttonCancelarAniadirPalabra";
            this.buttonCancelarAniadirPalabra.Size = new System.Drawing.Size(104, 31);
            this.buttonCancelarAniadirPalabra.TabIndex = 4;
            this.buttonCancelarAniadirPalabra.Text = "Cancelar";
            this.buttonCancelarAniadirPalabra.UseVisualStyleBackColor = true;
            this.buttonCancelarAniadirPalabra.Click += new System.EventHandler(this.buttonCancelarAniadirPalabra_Click);
            // 
            // textBoxNuevaPalabra
            // 
            this.textBoxNuevaPalabra.Location = new System.Drawing.Point(32, 56);
            this.textBoxNuevaPalabra.Name = "textBoxNuevaPalabra";
            this.textBoxNuevaPalabra.Size = new System.Drawing.Size(280, 22);
            this.textBoxNuevaPalabra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Añade una palabra al juego : ";
            // 
            // buttonAniadirPalabra
            // 
            this.buttonAniadirPalabra.Location = new System.Drawing.Point(32, 104);
            this.buttonAniadirPalabra.Name = "buttonAniadirPalabra";
            this.buttonAniadirPalabra.Size = new System.Drawing.Size(104, 31);
            this.buttonAniadirPalabra.TabIndex = 1;
            this.buttonAniadirPalabra.Text = "Añadir";
            this.buttonAniadirPalabra.UseVisualStyleBackColor = true;
            this.buttonAniadirPalabra.Click += new System.EventHandler(this.buttonAniadirPalabra_Click);
            // 
            // labelIntentosRestantes
            // 
            this.labelIntentosRestantes.AutoSize = true;
            this.labelIntentosRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntentosRestantes.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIntentosRestantes.Location = new System.Drawing.Point(48, 240);
            this.labelIntentosRestantes.Name = "labelIntentosRestantes";
            this.labelIntentosRestantes.Size = new System.Drawing.Size(73, 22);
            this.labelIntentosRestantes.TabIndex = 10;
            this.labelIntentosRestantes.Text = "Intentos";
            // 
            // pictureBoxLuffy
            // 
            this.pictureBoxLuffy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLuffy.Image = global::Ahorcado.Properties.Resources._3f56de2a5942850b93acc3eb37bc5f11_removebg_preview;
            this.pictureBoxLuffy.Location = new System.Drawing.Point(264, 184);
            this.pictureBoxLuffy.Name = "pictureBoxLuffy";
            this.pictureBoxLuffy.Size = new System.Drawing.Size(176, 144);
            this.pictureBoxLuffy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLuffy.TabIndex = 13;
            this.pictureBoxLuffy.TabStop = false;
            // 
            // pictureBoxPirata
            // 
            this.pictureBoxPirata.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPirata.Image = global::Ahorcado.Properties.Resources.si_removebg_preview;
            this.pictureBoxPirata.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxPirata.Name = "pictureBoxPirata";
            this.pictureBoxPirata.Size = new System.Drawing.Size(176, 112);
            this.pictureBoxPirata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPirata.TabIndex = 12;
            this.pictureBoxPirata.TabStop = false;
            // 
            // pictureBoxZoro
            // 
            this.pictureBoxZoro.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxZoro.Image = global::Ahorcado.Properties.Resources.zoroBigote;
            this.pictureBoxZoro.Location = new System.Drawing.Point(1000, 24);
            this.pictureBoxZoro.Name = "pictureBoxZoro";
            this.pictureBoxZoro.Size = new System.Drawing.Size(176, 112);
            this.pictureBoxZoro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxZoro.TabIndex = 11;
            this.pictureBoxZoro.TabStop = false;
            // 
            // botonIniciarSesionAdmin
            // 
            this.botonIniciarSesionAdmin.BackColor = System.Drawing.Color.Transparent;
            this.botonIniciarSesionAdmin.Image = global::Ahorcado.Properties.Resources.account_circle_line;
            this.botonIniciarSesionAdmin.Location = new System.Drawing.Point(1120, 690);
            this.botonIniciarSesionAdmin.Name = "botonIniciarSesionAdmin";
            this.botonIniciarSesionAdmin.Size = new System.Drawing.Size(48, 56);
            this.botonIniciarSesionAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonIniciarSesionAdmin.TabIndex = 4;
            this.botonIniciarSesionAdmin.TabStop = false;
            this.botonIniciarSesionAdmin.Click += new System.EventHandler(this.botonIniciarSesionAdmin_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitulo.Image = global::Ahorcado.Properties.Resources.tituloOnePiece;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(72, 24);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(976, 144);
            this.pictureBoxTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitulo.TabIndex = 7;
            this.pictureBoxTitulo.TabStop = false;
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
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Controls.Add(this.pictureBoxLuffy);
            this.Controls.Add(this.pictureBoxPirata);
            this.Controls.Add(this.pictureBoxZoro);
            this.Controls.Add(this.labelIntentosRestantes);
            this.Controls.Add(this.panelAniadirPalabra);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.Controls.Add(this.botonIniciarSesionAdmin);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.pictureBoxDibujoAhorcado);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.panelAbecedario);
            this.Controls.Add(this.panelPalabra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado One Piece";
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            this.panelAniadirPalabra.ResumeLayout(false);
            this.panelAniadirPalabra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLuffy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonIniciarSesionAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujoAhorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonJugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelAbecedario;
        private System.Windows.Forms.PictureBox botonJugar;
        private System.Windows.Forms.FlowLayoutPanel panelPalabra;
        private System.Windows.Forms.PictureBox botonIniciarSesionAdmin;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.PictureBox pictureBoxDibujoAhorcado;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.GroupBox groupBoxInicioSesion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonSalirLogin;
        private System.Windows.Forms.Panel panelAniadirPalabra;
        private System.Windows.Forms.Button buttonCancelarAniadirPalabra;
        private System.Windows.Forms.TextBox textBoxNuevaPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAniadirPalabra;
        private System.Windows.Forms.Label labelIntentosRestantes;
        private System.Windows.Forms.PictureBox pictureBoxZoro;
        private System.Windows.Forms.PictureBox pictureBoxPirata;
        private System.Windows.Forms.PictureBox pictureBoxLuffy;
    }
}

