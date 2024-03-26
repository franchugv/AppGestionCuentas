﻿using R24_JesusCG_V1;
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

            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();

            Pausa();

            Console.Write("Especifique el ingreso: ");
            aux = Console.ReadLine();
            ingreso = Convert.ToSingle(aux);

            Pausa();

            Console.Write("Escriba su fecha de nacimiento: ");
            aux = Console.ReadLine();
            FechaNacimiento = Convert.ToDateTime(aux);

            Pausa();

            Console.Write("Escriba su Nº Cuenta: ");
            n_cuenta = Console.ReadLine();

            Pausa();

        }


        public static void Pausa()
        {
            Console.Write("Pulse Enter para continuar...");
            Console.ReadLine();
        }
    }
}