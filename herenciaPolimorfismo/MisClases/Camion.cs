using tareaHerenciasPolimorfismo.MisClases;

internal class Camion : Vehiculo
{
    private int cargaMaxima;

    public Camion(int anio, string elColor, string elModelo, int carga) : base(anio, elColor, elModelo)
    {
        cargaMaxima = carga;
    }

    public override void Acelerar(int cuanto)
    {
        int aceleracionReal = Math.Max(cuanto - 5, 0);
        base.Acelerar(aceleracionReal); // Evita valores negativos
    }

    public override void Frenar()
    {
        base.Frenar();
    }

    public int CapacidadCarga()
    {
        Console.WriteLine("Capacidad máxima de carga : {0} kilogramos", cargaMaxima);
        return cargaMaxima;
    }
}

