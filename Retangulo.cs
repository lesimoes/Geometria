using System;

public class Retangulo
{
    private double baseRetangulo;
    private double alturaRetangulo;

    public Retangulo(double baseRetangulo, double alturaRetangulo)
    {
        this.alturaRetangulo = alturaRetangulo;
        this.baseRetangulo = baseRetangulo;
    }

    public double calculaArea()
    {
        return this.baseRetangulo * this.alturaRetangulo;
    }

    public double calculaPerimetro()
    {
        return (2 * alturaRetangulo) + (2 * baseRetangulo);
    }

    public override string toString()
    {
        return calculaArea() + calculaPerimetro();
    }
}