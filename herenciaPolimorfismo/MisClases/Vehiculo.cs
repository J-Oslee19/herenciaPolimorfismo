using System;

namespace tareaHerenciasPolimorfismo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }

        public virtual void Acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
            Console.WriteLine($"El vehículo acelera {cuanto} unidades.");
        }

        public virtual void Frenar()
        {
            velocidad -= 5;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("Frenando... Ahora vas a {0} km/h", velocidad);
        }
    }
}




