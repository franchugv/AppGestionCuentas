using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionCuentas.GeneralTools;
using AppGestionCuentas.Principal;
using R24_JesusCG_V1;

namespace AppGestionCuentas.ACuentas
{

    /// <summary>
    /// Controlador del Módulo para la Adición de Cuentas Bancarias
    /// </summary>
    public static class ControlACuentas
    {
        public static void ControladorACuentas(List<Cuenta> listaCuentas)
        {
            MenuACuentas opcion = MenuACuentas.Salir;
            bool esValido;
            string mError = "";

            do
            {
                esValido = true;
                try { 
                UIACuentas.MostrarMenuACuentas();

                opcion = (MenuACuentas)UIGeneral.CaptarOpcion((byte)(Enum.GetNames<MenuACuentas>().Length));

                switch (opcion)
                {
                    case MenuACuentas.Salir:
                        break;
                    case MenuACuentas.CuentaJoven:
                        ACuentas.MetodosACuentas.AgregarCuentaJoven(listaCuentas);
                        break;
                    case MenuACuentas.CuentaOro:
                        ACuentas.MetodosACuentas.AgregarCuentaOro(listaCuentas);
                        break;
                    case MenuACuentas.CuentaPlatino:
                        ACuentas.MetodosACuentas.AgregarCuentaPlatino(listaCuentas);
                        break;
                }


                }
                catch(Exception error)
                {
                    esValido = false;
                    mError = error.Message;
                }
                finally
                {
                    if (!esValido) 
                    { 
                    UIGeneral.MostrarError(mError);
                    }
                }

            } while (opcion != MenuACuentas.Salir);

        }
    }
}
