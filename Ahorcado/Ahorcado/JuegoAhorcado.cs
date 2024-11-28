using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Ahorcado
{
    internal class JuegoAhorcado
    {
        
        private List<string> palabras; // Lista para almacenar las palabras
        private string palabraSeleccionada; // La palabra seleccionada aleatoriamente

        public JuegoAhorcado(string rutaArchivo)
        {
            // Leer palabras desde el archivo
            palabras = LeerPalabrasDesdeArchivo(rutaArchivo);
        }

        // Método para leer las palabras del archivo
        private List<string> LeerPalabrasDesdeArchivo(string rutaArchivo)
        {
            List<string> listaPalabras = new List<string>();

            try
            {
                //Lee el archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                //Añade cada linea del text a la lista
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        listaPalabras.Add(linea.Trim().ToUpper()); // Convertir a mayúsculas
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return listaPalabras;
        }

        // Método para seleccionar una palabra aleatoriamente
        public string SeleccionarPalabraAleatoria()
        {
            if (palabras.Count == 0)
            {
                throw new InvalidOperationException("No hay palabras disponibles para seleccionar.");
            }

            Random random = new Random();
            //int indice = ; // Seleccionar un índice aleatorio
            palabraSeleccionada = palabras[random.Next(palabras.Count)];
            return palabraSeleccionada;
        }

        // Método para obtener la palabra seleccionada
        public string ObtenerPalabraSeleccionada()
        {
            return palabraSeleccionada;
        }
    }

}
