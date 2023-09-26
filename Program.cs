using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_linkedlist_predefinida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista doblemente enlazada de enteros
            LinkedList<int> lista = new LinkedList<int>();

            // Agregar elementos a la lista
            lista.AddLast(1);
            lista.AddLast(2);
            lista.AddLast(3);

            // Mostrar la lista
            Console.WriteLine("Lista doblemente enlazada:");
            foreach (int elemento in lista)
            {
                Console.WriteLine(elemento);
            }

            // Insertar un elemento en medio de la lista
            LinkedListNode<int> nodo = lista.Find(2);
            lista.AddAfter(nodo, 4);

            // Mostrar la lista actualizada
            Console.WriteLine("\nLista doblemente enlazada después de la inserción:");
            foreach (int elemento in lista)
            {
                Console.WriteLine(elemento);
            }

            // Eliminar un elemento de la lista
            lista.Remove(3);

            // Mostrar la lista después de la eliminación
            Console.WriteLine("\nLista doblemente enlazada después de la eliminación:");
            foreach (int elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
