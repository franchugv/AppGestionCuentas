using AppGestionCuentas.GeneralTools;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.ModificarCuenta
{
    public enum Selector : byte { SI, NO }

    public static class MetodosMCuenta
    {


        public static void ModificaciónCuenta(List<Cuenta> ListaCuentas)
        {
            // RECURSOS
            string cadena = "";
            float cantidad;
            DateTime FechaNac = new DateTime(2000, 01, 01);

            bool esValido;
            byte opcion;

            opcion = UIGeneral.SelectorOpcion();

            esValido = ElegirModificar("el titular");
            if (esValido == true)
            {
                Console.Write("Escriba el nuevo titular: ");
                cadena = Console.ReadLine();
                ListaCuentas[opcion].Titular = cadena;
            }

            esValido = ElegirModificar("el Nº Cuenta");
            if (esValido == true)
            {
                Console.Write("Escriba el nuevo Nº Cuenta: ");
                cadena = Console.ReadLine();
                ListaCuentas[opcion].NumCuenta = cadena;
            }

            esValido = ElegirModificar("la cantidad");
            if (esValido == true)
            {
                Console.Write("Especifique la nueva cantidad: ");
                cadena = Console.ReadLine();
                cantidad = Convert.ToSingle(cadena);
                ListaCuentas[opcion].Ingresar(cantidad);
            }

            esValido = ElegirModificar("la fecha de nacimiento");
            if (esValido == true)
            {
                Console.Write("Escriba su nueva Fecha de Nacimiento: ");
                cadena = Console.ReadLine();
                FechaNac = Convert.ToDateTime(cadena);
                ListaCuentas[opcion].FechaNacimiento = FechaNac;
            }


        }





        public static bool ElegirModificar(string cadena)
        {
            byte opcion = 0;
            string aux = "";
            bool esValido = true;

            Console.Write($"¿Desea modificar {cadena}? (0 Sí - 1 No): \n");
            opcion = UIGeneral.CaptarOpcion((byte)Enum.GetValues<Selector>().Length);
            
            switch (opcion)
            {
                case (byte)Selector.SI:
                    esValido = true;
                    break;
                case (byte)Selector.NO:
                    esValido = false;
                    break;
            }

            return esValido;
            

        }

    }
}
