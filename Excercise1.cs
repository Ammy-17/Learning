namespace Learning
{
    /// <summary>
    /// Ejercicio para ingresar dos números, se validan y se pintan.
    /// </summary>
    public sealed class Excercise1
    {
        public Excercise1()
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

            Console.WriteLine($"Número 1: {a}. Número 2: {b}");
        }
    }
}
