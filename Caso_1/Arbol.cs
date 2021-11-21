using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1
{
    class Arbol
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void InsertarNodo(Postulante dato)
        {
            Nodo puntero, padre;
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = dato;
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (dato.id < puntero.dato.id)
                    {
                        puntero = puntero.izquierda;
                        if (puntero == null)
                        {
                            padre.izquierda = nuevoNodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecha;
                        if (puntero == null)
                        {
                            padre.derecha = nuevoNodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nuevoNodo;
            }
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierda);
                Console.WriteLine("ID: " + raiz.dato.id + "  Nombre y Apellido: " + raiz.dato.nombre + " " + raiz.dato.apellido + " Carrera: "+raiz.dato.carrera);
                Inorden(raiz.derecha);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("ID: " + raiz.dato.id + "  Nombre y Apellido: " + raiz.dato.nombre + " " + raiz.dato.apellido);
                Preorden(raiz.izquierda);
                Preorden(raiz.derecha);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierda);
                Postorden(raiz.derecha);
                Console.WriteLine("ID: " + raiz.dato.id + "  Nombre y Apellido: " + raiz.dato.nombre + " " + raiz.dato.apellido);
            }
        }             
                 
    }
}
