using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_Laboratorio_ConsolaNET
{
    public class Operaciones
    {

        public static int getEntero(string prefijo, string reemplazo)
        {
            int respuesta = 0;
            bool correcto = false;
            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = int.TryParse(numeroTexto, out respuesta);
                if (!correcto)
                {
                    Console.Clear();
                    Console.Write(reemplazo);
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);
            if (respuesta < 1) return 0;
            return respuesta;
        }

        public static float getDecimal(string prefijo)
        {
            float respuesta = 0;
            bool correcto = false;
            do
            {
                string numeroTexto = getTextoPantalla(prefijo);
                correcto = float.TryParse(numeroTexto, out respuesta);
                if (!correcto)
                {
                    Console.WriteLine("Ingresa un número válido");
                }
            } while (!correcto);
            return respuesta;
        }

        public static string getTextoPantalla(string prefijo)
        {
            Console.Write(prefijo);
            return Console.ReadLine();
        }

    }
}
