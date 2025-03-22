// AutoDeCombustion.cs
public class AutoDeCombustion : Vehiculo
{
    private int nivelDeCombustible;

    public AutoDeCombustion() : base()
    {
        nivelDeCombustible = 100;
    }

    public override void Acelerar(int cuanto)
    {
        if (nivelDeCombustible > 0)
        {
            base.Acelerar(cuanto);
            nivelDeCombustible -= 5;
            Console.WriteLine("Nivel de combustible: {0}%", nivelDeCombustible);
        }
        else
        {
            Console.WriteLine("No hay suficiente combustible para acelerar.");
        }
    }

    public override void Frenar(int cuanto)
    {
        base.Frenar(cuanto);
        nivelDeCombustible -= 2;
        Console.WriteLine("Nivel de combustible: {0}%", nivelDeCombustible);
    }
}
