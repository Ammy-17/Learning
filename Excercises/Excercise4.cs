namespace Learning.Excercises
{
    /// <summary>
    /// Ejercicio de invertir una cadena de texto.
    /// </summary>
    public sealed class Excercise4
    {
        public Excercise4()
        {
            Init();
        }

        private void Init()
        {
            string text = "Esto es una cadena de texto.";
            //Bucle for, por interacio en decremento.
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
