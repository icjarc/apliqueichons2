using System;

namespace p24Interfaz2
{
    public class Organismo{
        public void Respiracion() => Console.WriteLine("Respiracion");
        public void Movimiento() => Console.WriteLine("Movimiento");
        public void Crecimiento() => Console.WriteLine("Crecimiento");
    }

    public interface IAnimales{
        void MultiCelular();
        void SangreCaliente();
    }

    public interface ICanino : IAnimales{
        void Correr();
        void CuatroPatas();
    }

    public interface IPajaro : IAnimales{
        void Volar();
        void DosPatas();
    }

     public class Perro : Organismo, ICanino{
        public void MultiCelular() => Console.WriteLine("Multicelular perro");
        public void SangreCaliente() => Console.WriteLine("Sangre Caliente perro");
        public void Correr() => Console.WriteLine("Correr perro");
        public void CuatroPatas() => Console.WriteLine("Cuatro Patas perro");
    }

     public class Perico : Organismo, IPajaro{
        public void MultiCelular() => Console.WriteLine("Multicelular perico");
        public void SangreCaliente() => Console.WriteLine("Sangre Caliente perico");
        public void Volar() => Console.WriteLine("Volar perico");
        public void DosPatas() => Console.WriteLine("Dos Patas perico");
    }
    
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("\nSegundo ejemplo de uso de interfaces:\n");

            Perro miperro = new Perro();
            Console.WriteLine("\nCaracteristicas del Perro:\n");
            miperro.Respiracion();
            miperro.Movimiento();
            miperro.Crecimiento();
            miperro.MultiCelular();
            miperro.SangreCaliente();
            miperro.Correr();
            miperro.CuatroPatas();

            Perico miperico = new Perico();
            Console.WriteLine("\nCaracteristicas del Perico:\n");
            miperico.Respiracion();
            miperico.Movimiento();
            miperico.Crecimiento();
            miperico.MultiCelular();
            miperico.SangreCaliente();
            miperico.Volar();
            miperico.DosPatas();
        }
    }
}
