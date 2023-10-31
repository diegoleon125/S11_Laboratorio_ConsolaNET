using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_Laboratorio_ConsolaNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.PantallaPrincipal();
            do
            {
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.RegistrarNotas();
                        break;
                    case 2:
                        opcion = Pantallas.NotaMayor();
                        break;
                    case 3:
                        opcion = Pantallas.NotaMenor();
                        break;
                    case 4:
                        opcion = Pantallas.EncontrarNota();
                        break;
                    case 5:
                        opcion = Pantallas.ModificarNota();
                        break;
                    case 6:
                        opcion = Pantallas.NotasRegistradas();
                        break;
                    case 0:
                        opcion = Pantallas.PantallaPrincipal();
                        break;
                }
            } while (opcion != 7);

            Console.ReadKey();
        }
    }
}
