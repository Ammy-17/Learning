namespace Learning.Excercises
{
    /// <summary>
    /// Ejercicio que pinte los valores de un arreglo.
    /// </summary>
    public sealed class Excercise3
    {
        public Excercise3()
        {
            Init();
        }

        private void Init()
        {
            string[] message = { "Hello ", "World!" };
            // Bucle for, por iteración en incremento.
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();

            // Bucle for, por iteración en decremento.
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();

            // Bucle while, por condición.
            int whileIterator = 0;
            while (whileIterator < message.Length)
            {
                Console.Write(message[whileIterator]);
                whileIterator++;
            }
            Console.WriteLine();

            // Bucle do while, similar al bucle while pero, no hace una primera
            // validación de la condición
            bool value = false;
            do
            {
                Console.WriteLine("No importa que esté false, no valida la condición.");
            } while (value);
        }
    }
}
