using System;
using System.Collections.Generic;
using System.Linq;

namespace p22linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> Estudiantes = new List<Estudiante>() {

                new Estudiante {Matricula=111, Nombre="Juan Perez", Domicilio= "Principal 123, Zacatecas",
                Califs=new List<float> {97,92,81,60} },
                new Estudiante {Matricula=222, Nombre="Maria Lopez", Domicilio= "Principal 126, Fresnillo",
                Califs=new List<float> {75,84,91,39} },
                new Estudiante {Matricula=333, Nombre="Rodrigo Mata", Domicilio= "Luis Moya 31, Rio Grande",
                Califs=new List<float> {88,94,65,91} },
                new Estudiante {Matricula=444, Nombre="Miguel Mejia", Domicilio= "Juan de Tolosa 22, Zacatecas",
                Califs=new List<float> {70,90,60,40} }
             }; 

                Estudiantes.Add(
                new Estudiante {Matricula=555, 
                Nombre="Martin Morales", Domicilio= "Juan de Tolosa 24, Zacatecas",
                    Califs=new List<float> {70,88,55,80} } 
                );
                // Todos los registros sin consulta ni filtro
                Console.WriteLine("\nTodos los estudiantes: {0}",Estudiantes.Count());
                Estudiantes.ForEach(est=> Console.WriteLine(est.ToString()));

                // Filtrar los estudiantes que son de Zacatecas
                var estzac = (from est in Estudiantes where est.Domicilio.Contains("Zacatecas") select est).ToList();
                Console.WriteLine("\nTodos los estudiantes de Zacatecas: {0}",estzac.Count());
                estzac.ForEach(est=> Console.WriteLine(est.ToString()));

              // filtrar estudiantes con promedio de 70, mostrar por orden descendente
                var otros = (from est in Estudiantes
                    where est.Califs.Average()>=70
                    orderby est.Nombre descending
                    select est).ToList();

                Console.WriteLine("\nTodos los estudiantes con promedio de 8 en orden descendente por nombre: {0}",otros.Count());
                otros .ForEach(est=> Console.WriteLine(est.ToString()));

                // Consulta con datos agrupados
                var gpoest = from est in Estudiantes group est by est.Matricula;
                    
                    foreach (var gpo in gpoest){
                    Console.WriteLine(gpo.Key);
                    foreach(Estudiante est in gpo)
                        Console.WriteLine(est.ToString());
            }

                // Estudiantes y sus promedios
                 var proms = (from est in Estudiantes
                        select $"nombre{est.Nombre} prom={est.Califs.Average()}").ToList();
                 Console.WriteLine("\nEstudiantes y sus promedios");   
                 proms.ForEach(p=>Console.WriteLine(p));
        }
    }
}
