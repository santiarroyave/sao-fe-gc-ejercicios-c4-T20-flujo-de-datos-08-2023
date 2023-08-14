using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
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

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 11 \n");
            Ejercicio11();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 12 \n");
            Ejercicio12();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 13 \n");
            Ejercicio13();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 14 \n");
            Ejercicio14();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 15 \n");
            Ejercicio15();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 16 \n");
            Ejercicio16();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 17 \n");
            Ejercicio17();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 18 \n");
            Ejercicio18();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 19 \n");
            Ejercicio19();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 20 \n");
            Ejercicio20();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 21 \n");
            Ejercicio21();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 22 \n");
            Ejercicio22();
            Console.WriteLine("---------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Ejercicio 23 \n");
            Ejercicio23();
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
            Console.WriteLine("Por favor ingrese el día de la semana");
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
            while (i < 100)
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

        static void Ejercicio11() 
        {
            //11) Declara 2 variables numéricas(con el valor que desees), e indica cual es mayor de los dos. Si son iguales indicarlo también. Ve cambiando los valores para comprobar que funciona.
            int[] a = { 10, 34, 124, 66, 634 };
            int[] b = { 30, 456, 23, 66, 432 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Valor 1 = {0}", a[i]);
                Console.WriteLine("Valor 2 = {0}", b[i]);

                if (a[i] > b[i])
                {
                    Console.WriteLine("- El numero más grande es: {0}.", a[i]);
                }else if (a[i] < b[i])
                {
                    Console.WriteLine("- El numero más grande es: {0}.", b[i]);
                }
                else
                {
                    Console.WriteLine("- Los dos números son iguales.");
                }
                Console.WriteLine("---------------");
            }
        }

        static void Ejercicio12()
        {
            //12) Declara un String que contenga tu nombre, después muestra un mensaje de bienvenida por consola. Por ejemplo: si introduzco “Fernando”, me aparezca “Bienvenido Fernando”.
            string nombre = "Fernando";

            Console.WriteLine("\nBienvenido {0}", nombre);
        }

        static void Ejercicio13()
        {
            //13) Modifica la aplicación anterior, para que nos pida el nombre que queremos introducir.
            Console.WriteLine("Por favor ingresa tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nBienvenido {0}", nombre);
        }

        static void Ejercicio14()
        {
            //14) Haz una aplicación que calcule el área de un circulo(pi* R2). El radio se pedirá por teclado (recuerda pasar de String a double). Usa la constante PI y el método pow de Math.
            Console.WriteLine("¿Cuánto mide el radio del circulo?");
            double radio = double.Parse(Console.ReadLine());

            double area = (Math.PI * Math.Pow(radio, 2));

            Console.WriteLine("\nEl area del circulo es: {0}", area);
        }
        
        static void Ejercicio15()
        {
            //15) Lee un número por teclado e indica si es divisible entre 2 (resto = 0). Si no lo es, también debemos indicarlo.
            Console.WriteLine("Por favor ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("\nEl numero es divisible entre 2");
            }
            else
            {
                Console.WriteLine("\nEl numero no se puede dividir entre 2");
            }
        }

        static void Ejercicio16()
        {
            //16) Lee un número por teclado que pida el precio de un producto (puede tener decimales) y calcule el precio final con IVA. El IVA será una constante que será del 21 %
            const double iva = 21d / 100d;
            Console.WriteLine("Por favor ingrese el precio de un producto");
            double precio = double.Parse(Console.ReadLine());

            double precioFinal = precio - (precio * iva);
            Console.WriteLine("\n El precio final es de {0} euros",precioFinal);
        }

        static void Ejercicio17()
        {
            //17) Muestra los números del 1 al 100 (ambos incluidos). Usa un bucle while.
            int[] listaNumeros = new int[100];

            int i = 0;
            while (i < 100)
            {
                listaNumeros[i] = i + 1;
                i++;
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        static void Ejercicio18()
        {
            //18) Haz el mismo ejercicio anterior con un bucle for.
            int[] listaNumeros = new int[100];

            for (int i = 0; i < 100; i++)
            {
                listaNumeros[i] = i + 1;
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        static void Ejercicio19()
        {
            //19) Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 3. Utiliza el bucle que desees.
            List<int> listaNumeros = new List<int>();
            int contador = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0 && (i % 3) == 0)
                {
                    listaNumeros.Add(i);
                    contador++;
                }
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        static void Ejercicio20()
        {
            //20) Realiza una aplicación que nos pida un número de ventas a introducir, después nos pedirá tantas ventas por teclado como número de ventas se hayan indicado. Al final mostrara la suma de todas las ventas. Piensa que es lo que se repite y lo que no.
            Console.WriteLine("Por favor introduce un numero de ventas");
            int numVentas = int.Parse(Console.ReadLine());
            List<int> ventas = new List<int>();

            //Obtiene los numeros de ventas
            for (int i = 0; i < numVentas; i++)
            {
                Console.WriteLine("Introduzca la venta nº {0}", i+1);
                ventas.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nValores introducidos: {0}", string.Join(", ", ventas));

            //Suma los numeros de ventas
            int sumaVentas = 0;
            foreach (var venta in ventas)
            {
                sumaVentas += venta;
            }
            Console.WriteLine("La suma total es de: {0}", sumaVentas);
        }

        static void Ejercicio21()
        {
            //21) Crea una aplicación que nos pida un día de la semana y que nos diga si es un día laboral o no. Usa un switch para ello.
            Console.WriteLine("Por favor escriba un dia de la semana");
            string nombreDia = Console.ReadLine().ToLower();

            switch (nombreDia)
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("\nEs un dia laboral.");
                    break;
                case "sábado":
                case "sabado":
                case "domingo":
                    Console.WriteLine("\nNo es un dia laboral.");
                    break;

                default:
                    Console.WriteLine("\nNo has ingredaso un nombre válido.");
                    break;
            }
        }

        static void Ejercicio22()
        {
            //22) Escribe una aplicación con un String que contenga una contraseña cualquiera. Después se te pedirá que introduzcas la contraseña, con 3 intentos. Cuando aciertes ya no pedirá mas la contraseña y mostrara un mensaje diciendo “Enhorabuena”. Piensa bien en la condición de salida (3 intentos y si acierta sale, aunque le queden intentos).
            Console.WriteLine("Por favor introduzca su contraseña");
            string password = "";
            Boolean passwordOk = false;

            // Pide la contraseña con 3 intentos
            for (int i = 0 ; i < 3; i++)
            {
                password = Console.ReadLine();

                if (password == "hola")
                {
                    Console.WriteLine("\nEnhorabuena");
                    passwordOk = true;
                    break;
                }else if (i < 2)
                {
                    Console.WriteLine("\nTienes otro intento");
                }
            }

            // Mete en bucle infinito si se te agotan los intentos
            while (passwordOk == false)
            {
                Console.WriteLine("\nYa no tienes más intentos");
                Console.ReadLine();
            }

            Console.WriteLine("Has salido del bucle");
        }

        static void Ejercicio23()
        {
            //23) Crea una aplicación llamada CalculadoraInversa, nos pedirá 2 operandos(int) y un signo aritmético(String), según este último se realizara la operación correspondiente. Al final mostrara el resultado en un cuadro de dialogo.
            //Los signos aritméticos disponibles son:
            //    +: suma los dos operandos.
            //    -: resta los operandos.
            //    *: multiplica los operandos.
            //    /: divide los operandos, este debe dar un resultado con decimales(double)
            //    ^: 1º operando como base y 2º como exponente.
            //    %: módulo, resto de la división entre operando1 y operando2.

            Console.WriteLine("Por favor introduzca un numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor introduzca otro numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAhora introduzca un operador aritmético");
            Console.WriteLine("+: suma los dos operandos.");
            Console.WriteLine("-: resta los operandos.");
            Console.WriteLine("*: multiplica los operandos.");
            Console.WriteLine("/: divide los operandos, este debe dar un resultado con decimales(double)");
            Console.WriteLine("^: 1º operando como base y 2º como exponente.");
            Console.WriteLine("%: módulo, resto de la división entre operando1 y operando2.");
            string operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (num1 / num2));
                    break;
                case "^":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (Math.Pow(num1, num2)));
                    break;
                case "%":
                    Console.WriteLine("\n{0} {1} {2} = {3}", num1, operador, num2, (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Operador no válido");
                    break;
            }
        }

    }
}
