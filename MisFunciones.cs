using Boletin.Entities;
using Ejercicio3.Entities;
using Newtonsoft.Json;

namespace Boletin.Entities;

public class MisFunciones
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
    public static void SaveData(List<Estudiantes> lstListado)
    {
        string json = Convert.SerializeObject(lstListado, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
    }
    public static List<Estudiantes> LoadData()
    {
        using (StreamReader reader = new StreamReader("boletin.json"))
        {
            string json = reader.ReadToEnd();
            return System.Text.Json.JsonSerializer
            .Deserialize<List<Estudiantes>>(json, new System.Text.Json.JsonSerializerOptions()
            { PropertyNameCaseInsensitive = true }) ?? new List<Estudiantes>();
        }
    }

}
