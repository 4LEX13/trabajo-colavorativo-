using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraDePromedios.Dominio
{
    class clsPrincipal
    {
         private String lab1, lab2, lab3;
        private String parcial1, parcial2, parcial3;
        private double resultado1, resultado2, resultado3;
        private double resultadoFinal;
        public string Lab1 { get => lab1; set => lab1 = value; }
        public string Lab2 { get => lab2; set => lab2 = value; }
        public string Lab3 { get => lab3; set => lab3 = value; }
        public string Parcial1 { get => parcial1; set => parcial1 = value; }
        public string Parcial2 { get => parcial2; set => parcial2 = value; }
        public string Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Resultado1 { get => resultado1; set => resultado1 = value; }
        public double Resultado2 { get => resultado2; set => resultado2 = value; }
        public double Resultado3 { get => resultado3; set => resultado3 = value; }
        public double ResultadoFinal { get => resultadoFinal; set => resultadoFinal = value; }
    }
}
