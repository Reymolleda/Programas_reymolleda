using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            Postulante data1 = new Postulante(5, "Pedro", "Caceres Pérez", "Ing. Sistemas");
            Postulante data2 = new Postulante(2, "Lucero", "Arostegui Rieta", "Administración");
            Postulante data3 = new Postulante(10, "Lucia", "Mendez Palomo", "Ing. Electrónica");
            Postulante data4 = new Postulante(100, "Luis Miguel", "Rodriguez Pardo", "Ing. Aeroespacial");
            Postulante data5 = new Postulante(1, "Yumi", "Diaz Lopez", "Ing. Ambiental");
    

            arbol.InsertarNodo(data1);
            arbol.InsertarNodo(data2);
            arbol.InsertarNodo(data3);
            arbol.InsertarNodo(data4);
            arbol.InsertarNodo(data5);       

            Console.WriteLine("Sistema de admisión");


            Console.WriteLine("\nDatos Preorder:\n");
            arbol.Preorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Inorder:\n");
            arbol.Inorden(arbol.GetRaiz());

            Console.WriteLine("\nDatos Postorder:\n");
            arbol.Postorden(arbol.GetRaiz());
        }
    }
}
