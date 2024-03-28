using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.DelCuentas
{
    public static class UIDelCuentas
    {
        public static void MenuDelCuentas(List<Cuenta> ListaCuenta)
        {
            Console.Clear();

            UIGeneral.NumOpcionesLista(ListaCuenta);


            Console.Write($"\nEspecifique la cuenta que desea borrar: ");
        }

        public static void MostrarFinalizarDel()
        {
            Console.WriteLine("La cuenta ha sido borrada.");
            Console.WriteLine("Pulse Enter para continuar...");
            Console.ReadLine();
        }
    }
}
