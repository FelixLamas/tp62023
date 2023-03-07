public class Calculadora
{
    private double num;

    public Calculadora(double num)
    {
        this.Num = num;
    }
    public Calculadora()
    {
        this.Num = num;
    }
    

    public double Num { get => num; set => num = value; }

    public double Sumar(double termino)
    {
        return (this.Num + termino);
    }
}