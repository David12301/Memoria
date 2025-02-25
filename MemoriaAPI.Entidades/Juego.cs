using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaAPI.Entidades
{
    public class Juego
    {
        public enum Estado { INICIO = 0, FIN = 1, REINICIO = 2 };

        public Estado estado { get; set; }

        public int cantidadMovimientos { get; set; }

        public int parejasEncontradas { get; set; }

        public Juego()
        {
            estado = Estado.INICIO;
            cantidadMovimientos = 0;
            parejasEncontradas = 0;
        }

    }
}
