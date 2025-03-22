// Motocicleta.cs
public class Motocicleta : Vehiculo
{
    public Motocicleta() : base() { }

    public override void Acelerar(int cuanto)
    {
        base.Acelerar(cuanto * 2); // La motocicleta acelera el doble
    }

    public override void Frenar(int cuanto)
    {
        base.Frenar(cuanto);
        Console.WriteLine("La motocicleta frenó.");
    }
}
