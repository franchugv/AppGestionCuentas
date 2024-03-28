using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.MostrarCuentas
{
    public class ControladorMostrarCuenta
    {

        public static void ControlMostrarCuenta(List<Cuenta> ListaCuenta)
        {
            byte opcion = 0; // Opción seleccionada por teclado por el usuario para la cuenta
            string aux = "";

            UIMostrarCuentas.MenuMostrar(ListaCuenta);

            aux = Console.ReadLine();

            opcion = Convert.ToByte(aux);

            UIMostrarCuentas.MostrarCuenta(ListaCuenta, opcion);

            UIGeneral.Pausa(); // Dar una pausa para ver la información

        }

    }
}
