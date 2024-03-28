using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.Principal
{
    public enum MenuPrincipal : byte { Salir, AgregarCuenta, EliminarCuenta, 
        ModificarCuenta, ConsultarCuenta, CargarPrueba }

    /// <summary>
    /// Clase que proporciona los métodos de interacción de la Interfaz Principal
    /// </summary>
    public static class UIPrincipal
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tMENÚ PRINCIPAL");
            Console.WriteLine("\t0- Salir");
            Console.WriteLine("\t1- Añadir Cuentas");
            Console.WriteLine("\t2- Eliminar Cuentas");
            Console.WriteLine("\t3- Modificar Cuentas");
            Console.WriteLine("\t4- Consultar Cuentas");
            Console.WriteLine("\t5- Cargar Datos de Prueba");
            Console.Write("\nSeleccione Opción: ");

        }


    }
}
