using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.ModificarCuenta
{
    public class ControladorMCuenta
    {
        public static void ControladorModificarCuentas(List<Cuenta> ListaCuentas)
        {
            UIModificarCuenta.MenuModificarCuenta(ListaCuentas);

            MetodosMCuenta.ModificaciónCuenta(ListaCuentas);
        }
    }
}
