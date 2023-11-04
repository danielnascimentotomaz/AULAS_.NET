using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _009_OPERADORES_ARITMETICOS.Models
{
    public class Calculadora
    {
        public void Soma(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");

        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");

        }

         public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");

        }

         public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");

        }

        public void Potencia(int x, int y){

           double  valor = Math.Pow(x,y);

           Console.WriteLine($"{x} ^ {y} = {valor}");
        }
        
        public void Seno(double angulo){
            double radiano = angulo * (Math.PI /180);
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno do {angulo}° = {Math.Round(seno,2)}");

        }

         public void coseno(double angulo){
            double radiano = angulo * (Math.PI /180);
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Seno do {angulo}° = {Math.Round(coseno,2)}");

        }


        public void tangente(double angulo){
            double radiano = angulo * (angulo);
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"Seno do {angulo}° = {Math.Round(  tangente,2)}");

        }

        public void raizQuadrada(double x){

            double valor = Math.Sqrt(x);

            Console.WriteLine($"RAIZ QUADRADA DE {x} = {valor}");



        }
        
        

    }
}