using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Boletin.Entities
{
    public class Estudiantes : Boletin
    {
        private string codigo;
        private string nombre;
        private string direccion;
        private byte edad;



        public Estudiantes() : base()
        {
        }

        public Estudiantes(List<float> quices, List<float> trabajos, List<float> parciales, string code, string nombre, string direccion, byte edad) : base(trabajos, quices, parciales)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Trabajos = trabajos;
            this.Quices = quices;
            this.Parciales = parciales;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public byte Edad { get => edad; set => edad = value; }
        public void RegistroEstudiantes(List<Estudiantes> estudiantes)
        {
            Estudiantes estudiante = new Estudiantes();
            Console.Write("Ingrese el Codigo del estudiante: ");
            estudiante.Codigo = Console.ReadLine();
            Console.Write("Ingrese el Nombre del estudiante: ");
            estudiante.Nombre = Console.ReadLine();
            Console.Write("Ingrese la Dirección del estudiante: ");
            estudiante.Direccion = Console.ReadLine();
            Console.Write("Ingrese la Edad del estudiante: ");
            estudiante.Edad = Convert.ToByte(Console.ReadLine());
            estudiante.Trabajos = new List<float>();
            estudiante.Quices = new List<float>();
            estudiante.Parciales = new List<float>();
            estudiantes.Add(estudiante);
        }
        public void RegistroNotas(List<Estudiantes> estudiantes, int opcion)
        {
            Console.WriteLine("Ingrese el Codigo del estudiante: ");
            string CodigoStudent = Console.ReadLine();
            Estudiantes alumno = estudiantes.FirstOrDefault(A => A.Codigo.Equals(CodigoStudent));
            Console.WriteLine("Por favor ingrese la nota del ");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Trabajo Nro: {0}", (alumno.Trabajos.Count + 1));
                    alumno.Trabajos.Add(float.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Quiz Nro: {0}", (alumno.Quices.Count + 1));
                    alumno.Quices.Add(float.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Parcial Nro: {0}", (alumno.Parciales.Count + 1));
                    alumno.Parciales.Add(float.Parse(Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
    }
}