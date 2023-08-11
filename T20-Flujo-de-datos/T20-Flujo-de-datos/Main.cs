using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace T20_Flujo_de_datos
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 1\n");
            Ejercicio1();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 2\n");
            Ejercicio2();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 3 \n");
            Ejercicio3();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 4 \n");
            Ejercicio4();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 5 \n");
            Ejercicio5();
            Console.WriteLine("---------------------------");
            Console.ReadLine();



        }

        static void Ejercicio1()
        {
            //1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores.Mostrar por consola
            int a = 2;
            int b = 3;
            int c = 4;

            int suma = a + b + c;
            Console.WriteLine("Valor A: = {0}", a);
            Console.WriteLine("Valor B: = {0}", b);
            Console.WriteLine("Valor C: = {0}", c);

            Console.WriteLine("\nSuma A + B + C = {0}", suma);
        }

        static void Ejercicio2()
        {
            //2) Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje “Hola ” < nombre > ” bienvenido a ” < ciudad >
            string nombrePresona;
            string nombreCiudad;
            Console.WriteLine("Por favor ingrese un nombre de persona:");
            nombrePresona = Console.ReadLine();
            Console.WriteLine("Por favor ingrese un nombre de una ciudad:");
            nombreCiudad = Console.ReadLine();

            Console.WriteLine("\nHola {0} bienvenido a {1}", nombrePresona, nombreCiudad);
        }

        static void Ejercicio3()
        {
            //3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te llamas ” < nombre > ” y tienes ” < años > ” años”.
            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tienes?");
            string edad = Console.ReadLine();

            Console.WriteLine("\nTe llamas {0} y tienes {1} años", nombre, edad);
        }

        static void Ejercicio4()
        {
            //4) Pedir dos números al usuario por teclado y decir que número es el mayor.
            try
            {
                Console.WriteLine("Por favor, inserte un número");
                int valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, inserte otro número");
                int valor2 = int.Parse(Console.ReadLine());

                if(valor1 > valor2)
                {
                    Console.WriteLine("\nEl número {0} es mayor que {1}", valor1, valor2);
                }
                else
                {
                    Console.WriteLine("\nEl número {0} es mayor que {1}", valor2, valor1);
                }
            }
            catch
            {
                Console.WriteLine("\nNo has introducido valores validos");
            }
        }

        static void Ejercicio5()
        {
            //5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.En caso de error, indicarlo.
            Console.WriteLine("Por favor ingrese el nombre de la semana");
            string nombreDia = Console.ReadLine().ToLower();

            switch (nombreDia)
            {
                case "lunes":
                case "martes":
                case "miércoles": case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("\nNo es fin de semana.");
                    break;
                case "sábado": case "sabado":
                case "domingo":
                    Console.WriteLine("\nEs fin de semana.");
                    break;
                
                default:
                    Console.WriteLine("\nNo has ingredaso un nombre válido.");
                    break;
            }
        }
    }
}
