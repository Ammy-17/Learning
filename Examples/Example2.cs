namespace Learning.Examples
{
    public class Specie
    {
        private string TipoRespiracion { get; set; } = string.Empty;

        public Specie(string tipoRespiracion)
        {
            TipoRespiracion = tipoRespiracion;
        }

        public void Comer(string alimento)
        {
            Console.WriteLine($"Comiendo {alimento}...");
        }
    }

    public class Terrestre : Specie
    {
        private string TipoCaminado { get; set; } = string.Empty;

        public Terrestre(string tipoCaminado, string tipoRespiracion) : base(tipoRespiracion)
        {
            TipoCaminado = tipoCaminado;
        }

        public void Moverse()
        {
            Console.WriteLine($"Moviendose usnado {TipoCaminado}");
        }
    }

    public class Acuatico : Specie
    {
        private string TipoNado { get; set; } = string.Empty;

        public Acuatico(string tipoNado, string tipoRespiracion) : base(tipoRespiracion)
        {
            TipoNado = tipoNado;
        }

        public void Nadar()
        {
            Console.WriteLine($"Nadando usando {TipoNado}");
        }
    }

    public class TerrestreConRaza : Terrestre
    {
        private string Raza { get; set; } = string.Empty;

        public TerrestreConRaza(string raza, string tipoCaminado, string tipoRespiracion) : base(tipoCaminado, tipoRespiracion)
        {
            Raza = raza;
        }

        public void ImprimirRaza()
        {
            Console.WriteLine(Raza);
        }
    }

    public class Perro : TerrestreConRaza
    {

        public Perro(string raza, string tipoCaminado, string tipoRespiracion) : base(raza, tipoCaminado, tipoRespiracion)
        {
        }

        public void Ladrar()
        {
            Console.WriteLine("Guau guau");
        }
    }

    public class Gato : TerrestreConRaza
    {
        public Gato(string raza, string tipoCaminado, string tipoRespiracion) : base(raza, tipoCaminado, tipoRespiracion)
        {
        }

        public void Maullar()
        {
            Console.WriteLine("Miau miau");
        }
    }

    public class Any
    {
        public Any()
        {
        }
    }
}
