using System;
using System.Collections.Generic;

namespace ExempleTest
{
    public class shelf
    {
        public static List<string> lista = new List<string>();
        public static void Put(string nome)
        {
            if (nome != string.Empty)
            {
                lista.Add(nome);
            }
        }

        public static bool Take(string nome)
        {
            return lista.Remove(nome);
        }
    }
}