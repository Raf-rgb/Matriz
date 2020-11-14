using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo una matriz con la libreria (clase)
            // Matriz de 3 filas por 3 columnas.
            Matriz m = new Matriz(3, 3);

            // Imprimo la matriz con la funcion Print().
            m.Print();
        }
    }
}
