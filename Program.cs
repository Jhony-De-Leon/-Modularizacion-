using System; 
using System.Threading; 

class Program 
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Bienvenidos - Modularización - Jhony");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione una opción : ");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1. Calculadora Básica");
            Console.WriteLine("2. Validacion de Contraseña");
            Console.WriteLine("3. Números Primos");
            Console.WriteLine("4. Números Pares");
            Console.WriteLine("5. Conversión de Temperatura");
            Console.WriteLine("6. Contador de Vocales");
            Console.WriteLine("7. Cálculo de Factoriales");
            Console.WriteLine("8. Juego de Adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("11. Salir");
            Console.WriteLine("---------------------------");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalculadoraBasica();
                    break;
                case 2:
                    ValidacionContrasena();
                    break;
                case 3:
                    NumerosPrimos();
                    break;
                case 4:
                    NumerosPares();
                    break;
                case 5:
                    ConversionTemperatura();
                    break;
                case 6:
                    ContadorVocales();
                    break;
                case 7:
                    CalculoFactoriales();
                    break;
                case 8:
                    JuegoAdivinanza();
                    break;
                case 9:
                    PasoPorReferencia();
                    break;
                case 10:
                    TablaMultiplicar();
                    break;
                case 11:
                    Console.WriteLine("Saliendo... Bye....");
                    break;
                default:
                    Console.WriteLine("Opción no válida, porfavor intente de nuevo.");
                    break;
            }

            if (opcion != 11)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 11);
    }

    static void CalculadoraBasica()
    {
        Console.Clear();
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("------------------");

        double num1, num2;
        string input;

        Console.Write("Ingrese el primer número: ");
        input = Console.ReadLine();
        while (!double.TryParse(input, out num1))
        {
            Console.Write("Entrada inválida. Ingrese un número válido: ");
            input = Console.ReadLine();
        }

        Console.Write("Ingrese el segundo número: ");
        input = Console.ReadLine();
        while (!double.TryParse(input, out num2))
        {
            Console.Write("Entrada inválida. Ingrese un número válido: ");
            input = Console.ReadLine();
        }

        Console.WriteLine("Seleccione la operación a realizar:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Opción: ");
        int operacion = int.Parse(Console.ReadLine());

        double resultado = 0;
        bool operacionValida = true;

        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                operacionValida = false;
                break;
        }

        if (operacionValida)
        {
            Console.WriteLine("El resultado de la operación es: " + resultado);
        }

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static void ValidacionContrasena()
    {
        const string contrasenaCorrecta = "jhonyx2025";
        string contrasenaIngresada;

        do
        {
            Console.Clear();
            Console.Write("Ingrese la contraseña: ");
            contrasenaIngresada = Console.ReadLine();

            if (contrasenaIngresada != contrasenaCorrecta)
            {
                Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
                Thread.Sleep(2000);
            }

        } while (contrasenaIngresada != contrasenaCorrecta);

        Console.WriteLine("Acceso concedido.");
        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static void NumerosPrimos()
    {
        Console.Clear();
        Console.WriteLine("Verificación de Números Primos");
        Console.WriteLine("------------------------------");

        Console.Write("Ingrese un número entero: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Ingrese un número entero válido: ");
        }

        if (EsPrimo(numero))
        {
            Console.WriteLine($"El número {numero} es primo.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es primo.");
        }

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(numero); i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }

    static void NumerosPares()
    {
        Console.Clear();
        Console.WriteLine("Suma de Números Pares");
        Console.WriteLine("---------------------");

        int numero;
        int sumaPares = 0;

        do
        {
            Console.Write("Ingrese un número entero (0 para terminar): ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Ingrese un número entero válido: ");
            }

            if (numero % 2 == 0)
            {
                sumaPares += numero;
            }

        } while (numero != 0);

        Console.WriteLine($"La suma de todos los números pares ingresados es: {sumaPares}");
        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static void ConversionTemperatura()
    {
        Console.Clear();
        Console.WriteLine("Conversión de Temperatura");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Seleccione la conversión a realizar:");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        double temperatura;
        string input;

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese la temperatura en grados Celsius: ");
                input = Console.ReadLine();
                while (!double.TryParse(input, out temperatura))
                {
                    Console.Write("Entrada inválida. Ingrese un número válido: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine($"La temperatura en Fahrenheit es: {CelsiusAFahrenheit(temperatura)}");
                break;
            case 2:
                Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                input = Console.ReadLine();
                while (!double.TryParse(input, out temperatura))
                {
                    Console.Write("Entrada inválida. Ingrese un número válido: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine($"La temperatura en Celsius es: {FahrenheitACelsius(temperatura)}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void ContadorVocales()
    {
        Console.Clear();
        Console.WriteLine("Contador de Vocales");
        Console.WriteLine("-------------------");

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        int numeroVocales = ContarVocales(frase);

        Console.WriteLine($"La frase ingresada contiene {numeroVocales} vocales.");
        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";

        foreach (char c in texto)
        {
            if (vocales.Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }

    static void CalculoFactoriales()
    {
        Console.Clear();
        Console.WriteLine("Cálculo de Factoriales");
        Console.WriteLine("----------------------");

        Console.Write("Ingrese un número entero: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.Write("Entrada inválida. Ingrese un número entero no negativo: ");
        }

        long factorial = CalcularFactorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static long CalcularFactorial(int numero)
    {
        long resultado = 1;
        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    static void JuegoAdivinanza()
    {
        Console.Clear();
        Console.WriteLine("Juego de Adivinanza");
        Console.WriteLine("-------------------");

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento;

        do
        {
            Console.Write("Adivina el número (entre 1 y 100): ");
            while (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }

            if (intento < numeroSecreto)
            {
                Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
            }
            else if (intento > numeroSecreto)
            {
                Console.WriteLine("Demasiado alto. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine("¡Felicidades! Adivinaste el número.");
            }

        } while (intento != numeroSecreto);

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static void PasoPorReferencia()
    {
        Console.Clear();
        Console.WriteLine("Intercambio de Números por Referencia");
        Console.WriteLine("-------------------------------------");

        double num1, num2;
        string input;

        Console.Write("Ingrese el primer número: ");
        input = Console.ReadLine();
        while (!double.TryParse(input, out num1))
        {
            Console.Write("Entrada inválida. Ingrese un número válido: ");
            input = Console.ReadLine();
        }

        Console.Write("Ingrese el segundo número: ");
        input = Console.ReadLine();
        while (!double.TryParse(input, out num2))
        {
            Console.Write("Entrada inválida. Ingrese un número válido: ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

        IntercambiarNumeros(ref num1, ref num2);

        Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static void IntercambiarNumeros(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    static void TablaMultiplicar()
    {
        Console.Clear();
        Console.WriteLine("Tabla de Multiplicar");
        Console.WriteLine("--------------------");

        int numero;
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada inválida. Ingrese un número entero válido: ");
        }

        int[] resultados = GenerarTablaMultiplicar(numero);
        MostrarTablaMultiplicar(numero, resultados);

        Console.WriteLine("Presione cualquier tecla para regresar al menú...");
        Console.ReadKey();
    }

    static int[] GenerarTablaMultiplicar(int numero)
    {
        int[] resultados = new int[10];
        for (int i = 0; i < 10; i++)
        {
            resultados[i] = numero * (i + 1);
        }
        return resultados;
    }

    static void MostrarTablaMultiplicar(int numero, int[] resultados)
    {
        for (int i = 0; i < resultados.Length; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {resultados[i]}");
        }
    }
}

