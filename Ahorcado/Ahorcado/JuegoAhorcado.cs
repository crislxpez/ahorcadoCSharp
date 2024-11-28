using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Ahorcado
{
    internal class JuegoAhorcado
    {
        
        private List<string> palabras;
        private string palabraSeleccionada;

        public JuegoAhorcado(string rutaArchivo)
        {
            //palabras = LeerPalabrasDesdeArchivo(rutaArchivo);
        }


        // Método para seleccionar una palabra aleatoriamente


        public string obtenerPalabraSeleccionada()
        {
            return palabraSeleccionada;
        }
    }

}
