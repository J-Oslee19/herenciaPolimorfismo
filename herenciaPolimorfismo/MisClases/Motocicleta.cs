using tareaHerenciasPolimorfismo.MisClases;

internal class Motocicleta : Vehiculo
{
    private int nivelAceite;

    public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        nivelAceite = 100;
    }

    public override void Acelerar(int cuanto)
    {
        base.Acelerar(cuanto + 5); // Acelera más rápido que un auto
        nivelAceite = Math.Max(nivelAceite - 2, 0); // Evita valores negativos
    }

    public override void Frenar()
    {
        base.Frenar();
        nivelAceite = Math.Max(nivelAceite - 1, 0); // Evita valores negativos
    }

    public int NivelAceite()
    {
        return nivelAceite;
    }
}
