
using AppGestionCuentas.ACuentas;
using AppGestionCuentas.Principal;
using R24_JesusCG_V1;

namespace AppGestionCuentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS APLICACIÓN

            List<Cuenta> listaCuentas = new List<Cuenta>();
            MenuPrincipal opcion = MenuPrincipal.Salir;
            bool esCorrecto;    // Controla que no se produzcan errores

            do
            {
                // RESET
                esCorrecto = true; // Se consideraa que no habrá errores;

                UIPrincipal.MostrarMenu();

                // Ya no sirve: opcion = UIPrincipal.CaptarOpcion();
                try
                {
                // Captación de ela opción de menú
                opcion = (MenuPrincipal)GeneralTools.UIGeneral.CaptarOpcion((byte)Enum.GetValues<MenuPrincipal>
                    ().Length);

                    switch (opcion)
                    {
                        case MenuPrincipal.Salir: // Salir
                                                  // TODO: Confirmación del Usuario
                            break;
                        // Añadir Cuentas Bancarias
                        case MenuPrincipal.AgregarCuenta: // Añadir Cuentas
                            ControlACuentas.ControladorACuentas(listaCuentas);
                            break;
                        // Eliminar Cuentas Bancarias
                        case MenuPrincipal.EliminarCuenta: // Eliminar Cuentas
                                                           // TODO: Llamada al subcontrolador - Eliminar
                            break;
                        // Modificar Cuentas Bancarias
                        case MenuPrincipal.ModificarCuenta: // Modificar Cuentas
                                                            // TODO: Llamada al subcontrolador - Modificar
                            break;
                        // Consultar Cuentas Bancarias
                        case MenuPrincipal.ConsultarCuenta: // Consultar Cuentas
                                                            // TODO: Llamada al subcontrolador - Consultar
                            break;
                    }
                }
                catch (Exception error) 
                { 
                    
                }
               


            } while (opcion != MenuPrincipal.Salir || !esCorrecto);

 // o también while (opcion == MenuPrincipal.salir && esCorrecto)

            // Menú Principal


            

        }
    }
}
