using System;
using System.Collections.Generic;
using System.Text;
using calculadoraDePromedios.Dominio;

namespace calculadoraDePromedios.Logica
{
    class clsLogica {

        public double Periodo1(Double lab1, Double parcial1)
        {

            double result = (lab1 * 0.40) + (parcial1 * 0.60);
            return result;
        }

        public double Periodo2(double lab2, double parcial2)
        {
            double result = (lab2 * 0.40) + (parcial2 * 0.60);
            return result;
        }
        public double Periodo3(double lab3, double parcial3)
        {

            double result = (lab3 * 0.40) + (parcial3 * 0.60);
            return result;
        }

        public double ResultadoFinal(double resultado1, double resultado2, double resultado3)
        {
            double result = resultado1 + resultado2 + resultado3;

            double Promedio = result / 3;
            return Promedio;
        }

        
}


}
