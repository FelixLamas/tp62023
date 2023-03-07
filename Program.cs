internal class Program
{
    private static void Main(string[] args)
    {
        string respuesta;
        do
        {   
            Calculadora num = new Calculadora();
            Console.WriteLine("Ingrese un numero:");
            num.Num = Convert.ToDouble(Console.ReadLine());
            double resultado = num.Sumar(10);
            Console.Write(Convert.ToString(resultado));
            Console.WriteLine("¿Desea continuar usando la calculadora:?");
            respuesta =Console.ReadLine();
        } while (respuesta =="s");
    }
}