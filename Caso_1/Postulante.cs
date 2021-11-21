using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_1
{
    class Postulante
    {
        public int id;
        public string nombre, apellido, carrera;

        public Postulante(int id, string nombre, string apellido, string carrera)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
        }
    }
}
