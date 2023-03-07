public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    public Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

    public int antiguedad(){
        DateTime fechaActual = DateTime.Now;
        if (fechaIngreso < fechaActual)
        {
            int anios = fechaActual.Year - fechaIngreso.Year;
            if (fechaActual.Month < fechaIngreso.Month)
            {
                --anios;
            }
            return anios;
        }
        return -1;
    }

    public int  edad(){
        DateTime fechaActual = DateTime.Now;
        if (fechaNacimiento < fechaActual)
        {
            int anios = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Month > fechaActual.Month)
            {
                --anios;
            }
            return anios;
        }
        return -1;
    }

    public int jubilacion(){
        int edad = this.edad();
        int anios;
        if (genero =='M')
        {
            anios = 65 - edad;
        } else
        {
            anios = 60 - edad;
        }
        return anios;
    }

    public double salario(){
        int antiguedad = this.antiguedad();
        double adicional= sueldoBasico * antiguedad;
        if (antiguedad >= 20)
        {
            adicional = sueldoBasico * 0.25;
        }
        if (cargo == Cargos.Ingeniero || cargo== Cargos.Especialista)
        {
            adicional = adicional * 1.50;
        }
        if (estadoCivil =='C')
        {
            adicional = adicional + 15000;
        }
        return (sueldoBasico + adicional);
    }

    public void mostarDatos()
    {
        Console.WriteLine("Informacion del empleado\n");
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Apellido: " + this.apellido);
        Console.WriteLine("Fecha de nacimiento:" + fechaNacimiento.ToString("dd/M/yyyy"));
        Console.WriteLine("Fecha de ingreso a la empresa:" + fechaIngreso.ToString("dd/M/yyyy"));
        Console.WriteLine("Sueldo basico: " + sueldoBasico);
        Console.WriteLine("Cargo que ocupa: " + cargo);
        Console.WriteLine("Antiguedad en la empresa:" + this.antiguedad());
        Console.WriteLine("edad del empleado:" + this.edad());
        Console.WriteLine("Años que le faltan para jubilarse" + this.jubilacion());
        Console.WriteLine("Salario:" + this.salario());
    }
}