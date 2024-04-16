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

        
        public static void CrearFichero(Cuenta cuenta)
        {

            // Validar existencia de la cuenta

            ValidarRepeticion(cuenta.NumCuenta);

            StreamWriter Escritor = File.CreateText(cuenta.NumCuenta);

            Escritor.WriteLine(cuenta.Titular);
            Escritor.WriteLine(cuenta.Cantidad);
            Escritor.WriteLine(cuenta.NumCuenta);
        }

        public static void ValidarRepeticion(string ncuenta)
        {
            if (File.Exists(ncuenta)) throw new ApplicationException("Cuenta ya existente");
        }

        internal static void ModificarFichero(Cuenta cuenta)
        {
            throw new NotImplementedException();
        }
    }
}
