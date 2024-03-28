using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.ACuentas
{
    public enum MenuACuentas : byte { Salir, CuentaJoven, CuentaOro, CuentaPlatino }

    public static class UIACuentas
    {
        public static void MostrarMenuACuentas()
        {

            Console.Clear();

            Console.WriteLine("\t\t MENÚ - Agregar Cuentas Bancarias");
            Console.WriteLine("\t 0 - Salir");
            Console.WriteLine("\t 1 - Cuenta Joven");
            Console.WriteLine("\t 2 - Cuenta Oro");
            Console.WriteLine("\t 3 - Cuenta Platino");
            Console.WriteLine("\n\t\t Seleccione Tipo de Cuenta: ");

        }

    }
}
