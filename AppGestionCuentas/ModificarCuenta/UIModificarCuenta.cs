using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.ModificarCuenta
{
    public class UIModificarCuenta
    {

        public static void MenuModificarCuenta(List<Cuenta> ListaCuentas)
        {
            Console.Clear();

            UIGeneral.NumOpcionesLista(ListaCuentas);

            Console.Write("Elija la cuenta a modificar: \n\n");

        }

    }
}
