using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();

            emp.nombre = "Fazur";
            emp.edad = 19;
            emp.sexo = "Masculino";

            Console.WriteLine("El nombre es: " + emp.nombre + " \nLa edad es: " + emp.edad
                + " \nEl sexo es: " + emp.sexo);

            Console.ReadKey();
        }
    }
}
