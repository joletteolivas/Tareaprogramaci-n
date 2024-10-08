using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double Precio { get; set; }

        public Vehiculo(string modelo, double precio)
        {
            Modelo = modelo;
            Precio = precio;
        }
        public class DescuentoVehi
        {
            public static double DescuentoVehiAp(double porcentaje, Vehiculo vehiculo)
            {
                return vehiculo.Precio - (vehiculo.Precio * 5 / 100);
            }
        }
    }
    public static class VehiculoExtension
    {
        public static void MostrarIn(this Vehiculo vehiculo) 
        {
            Console.WriteLine($"Modelo de vehículo:{vehiculo.Modelo}, Su precio:{vehiculo.Precio:C}");
        }
    }

    public static class Reserva
    {
        public static double TotalCosto(int dias, double DescuentoVehiAp)
        {
            return DescuentoVehiAp + ( 3000 * dias);
        }
    }
}
