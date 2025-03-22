using tareaHerenciasPolimorfismo.MisClases;
using System;
class Program
{
    static void Main()
    {
        // Instancia de Vehículo
        Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
        miCarrito.InformacionVehiculo();
        miCarrito.Acelerar(20);
        miCarrito.Frenar();
        Console.WriteLine();

        // Instancia de CarroElectrico
        CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
        miBYD.InformacionVehiculo();
        miBYD.Acelerar(30);
        miBYD.cargarBateria();
        Console.WriteLine("El nivel de batería es: {0}", miBYD.NivelBateria());
        Console.WriteLine();

        // Instancia de AutoDeCombustion
        AutoDeCombustion miToyota = new AutoDeCombustion(2024, "Negro", "Toyota Corolla");
        miToyota.InformacionVehiculo();
        miToyota.Acelerar(40);
        miToyota.Frenar();
        Console.WriteLine("Nivel de combustible: {0}", miToyota.NivelCombustible());
        Console.WriteLine();

        // Instancia de Motocicleta
        Motocicleta miMoto = new Motocicleta(2025, "Rojo", "Ducati Panigale");
        miMoto.InformacionVehiculo();
        miMoto.Acelerar(50);
        miMoto.Frenar();
        Console.WriteLine("Nivel de aceite: {0}", miMoto.NivelAceite());
        Console.WriteLine();

        // Instancia de Camion
        Camion miCamion = new Camion(2023, "Blanco", "Volvo FH", 5000);
        miCamion.InformacionVehiculo();
        miCamion.Acelerar(20);
        miCamion.Frenar();
        Console.WriteLine("Capacidad de carga: {0} Kilogramos", miCamion.CapacidadCarga());
    }
}
