using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        private List<string> palabras;
        private string palabraSeleccionada;
        //private string palabraSeleccionada;
        private List<Label> etiquetasLetras = new List<Label>();
        private int intentosFallidos = 0; 
        private int maxIntentos = 6; 

        private List<Image> imagenesAhorcado;

        public Form1()
        {
            InitializeComponent();
            cargarImagenesAhorcado();
            actualizarImagenAhorcado();
            this.BackgroundImage = Properties.Resources.goingMerry;
            groupBoxInicioSesion.Visible = false;
            pictureBoxDibujoAhorcado.Visible = false;
            panelAniadirPalabra.Visible = false;
            labelIntentosRestantes.Visible = false;
            pictureBoxZoro.Visible = false;
            pictureBoxPirata.Visible = false;
            pictureBoxLuffy.Visible = false;
            comboBoxDificultad.Items.Add("Fácil");
            comboBoxDificultad.Items.Add("Normal");
            comboBoxDificultad.Items.Add("Difícil");
            comboBoxDificultad.SelectedIndex = 0;
            labelIntentosRestantes.Text = "Intentos Restantes = " + (maxIntentos - intentosFallidos);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            llenarPanelAbecedario();
            string rutaArchivo = "C:/Users/crise/source/repos/ahorcadoCSharp/Ahorcado/Ahorcado/Resources/palabras.txt";
            //JuegoAhorcado juego = new JuegoAhorcado(rutaArchivo);

            string dificultadSeleccionada = comboBoxDificultad.SelectedItem.ToString();
            palabras = LeerPalabrasDesdeArchivo(rutaArchivo);
            palabraSeleccionada = seleccionarPalabraAleatoria();

            // Mostrar los huecos de la nueva palabra
            mostrarHuecos(palabraSeleccionada, dificultadSeleccionada);
            actualizarImagenAhorcado();

            intentosFallidos = 0;
            panelAbecedario.Visible = true;
            panelPalabra.Visible = true;
            botonJugar.Visible = false;
            botonIniciarSesionAdmin.Visible = false;
            comboBoxDificultad.Visible = false;
            pictureBoxDibujoAhorcado.Visible = true;
            labelIntentosRestantes.Visible = true;
            //pictureBoxTitulo.Visible = false;
            pictureBoxZoro.Visible = true;
            pictureBoxPirata.Visible = true;



        }
        private void llenarPanelAbecedario()
        {
            // Elimina cualquier control previo en el FlowLayoutPanel
            panelAbecedario.Controls.Clear();

            // Crear botones para cada letra del alfabeto
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                // Crear un botón
                Button botonLetra = new Button
                {
                    Text = letra.ToString(), // Texto del botón (la letra)
                    Width = 50, // Ancho del botón
                    Height = 50, // Alto del botón
                    Font = new Font("Arial", 14, FontStyle.Bold), // Estilo de la fuente
                    BackColor = Color.LightBlue // Color de fondo
                };

                // Asociar un evento Click al botón
                botonLetra.Click += BotonLetra_Click;

                // Agregar el botón al FlowLayoutPanel
                panelAbecedario.Controls.Add(botonLetra);
            }
        }

        private void mostrarHuecos(string palabra, string dificultad)
        {
            panelPalabra.Controls.Clear();
            etiquetasLetras.Clear();

            int letrasADestapar;
            if (dificultad == "Fácil")
            {
                letrasADestapar = 2;
            }
            else if (dificultad == "Normal")
            {
                letrasADestapar = 1;
            }
            else
            {
                letrasADestapar = 0;
            }

            // Crear un Label para cada letra de la palabra
            foreach (char letra in palabra)
            {
                Label etiqueta = new Label
                {
                    Text = "_",
                    Width = 40,
                    Height = 40, 
                    Font = new Font("Arial", 16, FontStyle.Bold), 
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle
                };

                panelPalabra.Controls.Add(etiqueta);
                etiquetasLetras.Add(etiqueta);
            }

            Random random = new Random();

            List<char> caracteresAleatorios = new List<char>();

            while (caracteresAleatorios.Count < letrasADestapar)
            {
                int indiceAleatorio = random.Next(palabra.Length);
                char letraAleatoria = palabra[indiceAleatorio];

                // Comprobar si la letra ya fue seleccionada
                if (!caracteresAleatorios.Contains(letraAleatoria))
                {
                    caracteresAleatorios.Add(letraAleatoria);
                }
            }
            foreach (char caracter in caracteresAleatorios)
            {
                actualizarHuecos(caracter);
            }
        }


        private void actualizarHuecos(char letra)
        {
            for (int i = 0; i < palabraSeleccionada.Length; i++)
            {
                if (palabraSeleccionada[i] == letra)
                {
                    etiquetasLetras[i].Text = letra.ToString();
                }
            }
        }
        private void BotonLetra_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            char letraPulsada = boton.Text[0];

            boton.Enabled = false;

            if (palabraSeleccionada.Contains(letraPulsada))
            {
                // Actualiza los huecos si la letra es correcta y pone el fondo verde
                boton.BackColor = Color.LightGreen;
                actualizarHuecos(letraPulsada);

                if (comprobarSiPalabraCompleta())
                {
                    MessageBox.Show("¡Felicidades! Has adivinado la palabra.");
                    reiniciarJuego();
                }
            }
            else
            {
                //cambia el color del botón a rojo
                boton.BackColor = Color.LightCoral;
                intentosFallidos++;
                actualizarImagenAhorcado();
                labelIntentosRestantes.Text = "Intentos Restantes = " + (maxIntentos - intentosFallidos);
                if(intentosFallidos == 4)
                {
                    pictureBoxLuffy.Visible = true;
                }
                if (intentosFallidos >= maxIntentos)
                {
                    // Rellena los huecos con la palabra completa
                    for (int i = 0; i < palabraSeleccionada.Length; i++)
                    {
                        etiquetasLetras[i].Text = palabraSeleccionada[i].ToString();
                    }

                    MessageBox.Show($"Has perdido. La palabra era: {palabraSeleccionada}");

                    reiniciarJuego();
                }
            }
        }
        private void reiniciarJuego()
        {
            this.BackgroundImage = Properties.Resources.goingMerry;
            panelPalabra.Controls.Clear();

            etiquetasLetras.Clear();
            palabraSeleccionada = null;
            intentosFallidos = 0;

            panelPalabra.Visible = false;
            panelAbecedario.Visible = false;
            botonJugar.Visible = true;
            botonIniciarSesionAdmin.Visible = true;
            pictureBoxDibujoAhorcado.Visible = false;
            comboBoxDificultad.Visible = true;
            labelIntentosRestantes.Visible = false;
            //pictureBoxTitulo.Visible = true;
            pictureBoxZoro.Visible = false;
            pictureBoxPirata.Visible = false;
            pictureBoxLuffy.Visible = false;

        }
        private bool comprobarSiPalabraCompleta()
        {
            bool palabraCompleta = true;
            // Comprueba si todas las etiquetas ya no tienen guiones
            foreach (Label etiqueta in etiquetasLetras)
            {
                if (etiqueta.Text == "_")
                {
                    palabraCompleta = false; 
                }
            }
            return palabraCompleta;
        }

        private void cargarImagenesAhorcado()
        {
            this.imagenesAhorcado = new List<Image>();
            imagenesAhorcado.Add(Properties.Resources.ahorcado0);
            imagenesAhorcado.Add(Properties.Resources.ahorcado1);
            imagenesAhorcado.Add(Properties.Resources.ahorcado2);
            imagenesAhorcado.Add(Properties.Resources.ahorcado3);
            imagenesAhorcado.Add(Properties.Resources.ahorcado4);
            imagenesAhorcado.Add(Properties.Resources.ahorcado5);
            imagenesAhorcado.Add(Properties.Resources.ahorcado6);
        }

        private void actualizarImagenAhorcado()
        {
            if (intentosFallidos >= 0 && intentosFallidos <= maxIntentos)
            {
                pictureBoxDibujoAhorcado.Image = imagenesAhorcado[intentosFallidos];
            }
        }

        private void botonIniciarSesionAdmin_Click(object sender, EventArgs e)
        {
            groupBoxInicioSesion.Visible = true;
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContrasenia.Text;

            if (usuario == "admin" && contraseña == "1234") 
            {

                MessageBox.Show("Sesión iniciada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                groupBoxInicioSesion.Visible = false;
                panelAniadirPalabra.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalirLogin_Click(object sender, EventArgs e)
        {
            groupBoxInicioSesion.Visible = false;
        }

        private void buttonCancelarAniadirPalabra_Click(object sender, EventArgs e)
        {
            panelAniadirPalabra.Visible = false;
        }

        private void buttonAniadirPalabra_Click(object sender, EventArgs e)
        {
            string nuevaPalabra = textBoxNuevaPalabra.Text.Trim();

            if (!string.IsNullOrEmpty(nuevaPalabra))
            {
                string rutaArchivo = "C:/Users/crise/source/repos/ahorcadoCSharp/Ahorcado/Ahorcado/Resources/palabras.txt";

                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(nuevaPalabra);
                }

                MessageBox.Show("Palabra añadida con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNuevaPalabra.Clear();
            }
            else
            {
                MessageBox.Show("Introduce una palabra válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> LeerPalabrasDesdeArchivo(string rutaArchivo)
        {
            List<string> listaPalabras = new List<string>();

            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    listaPalabras.Add(linea.Trim().ToUpper());
                }
            }


            return listaPalabras;
        }

        public string seleccionarPalabraAleatoria()
        {
            Random random = new Random();
            palabraSeleccionada = palabras[random.Next(palabras.Count)];
            return palabraSeleccionada;
        }
    }
}
