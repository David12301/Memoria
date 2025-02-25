using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MemoriaAPI.Entidades.Carta;

namespace MemoriaAPI.Entidades
{
    public class Grilla
    {
        public Carta[,] data = new Carta[4, 4];
        public Grilla()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = new Carta();
                }
            }

            Random r = new Random(DateTime.Now.Second);
            int max = Enum.GetValues(typeof(Carta.Color)).Cast<int>().Last();

            List<int> colorComplete = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                colorComplete.Add(i);
            }


            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    int contiene = 0;
                    do
                    {
                        int rng = r.Next(0, colorComplete.Count);
                        int val = colorComplete[rng];
                        Carta.Color ncolor = (Carta.Color)val;
                        contiene = Contiene(ncolor);
                        if (contiene < 2)
                        {
                            data[i, j].color = ncolor;
                            if (contiene == 1)
                                colorComplete.Remove(val);
                        }
                    } while (data[i, j].color == Carta.Color.VACIO);


                }
            }

        }

        public Grilla(Carta[] cartasData)
        {

            int x = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = new Carta();
                    data[i, j].color = cartasData[x].color;
                    data[i, j].estado = cartasData[x].estado;
                    x++;
                }
            }
        }

        public string GetStrIndicesSeleccionados() 
        {
            string result = string.Empty;
            List<string> lstVal = new List<string>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j].estado == Estado.SELECCIONADO)
                    {
                        lstVal.Add((i * 4 + j).ToString());
                    }
                }
            }
            result = String.Join(",", lstVal.ToArray());
            return result;
        }

        public bool ValidarCoincidencia(int i1, int i2, int j1, int j2)
        {
            return data[i1, i2].color == data[j1, j2].color;
        }

        private int Contiene(Carta.Color pcolor)
        {
            int c = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j].color == pcolor)
                    {
                        c++;
                    }
                }
            }
            return c;
        }



    }
}
