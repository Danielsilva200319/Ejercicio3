using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class NewClass
    {
        public static byte MenuNotas()
    {
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine("|      REGISTRAR ALUMNOS      |");
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine("| 1. Registrar quices         |");
        Console.WriteLine("| 2. Registrar trabajos       |");
        Console.WriteLine("| 3. Registrar parciales      |");
        Console.WriteLine("| 0. Volver al menu principal |");
        Console.WriteLine("+-----------------------------+");
        Console.Write("Seleccione una opción: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static byte MenuInformes()
    {
        Console.WriteLine("+-------------------------------+");
        Console.WriteLine("|      REPORTES E INFORMES      |");
        Console.WriteLine("+-------------------------------+");
        Console.WriteLine("| 1. Notas del grupo            |");
        Console.WriteLine("| 2. Notas Finales              |");
        Console.WriteLine("| 0. Regresar al menu principal |");
        Console.WriteLine("+-------------------------------+");
        Console.Write("Seleccione una opción: ");
        return Convert.ToByte(Console.ReadLine());
    }
    }
}