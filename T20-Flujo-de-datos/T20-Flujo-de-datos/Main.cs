using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 6 \n");
            Ejercicio6();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 7 \n");
            Ejercicio7();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 8 \n");
            Ejercicio8();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 9 \n");
            Ejercicio9();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 10 \n");
            Ejercicio10();
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

        static void Ejercicio6()
        {
            //6) Pedir al usuario el precio de un producto(valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta(inventado)
            Console.WriteLine("Por favor ingrese el precio del producto");
            float precio = float.Parse(Console.ReadLine());
            if (precio > 0)
            {
                Console.WriteLine("\nSi desea pagar con tarjeta pulse 1:");
                Console.WriteLine("Si desea pagar con efectivo pulse 2:");
                int pago = int.Parse(Console.ReadLine());
                if (pago == 1)
                {
                    Console.WriteLine("\nIngrese numero de tarjeta");
                    string numTarjeta = Console.ReadLine();
                    
                }else if (pago == 2)
                {
                    Console.WriteLine("\nPago con efectivo exitoso");
                }else
                {
                    Console.WriteLine("\nMétodo de pago no valido");
                }
            }
            else
            {
                Console.WriteLine("\nHas introducido un valor negativo");
            }
        }

        static void Ejercicio7()
        {
            //7) Recorre los números del 1 al 100.Usa un bucle for.
            int[] listaNumeros = new int[100];

            for (int i = 0; i < 100; i++)
            {
                listaNumeros[i] = i + 1;
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        static void Ejercicio8()
        {
            //8) Recorre los números del 1 al 100.Usa un bucle while.
            int[] listaNumeros = new int[100];

            int i = 0;
            while (i > 100)
            {
                listaNumeros[i] = i + 1;
                i++;
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        static void Ejercicio9()
        {
            //9) Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
            List<int> listaNumerosPares = new List<int>();
            int contador = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    listaNumerosPares.Add(i);
                    contador++;
                }
            }

            Console.WriteLine(string.Join(", ", listaNumerosPares));
        }

        static void Ejercicio10()
        {
            //10) Recorre los números del 1 al 100.Muestra los números pares o divisibles entre 3.
            List<int> listaNumeros = new List<int>();
            int contador = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0 || (i % 3) == 0)
                {
                    listaNumeros.Add(i);
                    contador++;
                }
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }
    }
}
