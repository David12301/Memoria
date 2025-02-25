using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoriaAPI.Entidades;

namespace MemoriaAPI.Logica
{
    public class JuegoLogica
    {
        public Juego Iniciar() 
        {
            return new Juego();
        }

        public bool JuegoTerminado(Grilla g) 
        {
            for (int i = 0; i < g.data.GetLength(0); i++) 
            {
                for (int j = 0; j < g.data.GetLength(1); j++) {
                    if (g.data[i, j].estado != Carta.Estado.SELECCIONADO) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
