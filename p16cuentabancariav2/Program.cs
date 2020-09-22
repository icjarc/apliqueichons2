//Programa de Control Bancario V2
//Clase cuenta bancaria
//Clase cliente
//Clase cuenta de cheques
//Clase cuenta de ahorro
//Julio Arturo Renteria Cabrera

using System;

namespace p15cuentabancariav1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco mibanco = new Banco("Banco-torreando", "Arturo Cabrera");
            mibanco.AgregarCliente(new Cliente("Pablo Marmol"));
            mibanco.AgregarCliente(new Cliente("Jose de Arimatea"));
            mibanco.AgregarCliente(new Cliente("Francisco de Asis"));
            mibanco.AgregarCliente(new Cliente("Maria Magdalena"));

            mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(500,0.10));
            mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1500,300));
            mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(1500,200));
            mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(2500,0.08));
            mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(500,30));
            mibanco.Clientes[3].AgregarCuenta(new CuentaDeCheques(1500,0.09));
            mibanco.Clientes[3].AgregarCuenta(mibanco.Clientes[2].Cuentas[1]);

            mibanco.CalcularIntereses();

            Console.WriteLine("========== Reporte Bancario ==========\n");
            Console.WriteLine($"{mibanco.Nombre} - {mibanco.Propietario} \n");
            Console.WriteLine($"Total de Clientes: {mibanco.Clientes.Count}\n");

            foreach(Cliente cte in mibanco.Clientes){
                Console.WriteLine($"Cliente: {cte.Nombre} tiene  {cte.Cuentas.Count} cuentas que son:  ");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    Console.Write((cta is CuentaDeAhorro)?"Cuenta de Ahorro: ":"Cuenta de Cheques: ");
                    Console.WriteLine($"{cta.Saldo}");
                }
                Console.WriteLine();

            }
        }
    }
}
