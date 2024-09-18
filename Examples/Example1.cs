using System.Security.Cryptography.X509Certificates;

namespace Learning.Examples
{
    /// <summary>
    /// Explicación de la sobrecarga de métodos.
    /// </summary>
    public sealed class Example1
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(int number)
        {
            Console.WriteLine(number);
        }

        public void Print(string text, int number)
        {
            Console.Write($"{text} {number}");
        }

        public void Print(int number, string text)
        {
            Console.WriteLine($"{text} {number}");
        }
    }
}
