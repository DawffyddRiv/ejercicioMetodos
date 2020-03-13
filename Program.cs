using System;

namespace ejercicioMetodos
{
    class Program
    {
        static void segundoMensaje()
        {
            Console.WriteLine("Texto del método segundoMensaje");
        }
        static void Main(string[] args)
        {
            //Se tiene que tomar en cuenta que el método main es el método de entrada y por el cual entran los demás
            mensajeEnpantalla();
            Console.WriteLine("Hola mundo,vamos a realizar un pequeño ejercicio de métodos!");
            Console.WriteLine("Mensaje desde el metodo Main");
            mensajeEnpantalla();
            segundoMensaje();//instanciando el método segundoMensaje
            sumaNumeros(4,8);//Al instanciarla es obligatorio introducir los parámetros y del tipo que pida el método
        }
        static void mensajeEnpantalla()
        {
            Console.WriteLine("Esto es una linea para un mensaje en pantalla del metodo mensajeEnpantalla");
        }
        static void sumaNumeros(int num1, int num2)
        {

            //Console.WriteLine("La suma de los numeros" + num1+num2); esta linea solo muestra los parametros (numeros introducidos) uno junto del otro
            Console.WriteLine($"La suma de los números es: {num1+num2}");
            Console.WriteLine("Tambien se puede sumar así:" + (num1+num2));
        }
    }
}
