using System.Runtime.InteropServices;
using Boletin;
using Boletin.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine("|        MENU PRINCIPAL       |");
        Console.WriteLine("+-----------------------------+");
        Console.WriteLine("| 1. Registrar Alumnos        |");
        Console.WriteLine("| 2. Registrar Notas          |");
        Console.WriteLine("| 3. Reportes e informes      |");
        Console.WriteLine("| 0. Salir                    |");
        Console.WriteLine("+-----------------------------+");
        Console.Write("Seleccione una opción: ");
        byte opcionMenu = Convert.ToByte(Console.ReadLine());
        bool cicloMenu = true;
        while (cicloMenu)
        {
            switch (opcionMenu)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    bool cicloNotas = true;
                    while (cicloNotas)
                    {
                        Console.Clear();
                        byte opcionNotas = MisFunciones.MenuNotas();
                        if (opcionNotas != 0)
                        {
                            student.RegistroNota(estudiantes, opcionNotas);
                            MisFunciones.SaveData(estudiantes);
                        }
                        else
                        {
                            cicloNotas = false;
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    bool cicloInformes = true;
                    while (cicloInformes)
                    {
                        Console.Clear();
                        byte opcionInforme = MisFunciones.MenuInformes();
                        switch (opcionInforme)
                        {
                            case 1:
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                break;
                            case 3:
                                cicloInformes = false;
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                Console.Write("Presione Enter para continuar");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 4:
                    cicloMenu = false;
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    Console.Write("Presione Enter para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}