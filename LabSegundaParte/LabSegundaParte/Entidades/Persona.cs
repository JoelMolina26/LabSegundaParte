using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Entidades
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
    }
}
