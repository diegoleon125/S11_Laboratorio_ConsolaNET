using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace S11_Laboratorio_ConsolaNET
{
    public class Pantallas
    {
        public static int[] nota = new int[300];
        public static int contador = 0;
        public static int PantallaPrincipal()
        {
            Console.Clear();
            string texto = TituloPantalla("Casos con arreglos") +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir\n" +
                "================================\n";
            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion > 7) return 0;
            return opcion;
        }
        public static int RegistrarNotas()
        {
            Console.Clear();
            string texto = TituloPantalla("Registrar una nota");
            Console.Write(texto);
            nota[contador] = Operaciones.getEntero("Ingresa la nota Nro " + (contador + 1) + ": ", texto);
            string texto2 = "================================\n";
            string texto3 = "1: Registrar otra nota\n" +
                "2: Regresar\n" +
                "================================\n";
            Console.Write(texto2 + texto3);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto + texto3);
            contador++;
            if (opcion == 1) return 1;
            return 0;
        }
        public static int NotaMayor()
        {
            Console.Clear();
            string texto = TituloPantalla("La nota mayor");
            if (contador == 0)
            {
                texto += "No existe";
            }
            else
            {
                int notamayor = nota[0];
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] > notamayor) notamayor = nota[i];
                }
                texto += "La nota mayor es: " + notamayor + "\n";
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] == notamayor)
                    {
                        texto += "[" + nota[i] + "]" + " ";
                    }
                    else
                    {
                        texto += nota[i] + " ";
                    }
                }
            }
            texto += "\n" + "================================\n" +
                "1: Regresar\n" +
                "================================\n";
            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 2;
        }
        public static int NotaMenor()
        {
            Console.Clear();
            string texto = TituloPantalla("La nota menor");
            if (contador == 0)
            {
                texto += "No existe";
            } else
            {
                int notamenor = nota[0];
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] < notamenor) notamenor = nota[i];
                }
                texto  += "La nota menor es: " + notamenor + "\n";
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] == notamenor)
                    {
                        texto += "[" + nota[i] + "]" + " ";
                    }
                    else
                    {
                        texto += nota[i] + " ";
                    }
                }
            }
            texto += "\n" + "================================\n" +
                "1: Regresar\n" +
                "================================\n";
            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 3;
        }
        public static int EncontrarNota()
        {
            Console.Clear();
            string texto = TituloPantalla("Buscar nota");
            Console.Write(texto);
            int notabuscar = Operaciones.getEntero("Ingrese la nota a buscar: ", texto);
            int posicion = -1;
            for (int i = 0; i < contador; i++)
            {
                if (nota[i] == notabuscar)
                {
                    posicion = i;
                }
            }
            string texto2 = "";
            if (posicion == -1)
            {
                texto2 = "La nota no existe\n";
            } else {
                texto2 = "La nota está en la posición " + posicion + "\n";
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] == notabuscar)
                    {
                        texto2 += i + "-> " + "[" + nota[i] + "]\n";
                    }
                    else
                    {
                        texto2 += i + " -> " + nota[i] + "\n";
                    }
                }
            }
            texto2 += "================================\n";
            Console.Write(texto2);
            string texto3 = "1: Regresar\n" +
                "================================\n";
            Console.Write(texto3);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto + texto3);
            return 0;
        }
        public static int ModificarNota()
        {
            Console.Clear();
            string texto = TituloPantalla("Modificar nota");
            Console.Write(texto);
            int posicion = Operaciones.getEntero("Ingrese la posición: ", texto);
            int nuevovalor = Operaciones.getEntero("Ingrese el nuevo valor: ", texto);
            string texto2 = "";
            if (posicion >= contador)
            {
                texto2 = "La posicion " + posicion + " no existe\n";
            }
            else
            {
                texto2 = "================================\n" +
                "Antes:\n";
                for (int i = 0; i < contador; i++)
                {
                    if (i == posicion)
                    {
                        texto2 += "[" + nota[i] + "]" + " ";
                    }
                    else
                    {
                        texto2 += nota[i] + " ";
                    }
                }
                nota[posicion] = nuevovalor;
                texto2 += "\n" + "Despues:\n";
                for (int i = 0; i < contador; i++)
                {
                    if (i == posicion)
                    {
                        texto2 += "[" + nota[i] + "]" + " ";
                    }
                    else
                    {
                        texto2 += nota[i] + " ";
                    }
                }
                texto2 += "\n" + "================================\n";
            }
            string texto3 = "1: Regresar\n" +
                "================================\n";
            Console.Write(texto2 + texto3);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto + texto3);
            return 0;
        }
        public static int NotasRegistradas()
        {
            Console.Clear();
            string texto = TituloPantalla("Notas Registradas");
            if (contador == 0)
            {
                texto += "Sin notas\n";
            }
            else
            {
                texto += "Notas actuales:\n";
                for (int i = 0; i < contador; i++)
                {
                    texto += nota[i];
                    if (i < contador - 1)  texto += " - ";
                }
                texto += "\nSiguiente posición será: " + contador + "\n";
            }
            texto += "================================\n" +
                "1: Regresar\n" +
                "================================\n";
            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 6;
        }
        public static string TituloPantalla(string titulo)
        {
            return "================================\n" + titulo + "\n" + "================================\n";
        }
    }
}
