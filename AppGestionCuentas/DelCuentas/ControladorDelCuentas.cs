using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.DelCuentas
{
    public static class ControladorDelCuentas
    {

        public static void ControladorDelCuenta(List <Cuenta> Lista)
        {
           

            UIDelCuentas.MenuDelCuentas();

            UIGeneral.MostrarCuentas(Lista);

            MetodosDelCuentas.ElegirCuentaDel(Lista);

            UIGeneral.MostrarCuentas(Lista);



        }
    }
}
