using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.MostrarCuentas
{
    public static class UIMostrarCuentas
    {
        // Opción que ha de ser elegida por el usuario
        public static void MenuMostrar(List<Cuenta> ListaCuenta)
        {
            Console.Clear();

            UIGeneral.NumOpcionesLista(ListaCuenta);

            Console.Write("Seleccione una cuenta: ");


        }

        public static void MostrarCuenta(List <Cuenta> ListaCuenta, byte opcion)
        {
            Console.WriteLine($"Titular: {ListaCuenta[opcion].Titular}\n");
            Console.WriteLine($"Nº Cuenta: {ListaCuenta[opcion].NumCuenta}\n");
            Console.WriteLine($"Cantidad: {ListaCuenta[opcion].Cantidad}\n");
            Console.WriteLine($"Fecha de Nacimiento: {ListaCuenta[opcion].FechaNacimiento}\n");
        }


    }
}
