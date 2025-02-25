﻿using MemoriaAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaAPI.Logica
{
    public class ValidacionLogica
    {
        public bool ValidarJugada(int[] data, Carta[] cartasData)
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

            bool flag = false;
            if (g.data[i1, i2].estado == Carta.Estado.SELECCIONADO &&
                g.data[j1, j2].estado == Carta.Estado.SELECCIONADO)
            {
                flag = true;
            }

            return flag;
        }
     }
}
