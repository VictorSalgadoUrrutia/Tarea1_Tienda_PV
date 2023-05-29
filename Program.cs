using PrimerTarea_Majo_Victor_23CV.Entities;
using PrimerTarea_Majo_Victor_23CV.Services;
using System;

namespace PrimerTarea_Majo_Victor_23CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteServices servicio = new ClienteServices();

            Cliente cliente1 = servicio.Agregar();
            servicio.ImprimirDatos(cliente1);

            servicio.ComprarArticulos();







            Console.WriteLine("Datos del cliente 1:");
            Console.WriteLine("Nombre: " + cliente1.Nombre);
            Console.WriteLine("Teléfono: " + cliente1.Telefono);
            Console.WriteLine("Correo: " + cliente1.Correo);

        }
    }
}
