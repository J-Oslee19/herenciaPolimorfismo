using System;
using tareaHerenciasPolimorfismo.MisClases;

internal class CarroElectrico : Vehiculo
{
    private int cargaBateria;

    public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        cargaBateria = 50;
    }

    public override void Acelerar(int cuanto)
    {
        if (cargaBateria > 0)
        {
            base.Acelerar(cuanto);
            cargaBateria = Math.Max(cargaBateria - 1, 0); // Evita valores negativos
        }
        else
        {
            Console.WriteLine("Batería agotada. No se puede acelerar.");
        }
    }

    public int NivelBateria()
    {
        return cargaBateria;
    }

    public void cargarBateria()
    {
        cargaBateria = Math.Min(cargaBateria + 10, 100); // Evita sobrecarga
        Console.WriteLine("Cargando batería... Nivel actual: {0}%", cargaBateria);
    }
}

