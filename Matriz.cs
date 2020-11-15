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
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    Console.Write(" {0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Funcion que recibe como parametro un objeto
        // de la clase Matriz y se suman los valores de
        // ambas matrices.
        public void Sumar(Matriz m2) {
            if(m == m2.m && n == m2.n) {
                for(int i = 0; i < m; i++) {
                    for(int j = 0; j < n; j++) {
                        matriz[i, j] += m2.matriz[i, j];
                    }
                }
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
            }
        }

        // Funcion que recibe como parametro dos objetos
        // de la clase Matriz y se suman los valores de
        // ambas matrices. Devulve un objeto de la clase
        // Matriz como resultado.
        public Matriz Sumar(Matriz m1, Matriz m2) {
            if(m1.m == m2.m && m1.n == m2.n) {
                Matriz m3 = new Matriz(m1.m, m1.n);
                for(int i = 0; i < m; i++) {
                    for(int j = 0; j < n; j++) {
                        m3.matriz[i, j] = m1.matriz[i, j] + m2.matriz[i, j];
                    }
                }

                return m3;
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
                return null;
            }
        }

        // Funcion para asignar un valor a la matriz
        // en la posicion [i, j]
        public void Append(int i, int j, double num)
        {
            matriz[i,j] = num;
        }
    }
}