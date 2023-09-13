using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Entities
{
    public class Estudiantes
    {
        private string code;
        private string nombre;
        private string direccion;
        private byte edad;

        public Estudiantes()
        {
        }

        public byte Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Code { get => code; set => code = value; }
    }
}