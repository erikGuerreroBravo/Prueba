using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    class Empleado
    {

        public string nombre { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }

        public Empleado() { }

        public Empleado(string _nombre, int _edad, string _sexo)
        {
            this.nombre = _nombre;
            this.edad = _edad;
            this.sexo = _sexo;
        }

       

    }
}
