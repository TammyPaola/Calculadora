using System;
using Calculadora;
namespace DeberApp
{
    class calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas usar la calculadora?");
            var opcion = Console.ReadLine();

            while (opcion != "no")
            {

            Console.WriteLine("Bienvenido a mi calculadora");
            Console.WriteLine("Que operacion quieres realizar");
            var operacion = Console.ReadLine();
            var calculadora = new Matematicas();

                if (operacion == "+")

                {
                    Console.WriteLine("Ingresa un primer numero");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("Ingresa un segundo numero");
                    var num2 = Console.ReadLine();
                    var respuesta = calculadora.Sumar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la suma de los dos numeros es " + respuesta);
                }
                if (operacion == "-")
                {
                    Console.WriteLine("Ingresa un primer numero");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("Ingresa un segundo numero");
                    var num2 = Console.ReadLine();
                    var respuesta = calculadora.Restar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la resta de los dos numeros es " + respuesta);
                }

                if (operacion == "*")
                {
                    Console.WriteLine("Ingresa un primer numero");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("Ingresa un segundo numero");
                    var num2 = Console.ReadLine();
                    var respuesta = calculadora.Multiplicar(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la multiplicacion de los dos numeros es " + respuesta);
                }
                if (operacion == "/")
                {
                    Console.WriteLine("Ingresa un primer numero");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("Ingresa un segundo numero");
                    var num2 = Console.ReadLine();
                    var respuesta = calculadora.Division(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la division de los dos numeros es " + respuesta);
                }
                if (operacion == "potencia")
                {
                    Console.WriteLine("Ingresa un primer numero");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("Ingresa un segundo numero");
                    var num2 = Console.ReadLine();
                    Console.WriteLine("el primer numero se tomara como exponente y el segundo como base");
                    var respuesta = calculadora.Potencia(int.Parse(num1), int.Parse(num2));
                    Console.WriteLine("la potencia es  " + respuesta);
                }
                if (operacion == "inversa")
                {
                    Console.WriteLine("Ingresa un numero");
                    var num1 = Console.ReadLine();
                    var respuesta = calculadora.Inversa(double.Parse(num1));
                    Console.WriteLine("la inversa es " + respuesta);
                }
            if (operacion == "raiz")
            {
                Console.WriteLine("ingrese un numero ");
                var num1 = Console.ReadLine();
                var respuesta = calculadora.Raiz(double.Parse(num1));
                Console.WriteLine("la raiz es " + respuesta);

            }
            
                Console.WriteLine("Deseas volver a usar la calculadora ?");
                 opcion= Console.ReadLine();
            }

        }

        }
    }

