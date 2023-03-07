internal class Program
{
    private static void Main(string[] args)
    {
        Empleado primerE = new Empleado();
        primerE.Nombre = "Felix";
        primerE.Apellido = "lamas";
        primerE.FechaNacimiento = DateTime.Parse("20/11/1987");
        primerE.EstadoCivil = 'c';
        primerE.Genero = 'M';
        primerE.FechaIngreso = DateTime.Parse("11/09/2011");
        primerE.SueldoBasico = 159000.50;
        primerE.cargo = Cargos.Administrativo;

        /*int anio = primerE.antiguedad();
        Console.WriteLine("El empleado tiene " + anio + "años de antiguedad");
        int edad = primerE.edad();
        Console.WriteLine("El empleado tiene " + edad + "años de edad");
        int aniosJ = primerE.jubilacion();
        Console.WriteLine("Al empleado le faltan " + aniosJ + "años para jubilarse");*/

        Empleado segundoE = new Empleado();
        segundoE.Nombre = "Sofy";
        segundoE.Apellido = "lamas";
        segundoE.FechaNacimiento = DateTime.Parse("11/08/2020");
        segundoE.EstadoCivil = 'S';
        segundoE.Genero = 'M';
        segundoE.FechaIngreso = DateTime.Parse("28/06/2013");
        segundoE.SueldoBasico = 159000.50;
        segundoE.cargo = Cargos.Ingeniero;

        Empleado tercerE = new Empleado();
        tercerE.Nombre = "lucy";
        tercerE.Apellido = "lamas";
        tercerE.FechaNacimiento = DateTime.Parse("28/06/2013");
        tercerE.EstadoCivil = 'S';
        tercerE.Genero = 'M';
        tercerE.FechaIngreso = DateTime.Parse("11/08/2021");
        tercerE.SueldoBasico = 159000.50;
        tercerE.cargo = Cargos.Ingeniero;

        primerE.mostarDatos();
        segundoE.mostarDatos();
        tercerE.mostarDatos();

        double totalSalarios = primerE.salario() + segundoE.salario() + tercerE.salario();
        Console.WriteLine("El total que se paga en concepto de salarios es:" + totalSalarios);

        /*string respuesta;
        do
        {   
            Calculadora num = new Calculadora();
            Console.WriteLine("Ingrese un numero:");
            num.Num = Convert.ToDouble(Console.ReadLine());
            double resultado = num.Sumar(10);
            Console.Write(Convert.ToString(resultado));
            Console.WriteLine("¿Desea continuar usando la calculadora:?");
            respuesta =Console.ReadLine();
        } while (respuesta =="s");*/
    }
}