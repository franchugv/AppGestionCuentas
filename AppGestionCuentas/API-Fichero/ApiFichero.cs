using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.API_Fichero
{
    public static class ApiFichero
    {

        
        public static void CrearFichero(List<Cuenta> Lista, byte Cuenta)
        {

            // Validar existencia de la cuenta

            ValidarRepeticion(Lista[Cuenta].NumCuenta);

            StreamWriter Escritor = File.CreateText(Lista[Cuenta].NumCuenta);
        }

        public static void ValidarRepeticion(string ncuenta)
        {
            if (File.Exists(ncuenta)) throw new ApplicationException("Cuenta ya existente");
        }


    }
}
