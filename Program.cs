using System;

namespace ejercicioMetodos
{
    class Program
    {
        static void segundoMensaje()
        {
            Console.WriteLine("Saludos desde el método segundoMensaje");
        }
        static void Main(string[] args)
        {
            segundoMensaje();
            Console.WriteLine("Introduce el primer numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine("El resultado de la suma es " + SumaNumeros(num1, num2));
            Console.WriteLine("El resultado de la resta es " + RestaNumeros(num1, num2));
            Console.WriteLine("El resultado de la multiplicación es " + MultiplicaNumeros(num1, num2));
            Console.WriteLine("El resultado de la división es " + DivideNumeros(num1, num2));
            //Console.WriteLine("La suma  de los numeros es " + SumaNumeros(7,9));
        }
        static void mensajeEnpantalla()
        {
            Console.WriteLine("Saludos desde el método mensajeEnpantalla en el cual solo esta escrita esta linea");
        }
        static double SumaNumeros(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }
        static double RestaNumeros(double num1, double num2)
        {
            double resultado = num1 - num2;
            return resultado;
        }
        static double MultiplicaNumeros(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
        static double DivideNumeros(double num1, double num2)
        {
            double resultado = num1 / num2;
            return resultado;
        }
    }
}
