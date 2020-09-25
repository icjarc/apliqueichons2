using System;
using System.Collections.Generic;
using System.Linq;

namespace p23parcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            Red lared =  new Red("Red Patito S.A. de C.V.", "Mr. Pato Macdonald", "Av. Princeton 123, Orlando Florida");
            
            lared.AumentaNodo(new Nodo("192.168.0.10","servidor",5,10,"linuts"));
            lared.AumentaNodo(new Nodo("192.168.0.12","equipoactivo",2,12,"ios"));
            lared.AumentaNodo(new Nodo("192.168.0.20","computadora",8,5,"windows"));
            lared.AumentaNodo(new Nodo("192.168.0.15","servidor",10,22,"linuts"));

            lared.Nodos[0].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrario",
                "remota",new DateTime(2015,04,14)));
            lared.Nodos[0].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio",
                "local",new DateTime(2017,01,10)));
            lared.Nodos[1].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS",
                "remota",new DateTime(2017,02,21)));
            lared.Nodos[2].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2009-2504","microsoft"," Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1",
                "local",new DateTime(2009,11,13)));
            lared.Nodos[2].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold",
                "local",new DateTime(2016,12,20)));
            lared.Nodos[2].AumentaVulnerabilidad(new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable",
                "remota",new DateTime(2017,02,15)));

            Console.WriteLine("\n>> Datos generales de la red:\n");
            Console.WriteLine($"Empresa \t: {lared.Empresa}");
            Console.WriteLine($"Propietario \t: {lared.Propietario}");
            Console.WriteLine($"Domicilio \t: {lared.Domicilio}");
            
            Console.WriteLine("\nTotal nodos red: {0}", lared.Nodos.Count());

            Console.WriteLine($"Total vulnerabilidades: {lared.Nodos.Sum(nod => nod.Vulnerabilidades.Count())}");
            
            Console.WriteLine("\n>> Datos generales de los nodos:\n");
            foreach(Nodo nod in lared.Nodos){
                Console.WriteLine($"Ip: {nod.Ip}, Tipo: {nod.Tipo}, Puertos: {nod.Puertos}, Saltos: {nod.Saltos}, SO: {nod.SO}, TotVul: {nod.Vulnerabilidades.Count()}");
            }

            //Número mayor de saltos
            var mayor = (from sal in lared.Nodos
                select sal.Saltos).Max();
            Console.WriteLine($"\nMayor numero de saltos: {mayor}");
            //número menor de saltos
            var menor = (from sal in lared.Nodos
                select sal.Saltos).Min();
            Console.WriteLine($"Menor numero de saltos: {menor}");

            Console.WriteLine("\n>> Vulnerabilidades por nodo:");
            foreach(Nodo nod in lared.Nodos){
                Console.WriteLine($"\n> Ip: {nod.Ip}, Tipo: {nod.Tipo}");
                Console.WriteLine("\nVulnerabilidades:");
                foreach(Vulnerabilidad vul in nod.Vulnerabilidades){
                    double antiguedad = ((DateTime.Now - vul.Fecha).TotalDays)/365;
                    Console.WriteLine($"\nClave: {vul.Clave}, Vendedor: {vul.Vendedor}, Descripcion: {vul.Descripcion},Tipo: {vul.Tipo}, Fecha: {vul.Fecha}, Antiguedad: {(int)antiguedad}");
                }
                Console.WriteLine();
            }
        }
    }
} 
// EP1 RenteriaCabreraJulioArturo