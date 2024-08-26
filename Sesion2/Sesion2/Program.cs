using Sesion2.clase;

namespace Sesion2
{
    //  LEER LOS DATOS DE UNA PERSONA Y DECIR SI ES MAYOR O MENOR DE EDAD.
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            DateTime fechaNac;
            Persona persona = new Persona();
            Console.Write("Ingrese tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("En que fecha naciste: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}
