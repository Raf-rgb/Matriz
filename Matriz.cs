using System;

namespace Matriz
{
    class Matriz
    {
        // Defino el arreglo bidimensional en dónde
        // se almacenarán los valores de la matriz.
        private double[,] matriz;

        // Defino las variables (m y n) que almacenan
        // el numero de filas y columnas de la matriz.
        public int rows, columns;

        // Constructor que recibe como parametro
        // la cantidad de filas y columnas para
        // una matriz cuadrada.
        public Matriz(int x)
        {
            matriz = new double[x, x];
            rows = x;
            columns = x;
        }

        // Constructor que recibe como parametro
        // la cantidad de filas y columnas de la
        // matriz a crear.
        public Matriz(int m_, int n_) {
            matriz = new double[m_, n_];
            rows = m_;
            columns = n_;
        }

        // Constructor que recibe como parametro
        // una arreglo bidimensional de tipo 
        //double ya definido.
        public Matriz(double[,] matriz_) {
            matriz = matriz_;
            // Se almacena el numero de filas de la matriz
            rows = matriz.GetLength(0);
            // Se almacena el numero de columnas de la matriz
            columns = matriz.GetLength(1);
        }

        // Funcion para asignar un valor a la matriz
        // en la posicion [i, j]
        public void Append(int i, int j, double num) { matriz[i,j] = num; }

        // Funcion que devuelve el valor de la matriz
        // en la posicion [i, j]
        public double Get(int i, int j) { return matriz[i,j]; }

        // Funcion para mostrar en consola todos
        // los valores de la matriz.
        public void Print() {
            for(int i = 0; i < rows; i++) {
                for(int j = 0; j < columns; j++) {
                    Console.Write(" {0}\t", Get(i, j));
                }
                Console.WriteLine();
            }
        }

        // Funcion que recibe como parametro un objeto
        // de la clase Matriz y se suman los valores de
        // ambas matrices.
        public void Add(Matriz B) {
            if(rows == B.rows && columns == B.columns) {
                for(int i = 0; i < rows; i++) {
                    for(int j = 0; j < columns; j++) {
                        matriz[i, j] += B.Get(i, j);
                    }
                }
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
            }
        }

        // Funcion que recibe como parametros dos matrices
        // A y B. Devuelve la suma de ambas.
        public static Matriz Add(Matriz A, Matriz B) {
            if(A.rows == B.rows && A.columns == B.columns) {
                // Matriz que guardará el resultado de la suma
                Matriz C = new Matriz(A.rows, B.columns);

                for(int i = 0; i < A.rows; i++) {
                    for(int j = 0; j < A.columns; j++) {
                        C.matriz[i, j] = A.Get(i, j) + B.Get(i, j);
                    }
                }

                return C;
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
                return null;
            }
        }


        // Funcion que recibe como parametro un objeto
        // de la clase Matriz y se restan los valores de
        // ambas matrices.
        public void Sub(Matriz B) {
            if(rows == B.rows && columns == B.columns) {
                for(int i = 0; i < rows; i++) {
                    for(int j = 0; j < columns; j++) {
                        matriz[i, j] -= B.Get(i, j);
                    }
                }
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
            }
        }

        // Funcion que recibe como parametros dos matrices
        // A y B. Devuelve la suma de ambas.
        public static Matriz Sub(Matriz A, Matriz B) {
            if(A.rows == B.rows && A.columns == B.columns) {
                // Matriz que guardará el resultado de la suma
                Matriz C = new Matriz(A.rows, B.columns);

                for(int i = 0; i < A.rows; i++) {
                    for(int j = 0; j < A.columns; j++) {
                        C.matriz[i, j] = A.Get(i, j) - B.Get(i, j);
                    }
                }

                return C;
            } else {
                Console.WriteLine("Error: Las matrices no son cuadradas, no se pueden sumar ):");
                return null;
            }
        }

        // Funcion que recibe como parametros dos matrices
        // A y B. Devuelve la multiplicación de ambas.
        public static Matriz Mult(Matriz A, Matriz B) {
            if(A.columns == B.rows) {
                Matriz C = new Matriz(A.rows, B.columns);

                for(int i = 0; i < A.rows; i++) {
                    for(int  j = 0; j < A.columns; j++) {
                        double suma = 0;
                        for(int k = 0; k < A.columns; k++) {
                            suma += A.Get(i, k) * B.Get(k, j);
                        }

                        C.Append(i, j, suma);
                    }
                }

                return C;
            } else {
                Console.WriteLine("Error: no se pueden multiplicar");
                return null;
            }
        }

        // Funcion que devuelve la transpuesta de una matriz
        public Matriz Transpose() {
            Matriz T = new Matriz(columns, rows);

            for(int i = 0; i < T.rows; i++) {
                for(int j = 0; j < T.columns; j++) {
                    T.Append(i, j, Get(j, i));
                }
            }

            return T;
        }
        
        // Funcion que devuelve la matriz dominante
        public double[,] dominante()
        {
            double dd = 0, suma, aux = 0, may = 0;
            int ind = 0;
            Boolean band = true;
            int k = 0;

            for (k = 0; k < 4; k++)
            {
                may = Math.Abs(matriz[k,k]);

                for (int l = k + 1; l < 4; l++)
                {
                    if (may < Math.Abs(matriz[k, l]))
                    {
                        may = Math.Abs(matriz[k, l]);
                        ind = l;
                    }

                }

                suma = 0;
                for (int j = 0; j < 4; j++)
                {
                    if(k == j)
                    {
                        dd = Math.Abs(matriz[j, k]);
                    }
                    else
                    {
                        suma = suma + matriz[j, k];
                    }
                }

                if (dd < suma)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        aux = matriz[i, k];
                        matriz[i, k] = matriz[i, ind];
                        matriz[i, ind] = aux;
                    }
                }
            }

            return matriz;
        }//Fin método dominante
    }
}
