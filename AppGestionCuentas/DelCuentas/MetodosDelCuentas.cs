using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.DelCuentas
{
    public static class MetodosDelCuentas
    {
        public static void ElegirCuentaDel(List <Cuenta> Cuentas)
        {
            string aux = "";
            byte eleccion = 0;

            aux = Console.ReadLine();
            eleccion = Convert.ToByte(aux);


            Cuentas.Remove(Cuentas[eleccion]);
        }
    }
}
