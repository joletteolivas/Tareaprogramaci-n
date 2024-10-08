using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("Chevrolet Camaro", 1114960);

            Console.WriteLine("Información del vehículo:");
            vehiculo.MostrarIn();

            double precioYyDescuento = Vehiculo.DescuentoVehi.DescuentoVehiAp(5, vehiculo);

            vehiculo.Precio = precioYyDescuento;

            Console.WriteLine("\nInformación del vehículo más descuento:");
            vehiculo.MostrarIn();

            int diasReserva = 2;
            double TotalCostos = Reserva.TotalCosto (diasReserva, precioYyDescuento);

            Console.WriteLine($"\nCosto total más reserva {diasReserva} de dos días:{TotalCostos:C}");
        }
    }
}