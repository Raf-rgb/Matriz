using System;

namespace Matriz
{
    class Matriz
    {
        // Defino el arreglo bidimensional en dónde
        // se almacenarán los valores de la matriz.
        public double[,] matriz;

        // Defino las variables (m y n) que almacenan
        // el numero de filas y columnas de la matriz.
        public int m, n;

        // Constructor que recibe como parametro
        // la cantidad de filas y columnas para
        // una matriz cuadrada.
        public Matriz(int x)
        {
            matriz = new double[n, n];
            n = x;
            m = x;
        }

        // Constructor que recibe como parametro
        // la cantidad de filas y columnas de la
        // matriz a crear.
        public Matriz(int m_, int n_) {
            matriz = new double[m_, n_];
            m = m_;
            n = n_;
        }

        // Constructor que recibe como parametro
        // una arreglo bidimensional de tipo 
        //double ya definido.
        public Matriz(double[,] matriz_) {
            matriz = matriz_;
            // Se almacena el numero de filas de la matriz
            m = matriz.GetLength(0);
            // Se almacena el numero de columnas de la matriz
            n = matriz.GetLength(1);
        }

        // Funcion para mostrar en consola todos
        // los valores de la matriz.
        public void Print() {
            for(int j = 0; j < n; j++) {
                for(int i = 0; i < m; i++) {
                    Console.Write(" {0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        public void append(int i, int j, double num)
        {
            matriz[i,j] = num;
        }
    }
}
