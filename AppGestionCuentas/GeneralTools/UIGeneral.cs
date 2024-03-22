using AppGestionCuentas.ACuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentas.GeneralTools
{
    /// <summary>
    /// Métodos Generales de la Interfaz de Usuario
    /// </summary>
    public static class UIGeneral
    {
        /// <summary>
        /// Obtiene y valida la opción de un menú
        /// </summary>
        /// <param name="numElementos">Número de Opciones del Menú</param>
        /// <returns>Opción del Menú</returns>
        /// <exception cref="ArgumentNullException">No se ha introducido nada</exception>
        /// <exception cref="OverflowException">Opción fuera de rango</exception>
        /// <exception cref="FormatException">Opción no es un valor numérico</exception>

        public static byte CaptarOpcion(byte numElementos)
        {
            // Recursos Locales
            byte opcion = 0;
            string? aux;

            // Entrada de Datos
            aux = Console.ReadLine();

            // Validación
            if (string.IsNullOrEmpty(aux))
                throw new ArgumentNullException("Cadena Vacía o Nula");
            
            // Preparación de la Cadena - Limpieza de espacios en blanco
            aux = aux.Trim();

            // Conversión - Lanzará las Excepciones correspondientes
            opcion = Convert.ToByte(aux);

            // Validación - Rango de Opciones
            // Se pone mayor o igual ya que nosotros tenemos de 0 a 4 opciones ya que
            // programando se empieza desde 0 pero en la vida real son 5 opciones, es
            // decir del 1 al 5 y no del 0 al 4
            if (opcion >= numElementos)
                throw new OverflowException();

            return opcion;
        }

        /// <summary>
        /// Mostrar Errores
        /// </summary>
        /// <param name="mError"></param>
        public static void MostrarError(string mError)
        {
            Console.WriteLine($"ERROR: {mError}");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadLine();
        }

    }
}
