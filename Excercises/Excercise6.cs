namespace Learning.Excercises
{
    //<summary>
    //Ejercicio validar una palabra palíndroma.
    //</summary>s
    public sealed class Excercise6
    {
        public Excercise6()
        {
            Init();
        }

        private void Init()
        {
            Console.WriteLine("Ingresar palabra a validar:");
            string? text = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("No ingreso una palabra.");
                return;
            }
            string text2 = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                text2 = $"{text2}{text[i]}";
            }

            // Equals compara dos cadenas de texto y podemos agregar un
            // indicador de comparación.
            if (text.Equals(text2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Es una palabra palíndroma.");
                return;
            }
            else
            {
                Console.WriteLine("No es una palabra palíndroma.");
                return;
            }
        }
    }
}
