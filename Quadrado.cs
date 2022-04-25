public class Quadrado
{

    public Quadrado(double lado) => Lado = lado;   

    public double Lado { get; set; }

    public double Area { get => Lado * Lado; }

    public double Perimetro { get => 4 * Lado; }

}