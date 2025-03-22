// Camion.cs
public class Camion : Vehiculo
{
    private int cargaActual;

    public Camion() : base()
    {
        cargaActual = 1000; // Carga inicial
    }

    public override void Acelerar(int cuanto)
    {
        base.Acelerar(cuanto);
        cargaActual -= 50; // Perdemos carga al acelerar
        Console.WriteLine("Carga actual: {0} kg", cargaActual);
    }

    public override void Frenar(int cuanto)
    {
        base.Frenar(cuanto);
        cargaActual += 20; // Aumentamos la carga ligeramente al frenar
        Console.WriteLine("Carga actual: {0} kg", cargaActual);
    }
}
