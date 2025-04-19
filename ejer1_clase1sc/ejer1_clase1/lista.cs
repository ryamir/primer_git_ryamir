using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1_clase1
{
    public class lista
    {
        private nodos cabeza;
        public lista() 
        {
            cabeza = null;
        }
        public void agregar_al_principio(int valor)

        {
            nodos nuevonodos=new nodos(valor);
            nuevonodos.siguiente=cabeza;
            cabeza=nuevonodos;
        }
        public void mostrar_lista()
        {
            nodos actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual=actual.siguiente;
            }Console.WriteLine();
        }
        public bool buscar(int valor)
        {
            nodos actual = cabeza;
            while (actual != null) 
            {
            if (actual.Valor == valor)
                    return true;
            actual = actual.siguiente;
            }
               return false;
        }
        public void ELIMINAR(int valor)

        { 
            if(cabeza == null)return;
                if (cabeza.Valor == valor)
                    {
                    cabeza = cabeza.siguiente;
                    return;
                
                    }
            nodos actual=cabeza;
            while (actual.siguiente != null && 
                actual.siguiente.Valor != valor)
            {
                actual = actual.siguiente;
            }
            if (actual.siguiente != null)
            {
                actual.siguiente = actual.siguiente.siguiente;
            }

        }
        public int contar_elemetos()
        {
            int conteo = 0;
            nodos actual = cabeza;
            while (actual != null)
            {
            conteo++
                actual = actual.siguiente;
            }
            return conteo;
        }



    }

}
