using System.Numerics;

namespace Learning.Excercises
{
    /// <summary>
    /// Ejercicio que realiza una suma, resta, división o multiplición
    /// de dos números.
    /// </summary>
    public sealed class Excercise2
    {
        public Excercise2()
        {
            Init();
        }

        private void Init()
        {
            int a, b;
            bool isValid = false;

            Console.WriteLine("Ingresar primer número: ");
            isValid = int.TryParse(Console.ReadLine(), out a);
            if (isValid == false)
            {
                Console.WriteLine("Error, no es un número.");
                return;
            }

            Console.WriteLine("Ingrese segundo número");
            isValid = int.TryParse(Console.ReadLine(), out b);
            if (isValid == false)
            {
                Console.WriteLine("Error, no es un número.");
                return;
            }

            Console.WriteLine("Ingrese la operación (+, -, *, /)");
            string? operation = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(operation))
            {
                Console.WriteLine("No ingresó una operación.");
                return;
            }

            if (operation == "+")
            {
                Console.WriteLine($"Suma: {a + b}");
                return;
            }
            if (operation == "-")
            {
                Console.WriteLine($"Resta: {a - b}");
                return;
            }
            if (operation == "*")
            {
                Console.WriteLine($"Multiplicación: {a * b}");
                return;
            }
            if (operation == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("No se puede dividir por 0");
                    return;
                }
                Console.WriteLine($"División: {a / b}");
                return;
            }
        }
    }
}

