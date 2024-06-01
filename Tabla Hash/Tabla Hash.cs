using EstructuraDeClases.Listas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class TablaHash
    {
        public static readonly int TamTabla = 99;
        public Lista[] ListaHash = new Lista[TamTabla];
        int posicion;

        public int HashPlegamiento(int valor)
        {
            string v = valor.ToString();
            return Convert.ToInt32(v.Substring(0, 2)) + Convert.ToInt32(v.Substring(2, 2)) + Convert.ToInt32(v.Substring(4, 2));
        }
        public int HashMod(int Valor)
        {
            return Valor % TamTabla;
        }

        public Int64 HashMitadCuadrado(int valor)
        {
            SqlDouble q = Math.Pow(valor, 2);
            string v = q.ToString();
            Int64 x = Convert.ToUInt32(v.Substring(3, 3));
            return x;
        }

        public int HashMultiplicacion(int valor)
        {
            Double x = 0.5654845;
            Double d = valor * x;
            string cadena = d.ToString();
            string[] subCadenas = cadena.Split('.');
            Double ParteEntera = Convert.ToDouble(subCadenas[0]);
            Double y = (d - ParteEntera) * (TamTabla + 1);
            cadena = Convert.ToString(y);
            subCadenas = cadena.Split(".");
            return Convert.ToInt32(subCadenas[0]);
        }

        public void Insertar(object Dato, int clave)
        {
            posicion = HashMod(clave);

            if (ListaHash[posicion] == null)
            {
                ListaHash[posicion] = new Lista();
            }
            ListaHash[posicion].InsertarCabezaLista(Dato);
        }
        public object Buscar(int clave)
        {
            posicion= HashMod(clave);
            if (ListaHash[posicion] == null)
            {
                ListaHash[posicion] = new Lista();
            }
            NodoLista temp = ListaHash[posicion].Primero;
                        
            return temp;
        }
    }
}