using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        private string palabraSeleccionada;
        private List<Label> etiquetasLetras = new List<Label>(); // Lista para los huecos
        private int intentosFallidos = 0; // Contador de intentos fallidos
        private int maxIntentos = 5; // Límite de intentos fallidos

        private List<Image> imagenesAhorcado;

        public Form1()
        {
            InitializeComponent();
            cargarImagenesAhorcado();
            ActualizarImagenAhorcado();
            this.BackgroundImage = Properties.Resources.goingMerry;
            pictureBoxDibujoAhorcado.Visible = false;
            comboBoxDificultad.Items.Add("Fácil");
            comboBoxDificultad.Items.Add("Normal");
            comboBoxDificultad.Items.Add("Difícil");
            comboBoxDificultad.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            // Llenar el FlowLayoutPanel inferior con las letras del alfabeto
            LlenarFlowLayoutPanel();
            // Seleccionar una nueva palabra
            string rutaArchivo = "C:/Users/crise/Desktop/2DAM/DI/ahorcado/palabras.txt"; // Cambia esta ruta si es necesario
            JuegoAhorcado juego = new JuegoAhorcado(rutaArchivo);

            string dificultadSeleccionada = comboBoxDificultad.SelectedItem.ToString();
            palabraSeleccionada = juego.SeleccionarPalabraAleatoria();

            // Mostrar los huecos de la nueva palabra
            MostrarHuecos(palabraSeleccionada, dificultadSeleccionada);

            // Resetear el estado del juego
            intentosFallidos = 0;
            ActualizarImagenAhorcado();

            // Mostrar los elementos del juego
            panelAbecedario.Visible = true;
            panelPalabra.Visible = true;

            // Ocultar el botón de "Jugar"
            botonJugar.Visible = false;
            botonIniciarSesion.Visible = false;
            comboBoxDificultad.Visible = false;
            pictureBoxDibujoAhorcado.Visible = true;


        }
        private void LlenarFlowLayoutPanel()
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

        private void MostrarHuecos(string palabra, string dificultad)
        {
            // Limpiar el FlowLayoutPanel y la lista
            panelPalabra.Controls.Clear();
            etiquetasLetras.Clear();

            // Determinar el número de letras a destapar según la dificultad
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
                letrasADestapar = 0; // Valor predeterminado en caso de error
            }

            // Crear un Label para cada letra de la palabra
            foreach (char letra in palabra)
            {
                Label etiqueta = new Label
                {
                    Text = "_", // Inicialmente se muestra como un guion bajo
                    Width = 40, // Ancho de la etiqueta
                    Height = 40, // Alto de la etiqueta
                    Font = new Font("Arial", 16, FontStyle.Bold), // Fuente
                    TextAlign = ContentAlignment.MiddleCenter, // Alinear el texto
                    BorderStyle = BorderStyle.FixedSingle // Estilo de borde
                };

                // Agregar la etiqueta al FlowLayoutPanel y a la lista
                panelPalabra.Controls.Add(etiqueta);
                etiquetasLetras.Add(etiqueta);
            }

            Random random = new Random();

            // Crear una lista para almacenar los caracteres aleatorios
            List<char> caracteresAleatorios = new List<char>();

            // Seleccionar los caracteres aleatorios sin repetidos
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
                ActualizarHuecos(caracter);
            }
        }


        // Método para actualizar los huecos al acertar una letra
        private void ActualizarHuecos(char letra)
        {
            // Recorrer la palabra seleccionada y verificar coincidencias
            for (int i = 0; i < palabraSeleccionada.Length; i++)
            {
                if (palabraSeleccionada[i] == letra)
                {
                    // Actualizar el texto del Label correspondiente
                    etiquetasLetras[i].Text = letra.ToString();
                }
            }
        }
        // Evento Click de los botones de letras
        private void BotonLetra_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            char letraPulsada = boton.Text[0]; // Obtener la letra del botón

            // Deshabilitar el botón después de pulsarlo
            boton.Enabled = false;

            // Verificar si la letra está en la palabra
            if (palabraSeleccionada.Contains(letraPulsada))
            {
                // Actualiza los huecos si la letra es correcta y pone el fondo verde
                boton.BackColor = Color.LightGreen;
                ActualizarHuecos(letraPulsada);

                // Verificar si se ha completado la palabra
                if (PalabraCompletada())
                {
                    MessageBox.Show("¡Felicidades! Has adivinado la palabra.");
                    ReiniciarJuego(); // Reinicia el juego
                }
            }
            else
            {
                //cambia el color del botón a rojo
                boton.BackColor = Color.LightCoral;
                // Incrementar los intentos fallidos
                intentosFallidos++;
                MessageBox.Show($"Letra incorrecta. Intentos fallidos: {intentosFallidos}/{maxIntentos}");
                ActualizarImagenAhorcado();
                // Verificar si se ha alcanzado el límite de intentos
                if (intentosFallidos >= maxIntentos)
                {
                    // Rellenar los huecos con la palabra completa
                    for (int i = 0; i < palabraSeleccionada.Length; i++)
                    {
                        etiquetasLetras[i].Text = palabraSeleccionada[i].ToString();
                    }

                    // Mostrar un mensaje indicando que se ha perdido
                    MessageBox.Show($"Has perdido. La palabra era: {palabraSeleccionada}");

                    // Reiniciar el juego después de mostrar la palabra
                    ReiniciarJuego();
                }
            }
        }
        private void ReiniciarJuego()
        {
            this.BackgroundImage = Properties.Resources.goingMerry;
            // Limpiar el FlowLayoutPanel
            panelPalabra.Controls.Clear();

            // Limpiar las listas y variables de estado
            etiquetasLetras.Clear();
            palabraSeleccionada = null;
            intentosFallidos = 0;

            // Ocultar todos los elementos excepto el botón de "Jugar"
            panelPalabra.Visible = false;
            panelAbecedario.Visible = false;

            // Mostrar únicamente el botón de "Jugar"
            botonJugar.Visible = true;
            botonIniciarSesion.Visible = true;
            pictureBoxDibujoAhorcado.Visible = false;
            comboBoxDificultad.Visible = true;

        }
        private bool PalabraCompletada()
        {
            bool palabraCompleta = true;
            // Comprueba si todas las etiquetas ya no tienen guiones bajos
            foreach (Label etiqueta in etiquetasLetras)
            {
                if (etiqueta.Text == "_")
                {
                    palabraCompleta = false; // Todavía hay letras por adivinar
                }
            }
            return palabraCompleta; // Todas las letras han sido adivinadas
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

        private void ActualizarImagenAhorcado()
        {
            if (intentosFallidos >= 0 && intentosFallidos <= maxIntentos)
            {
                // Actualizar la imagen del PictureBox
                pictureBoxDibujoAhorcado.Image = imagenesAhorcado[intentosFallidos];
            }
        }
    }
}
