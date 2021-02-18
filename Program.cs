using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeraNota, segundaNota, terceraNota, promedioNota;      string asignatura;

            Console.WriteLine("******   Calculo de Notas ********** ");
            Console.WriteLine("Digite la asignatura: ");     asignatura = Console.ReadLine();
            Console.WriteLine("Digite la primera nota: ");   primeraNota = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la segunda nota: ");   segundaNota = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la tercera nota: ");   terceraNota = Double.Parse(Console.ReadLine());

            promedioNota = (primeraNota * 0.3 + segundaNota * 0.3 + terceraNota * 0.4) / 10;

            if (promedioNota < 3)
            {
                Console.Write($" El estudiante reprobó la asignatura {asignatura} con un rendimiento academico de {promedioNota} ");

            }
            else
            {
                Console.Write($" El estudiante aprobó la asignatura {asignatura} con un rendimiento academico de {promedioNota}");

            }
            Console.ReadKey();
        }
    }
}
