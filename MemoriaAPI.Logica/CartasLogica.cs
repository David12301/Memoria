using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoriaAPI.Entidades;

namespace MemoriaAPI.Logica
{
    public class CartasLogica
    {
        public bool Jugada(int[] data, Carta[] cartasData)
        {
            if (data == null || data.Length != 4)
            {
                throw new Exception("Malformed data");
            }

            if (cartasData == null || cartasData.Length != 16)
            {
                throw new Exception("Malformed data");
            }

            int i1, i2, j1, j2;
            i1 = i2 = j1 = j2 = -1;
            i1 = data[0];
            i2 = data[1];
            j1 = data[2];
            j2 = data[3];

            Grilla g = new Grilla(cartasData);
            bool flag = g.ValidarCoincidencia(i1, i2, j1, j2);
            return flag;

        }

        public Grilla Nuevo() 
        {
            return new Grilla();
        }

    }
}
