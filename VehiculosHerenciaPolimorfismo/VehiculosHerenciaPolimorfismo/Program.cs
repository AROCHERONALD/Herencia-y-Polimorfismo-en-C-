public class Vehiculo
{
    private int velocidad; // Propiedad privada para velocidad.

    // Constructor de la clase Vehículo
    public Vehiculo()
    {
        velocidad = 0; // La velocidad inicial es 0
    }

    // Método virtual Acelerar: puede ser sobrescrito en las clases derivadas
    public virtual void Acelerar(int cuanto)
    {
        velocidad += cuanto;
        Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
    }

    // Método virtual Frenar: puede ser sobrescrito en las clases derivadas
    public virtual void Frenar(int cuanto)
    {
        velocidad -= cuanto;
        if (velocidad < 0) velocidad = 0; // Evitar que la velocidad sea negativa
        Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
    }

    // Métodos adicionales que podrían ser sobrescritos en las clases derivadas
    public virtual void Encender()
    {
        Console.WriteLine("El vehículo está encendido.");
    }

    public virtual void Apagar()
    {
        Console.WriteLine("El vehículo está apagado.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de cada tipo de vehículo
        Vehiculo miAuto = new AutoDeCombustion();
        Vehiculo miMoto = new Motocicleta();
        Vehiculo miCamion = new Camion();

        // Usar los métodos Acelerar y Frenar
        miAuto.Acelerar(20);  // El auto acelera
        miAuto.Frenar(10);    // El auto frena

        miMoto.Acelerar(30);  // La moto acelera
        miMoto.Frenar(15);    // La moto frena

        miCamion.Acelerar(40);  // El camión acelera
        miCamion.Frenar(25);    // El camión frena
    }
}

