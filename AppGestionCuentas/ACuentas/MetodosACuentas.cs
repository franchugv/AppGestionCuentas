using AppGestionCuentas.GeneralTools;
using AppGestionCuentas.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.ACuentas
{
    public static class MetodosACuentas
    {



        public static void AgregarCuentaJoven(List<Cuenta> List) 
        {
            Cuenta NuevaCuenta;

            CargarDatosACuentas(out string nombre, out float ingreso, out DateTime FechaNacimiento, out string n_cuenta);

            NuevaCuenta = new CuentaJoven(nombre, ingreso, FechaNacimiento, n_cuenta);
            List.Add(NuevaCuenta); // Agregar datos a la lista
        }

        public static void AgregarCuentaOro(List<Cuenta> List)
        {
            Cuenta NuevaCuenta;

            CargarDatosACuentas(out string nombre, out float ingreso, out DateTime FechaNacimiento, out string n_cuenta);


            NuevaCuenta = new CuentaOro(nombre, ingreso, FechaNacimiento, n_cuenta);
            List.Add(NuevaCuenta); // Agregar datos a la lista
        }

        public static void AgregarCuentaPlatino(List<Cuenta> List)
        {
            Cuenta NuevaCuenta;

            CargarDatosACuentas(out string nombre, out float ingreso, out DateTime FechaNacimiento, out string n_cuenta);


            NuevaCuenta = new CuentaPlatino(nombre, ingreso, FechaNacimiento, n_cuenta);
            List.Add(NuevaCuenta); // Agregar datos a la lista
        }


        // Menú

        public static void CargarDatosACuentas(out string nombre, out float ingreso, out DateTime FechaNacimiento, out string n_cuenta)
        {

            string aux = "";


            nombre = CaptarCadena("\nEscriba su nombre: ");
            UIGeneral.Pausa();


            Console.Write("\nEspecifique el ingreso: ");
            aux = Console.ReadLine();
            ingreso = Convert.ToSingle(aux);
            UIGeneral.Pausa();

            Console.Write("\nEscriba su fecha de nacimiento (AÑO,MES,DÍA): ");
            aux = Console.ReadLine();
            FechaNacimiento = Convert.ToDateTime(aux);
            UIGeneral.Pausa();


 
            n_cuenta = CaptarCadena("\nEscriba su Nº Cuenta: ");
            UIGeneral.Pausa();


        }


        public static string CaptarCadena(string text)
        {
            // Recursos

            string cadena = "";
            bool esValido;
            string MensajeError = "";

            do
            {
                esValido = true;
                try
                {
                    Console.Write(text);
                    cadena = Console.ReadLine();
                }
                catch (Exception Error)
                {
                    esValido = false;
                    MensajeError = Error.Message;
                }
                finally
                {
                    if (!esValido) UIGeneral.MostrarError(MensajeError);
                }

            } while (!esValido);

            return cadena;
        }

    }
}
