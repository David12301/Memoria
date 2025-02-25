using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaAPI.Entidades
{
    public class Carta
    {
        public enum Color
        {
            VACIO = 0, VERDE = 1, AZUL = 2, AMARILLO = 3,
            NARANJA = 4, MARRON = 5, NEGRO = 6, MORADO = 7, ROJO = 8
        };

        public enum Estado { OCULTO = 0, MUESTRA = 1, SELECCIONADO = 2 }

        public Color color { get; set; }

        public Estado estado { get; set; }


        public Carta()
        {
            color = Color.VACIO;
            estado = Estado.OCULTO;
        }
    }
}
