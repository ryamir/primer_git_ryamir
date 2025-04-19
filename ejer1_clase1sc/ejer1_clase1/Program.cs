using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1_clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lista lista = new lista();
            // agregar elementos
            lista.agregar_al_principio(5);
            lista.agregar_al_principio(10);
            lista.agregar_al_principio(15);
            lista.agregar_al_principio(20);
            //mostrar la lista 
            Console.WriteLine("lista despues de " +
                "agregar elementos ");
            lista.mostrar_lista();

            //BUSCAR UN ELEMENTO DE LA LISTA    
            Console.WriteLine("buscar 20 en la lista: ");
            bool encontrado = lista.buscar(20);
            Console.WriteLine(encontrado ? "elemento encontrado." : "elemento no encontrado");

            // BUSCAR UN ELEMENTO QUE NO ESTA EN LA LISTA 
            Console.WriteLine("buscar 40 en la lista:");
            encontrado = lista.buscar(40);
            Console.WriteLine(encontrado ? "elemento no encontrado." : "elementon no encontrado.");

            //ELIMINAR UN ELEMENTO
            lista.ELIMINAR(20);
            Console.WriteLine("lista despues de eliminar un elemento:");
            lista.mostrar_lista();

            //--------------------------------
            Console.WriteLine("INGRESE UN NUEMO ELEMENTO");
            int agregar_elemento;
            agregar_elemento = Convert.ToInt32(Console.ReadLine());
           
            bool agregar =lista.buscar(agregar_elemento); 
            Console.WriteLine(agregar ? $"el valor   { agregar_elemento } esta en la lista. ": $"el valor {agregar_elemento} no esta en la lista.");
            // lista despues de agregar el elemento
            Console.WriteLine("lista despues de agregar nuevo elemento");
            lista.agregar_al_principio(agregar_elemento);
            lista.mostrar_lista();

            //CONTAR LOS ELEMENTOS
            int cantidad = lista.contar_elemetos();
            Console.WriteLine($"el numero total de elementos en la lista es : {cantidad }");



            Console.ReadLine();
        }
    }
}
