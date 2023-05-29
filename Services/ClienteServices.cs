using PrimerTarea_Majo_Victor_23CV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerTarea_Majo_Victor_23CV.Services
{
    public class ClienteServices
    {

        public Cliente Agregar()
        {
            try
            {
                Cliente clienteCompra = new Cliente();

                Console.WriteLine("Ingrese el nombre del cliente:");
                clienteCompra.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el teléfono del cliente:");
                clienteCompra.Telefono = Console.ReadLine();

                Console.WriteLine("Ingrese el correo del cliente:");
                clienteCompra.Correo = Console.ReadLine();

                return clienteCompra;
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error: " + ex.Message);
            }
        }


        public void ImprimirDatos(Cliente request)
        {
            try
            {
                Console.WriteLine("El nombre es: " + request.Nombre);
                Console.WriteLine("El apellido es: " + request.Telefono);
                Console.WriteLine("El dia de ingreso  es: " + request.Correo);
                
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error " + ex.Message);
               
            }
        }
        public void ComprarArticulos()
        {
            List<Articulos> articulos = new List<Articulos>()
    {
        new Articulos { Nombre = "Smartphone 1", Precio = 2200 },
        new Articulos { Nombre = "Laptop 2 ", Precio = 1500 },
        new Articulos { Nombre = "Tablet 3 ", Precio = 2500 },
        new Articulos { Nombre = "Smartwatch 4 ", Precio = 4200 },
        new Articulos { Nombre = "Cámara digital 5 ", Precio = 3800 }
    };
            Console.WriteLine("Lista de artículos electrónicos para comprar:");

            double total = 0;
            foreach (var articulo in articulos)
            {
                Console.WriteLine(articulo.Nombre + ": $" + articulo.Precio);
                Console.WriteLine("¿Desea comprar " + articulo.Nombre + "? (S/N)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() == "S")
                {
                    total += articulo.Precio;
                }
            }
            Console.WriteLine("El total a pagar es: $ " + total);

            if (total >= 5000)
            {
                double desc = total * 0.10; ;
                double descF = total - desc;
                Console.WriteLine("Tienes un descuento del 10% " + descF);
            }
            if (total >= 8000)
            {
                double desc = total * 0.10; ;
                double descF = total - desc;
                Console.WriteLine("Pagas a 3 meses sin intereses");
                double pagoMensual = descF / 3; // Calcular el pago mensual sin intereses
                Console.WriteLine("Total con descuento del 10%: " + descF);
                Console.WriteLine("Pago mensual a 3 meses sin intereses: " + pagoMensual);

            }

            if (total >= 10000)
            {
                string resp = " ";
                Console.WriteLine("Tu compra es mayor a 10000, puedes pagar a 3(T) meses o 6(S) meses tu eliges (T/S)");
                resp = Console.ReadLine();
                if (resp.ToUpper() == "T")
                {
                    double desc = total * 0.10; ;
                    double descF = total - desc;
                    Console.WriteLine("Pagas a 3 meses sin interesesssss");
                    double pagoMensual = descF / 3; // Calcular el pago mensual sin intereses
                    Console.WriteLine("Total con descuento del 10%: " + descF);
                    Console.WriteLine("Pago mensual a 3 meses sin intereses: " + pagoMensual);
                }
                else if (resp.ToUpper() == "S")
                {
                    double desc = total * 0.10; ;
                    double descF = total - desc;
                    Console.WriteLine("Pagas a 6 meses sin intereses");
                    double pagoMensual = descF / 6; // Calcular el pago mensual sin intereses
                    Console.WriteLine("Total con descuento del 10%: " + descF);
                    Console.WriteLine("Pago mensual a 6 meses sin intereses: " + pagoMensual);
                }
            }
            else
            {
                Console.WriteLine("No aplicas a ningun descuento");
            }

            




        }




    }
}
