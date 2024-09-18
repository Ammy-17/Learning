namespace Learning.Excercises
{
    class Excercise5
    {
        public Excercise5()
        {
            Init();
        }

        private void Init()
        {
            Console.WriteLine("Ingrese la operación a realizar (+, -, *, /): ");
            string? operation = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(operation))
            {
                Console.WriteLine("Operación no válida");
                return;
            }
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Operación no válida");
                return;
            }
            bool isInProcess = true;
            bool isFirstNumber = true;
            int total = 0;
            while (isInProcess)
            {
                Console.WriteLine("Ingresar número:");
                if (isFirstNumber == true)
                {
                    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
                    if (isNumber == false)
                    {
                        Console.WriteLine("Número no válido");
                        isInProcess = false;
                        continue;
                    }
                    total = number;
                    isFirstNumber = false;
                    continue;
                }
                bool isNumber2 = int.TryParse(Console.ReadLine(), out int number2);
                if (isNumber2 == false)
                {
                    Console.WriteLine("Número no válido");
                    isInProcess = false;
                }
                if (operation == "+")
                {
                    total += number2;
                }
                else if (operation == "-")
                {
                    total -= number2;
                }
                else if (operation == "/")
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0");
                        isInProcess = false;
                        continue;
                    }
                    total /= number2;
                }
                else
                {
                    total *= number2;
                }

                Console.WriteLine("Desea seguir ingresando números (s, n):");
                string? response = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(response) || response == "n")
                {
                    isInProcess = false;
                    continue;
                }
            }

            Console.WriteLine($"El resultado de la operación es: {total}");
        }
    }
}