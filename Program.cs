using System;

class Program
{
    static void Main(string[] args)
    {
        // Datos de prueba
        string tipoBus = "Platinum";
        double distancia = 15.0;
        int pasajeros = 3;

        // Calcular precio total
        double precioTotal = CalcularPrecio(tipoBus, distancia, pasajeros);

        // Mostrar resultados
        Console.WriteLine("Auto Bus {0}", tipoBus);
        Console.WriteLine("Pasajeros: {0}", pasajeros);
        Console.WriteLine("Ventas: {0}", precioTotal);

        // Calcular asientos disponibles
        int capacidadBus = 25;
        if (tipoBus == "Gold")
        {
            capacidadBus = 20;
        }

        int asientosDisponibles = capacidadBus - pasajeros;

        Console.WriteLine("Quedan {0} asientos disponibles", asientosDisponibles);
    }

    static double CalcularPrecio(string tipoBus, double distancia, int pasajeros)
    {
        double precioBase = 0.0;
        double precioKm = 0.0;
        double precioPasajero = 0.0;

        if (tipoBus == "Platinum")
        {
            precioBase = 5000.0;
            precioKm = 2.0;
            precioPasajero = 100.0;
        }
        else if (tipoBus == "Gold")
        {
            precioBase = 4000.0;
            precioKm = 1.5;
            precioPasajero = 80.0;
        }
        else
        {
            throw new ArgumentException("Tipo de autobús no válido");
        }

        double precioDistancia = distancia * precioKm;
        double precioTotal = precioBase + precioDistancia + precioPasajero * pasajeros;

        return precioTotal;
    }
}
