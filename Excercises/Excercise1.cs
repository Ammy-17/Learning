namespace Learning.Excercises
{
    /// <summary>
    /// Ejercicio para ingresar dos números, se validan y se pintan.
    /// </summary>
    public sealed class Excercise1
    {
        /// <summary>
        /// Constructor que inicializa un objeto de tipo
        /// <see cref="Excercise1"/>.
        /// Llama al método <see cref="Init"/>.
        /// </summary>
        public Excercise1()
        {
            // Llamando o ejecutando el método Init.
            Init();
        }

        private void Init()
        {
            int a, b; //Creando dos variables de tipo int.
            bool isValid = false; // Creando una variable de tipo bool.

            // Imprimir un mensaje o cadena de texto en la consola.
            Console.WriteLine("Ingresar primer número: ");

            // Obtener y guardar una cadena de texto ingresada
            // por el usuario desde el teclado.
            string? read = Console.ReadLine();

            // TryParse, intenta convertir una cadena de texto a entero
            // retorna true si la conversión fue exitosa en caso
            // contrario false.
            isValid = int.TryParse(read, out a);
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

            // La interpolación de strings permite agregar el valor de una
            // variable a una cadena de texto. $"{variable}".
            Console.WriteLine($"Número 1: {a}. Número 2: {b}");
        }
    }
}
