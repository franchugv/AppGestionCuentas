﻿
using AppGestionCuentas.ACuentas;
using AppGestionCuentas.GeneralTools;
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
            string MensajeError = "";

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
                        case MenuPrincipal.CargarPrueba:    // Cargar lista datos prueba
                            CargarDatosPrueba(listaCuentas);
                            break;
                    }
                }
                catch (ArgumentException error) 
                {
                    esCorrecto = false;
                    MensajeError = "No ha introducido ninguna opción";
                }
                catch (OverflowException error)
                {
                    esCorrecto = false;
                    MensajeError = "La opción seleccionada no está entre las propuestas";
                }
                catch (FormatException error)
                {
                    esCorrecto = false;
                    MensajeError = "No ha introducido un valor numérico";
                }
                catch (Exception error)
                {
                    esCorrecto = false;
                    MensajeError = error.Message;
                }
                finally
                {
                    if (!esCorrecto) UIGeneral.MostrarError(MensajeError);
                }



            } while (opcion != MenuPrincipal.Salir || !esCorrecto);

 // o también while !(opcion == MenuPrincipal.salir && esCorrecto)

            // Menú Principal


            

        }

        private static void CargarDatosPrueba(List<Cuenta> lista)
        {
            Cuenta NuevaCuenta;

            // Agregar a la colección 4 cuentas Joven
            NuevaCuenta = new CuentaJoven("Jacinto", 5000, new DateTime(2000, 10, 12), "00000000000000000001");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaJoven("Ana", 2500, new DateTime(2005, 5, 25), "00000000000000000002");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaJoven("Jacinto", 1000, new DateTime(2004, 7, 8), "00000000000000000003");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaJoven("Ildefonsio", 2548, new DateTime(2002, 3, 3), "00000000000000000004");
            lista.Add(NuevaCuenta);
            // Agregar a la colección 4 cuentas Oro

            NuevaCuenta = new CuentaOro("Gebaro", 10000, new DateTime(1995, 10, 12), "00000000000000000005");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaOro("Luisa", 500, new DateTime(1990, 5, 25), "00000000000000000006");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaOro("Carmen", 6000, new DateTime(1985, 7, 8), "00000000000000000007");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaOro("Julia", 2000, new DateTime(1980, 3, 3), "00000000000000000008");
            lista.Add(NuevaCuenta);

            // Agregar a la colección 4 cuentas Platino

            NuevaCuenta = new CuentaPlatino("Abel", 500000, new DateTime(1995, 10, 12), "00000000000000000009");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaPlatino("Marín", 25000000, new DateTime(1990, 5, 25), "00000000000000000010");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaPlatino("María", 100000, new DateTime(1985, 7, 8), "00000000000000000011");
            lista.Add(NuevaCuenta);
            NuevaCuenta = new CuentaPlatino("Marino", 254800, new DateTime(1980, 3, 3), "00000000000000000012");
            lista.Add(NuevaCuenta);

        }
    }
}