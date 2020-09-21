using System;

namespace p03areatriangulo
{
    class Program
    {
        // Programa que calcula el área de un triangulo
        // Julio ARTURO Renteria CABRERA
        
        static void Main(string[] args)
        {
            float labase, laaltura;
            float area;

            
            Console.WriteLine("Ingresa la base del triangulo: "); labase = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del triangulo: "); laaltura = float.Parse(Console.ReadLine());

            area = labase * laaltura / 2;

            Console.WriteLine($"Un triangulo de base {labase} y altura {laaltura} tiene una area del triangulo: {area} ");

        }
    }
}
