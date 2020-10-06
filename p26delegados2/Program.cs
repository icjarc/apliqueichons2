using System;

namespace p26delegados2
{
    //Declarar un delegado
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran tres delegados
            MiDelegado d1, d2, d3;
            MiDelegado d;    //Se declara el delegado multicast
            Console.Clear();

            //Asocia d1 a Mensaje1 y d2 a Mensaje2
            d1 = Mensajes.Mensaje1;
            d2 = Mensajes.Mensaje2;

            d = d1 + d2;   //Combina delegado d1 y delegado d2
            d("El Peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo, que no pare la fiesta");
            d += d3;   //Agrega el delegado d3
            d("El Borolas");
            Console.WriteLine();

            d -= d2;    //Quita el delegado d2
            d("Peña");
            Console.WriteLine();

            d -= d1;    //Quita el delegado d1
            d("Tello");
            Console.WriteLine();
        }
    }
}
//Ejemplo2_Delegados_RenteriaCabrera_JulioArturo