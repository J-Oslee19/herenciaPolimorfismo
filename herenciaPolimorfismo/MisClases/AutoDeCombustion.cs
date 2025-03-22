using tareaHerenciasPolimorfismo.MisClases;

internal class AutoDeCombustion : Vehiculo
{
    private int nivelCombustible;

    public AutoDeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        nivelCombustible = 100;
    }

    public override void Acelerar(int cuanto)
    {
        if (cuanto > 0) // Evita aceleración negativa
        {
            base.Acelerar(cuanto);
            nivelCombustible -= 2;
        }
    }

    public override void Frenar()
    {
        base.Frenar();
        nivelCombustible -= 1;
    }

    public int NivelCombustible()
    {
        Console.WriteLine("Nivel de combustible: {0}%", nivelCombustible);
        return nivelCombustible;
    }
}
