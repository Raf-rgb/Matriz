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

        //Multiplicar una matriz por un vector
        //Recibe A como un vector 4x1 y B como una matriz de 4x4
        public static Matriz AddVector(Matriz A, Matriz B)
        {
            Matriz Vector = new Matriz(4, 1);
            double suma = 0;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    suma += (A.Get(j, 0) * B.Get(i, j));
                }

                Vector.Append(i, 0, suma);
                suma = 0;
            }

            return Vector;

        }

        //Suma de dos matrices de 4x1
        //Gauss Jacobi
        public static Matriz SumaVector(Matriz A, Matriz B)
        {
            Matriz Vector = new Matriz(4, 1);

            for (int i = 0; i < Vector.rows; i++)
            {
                Vector.Append(i, 0, A.Get(i, 0) + B.Get(i, 0));
            }

            return Vector;
        }

        //Resta dos matrices de 4x1 
        //Gauss Jacobi
        public static Matriz RestarMatriz(Matriz A, Matriz B)
        {
            Matriz Vector = new Matriz(4, 4);

            for (int i = 0; i < Vector.rows; i++)
            {
                for (int j = 0; j < Vector.columns; j++)
                {
                    Vector.Append(i, j, A.Get(i, j) - B.Get(i, j));
                }
            }

            return Vector;
        }

        //Diagonal inversa de una matriz para Gauss Jacobi
        public static Matriz Diagonal(Matriz A)
        {
            Matriz Resultado = new Matriz(A.rows, A.columns);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                    {
                        Resultado.Append(i, j, 0);
                    }
                    else
                    {
                        Resultado.Append(i, j, 1/A.Get(i, j));
                    }
                }
            }
            return Resultado;
        }

        //Diagonal de una matriz para Gauss Jacobi
        public static Matriz DiagonalNormal(Matriz A)
        {
            Matriz Resultado = new Matriz(4, 4);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                        Resultado.Append(i, j, A.Get(i, j));
                }
            }
            return Resultado;
        }

        //Método que devuelve una matriz triangular superior
        public static Matriz TriangularSuperior(Matriz A)
        {
            Matriz Resultado = new Matriz(A.rows, A.columns);
                
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j <= i)
                    {
                        Resultado.Append(i,j,0);
                    }
                    else
                    {
                        if(A.Get(i, j) == 0)
                             Resultado.Append(i, j, 0);
                        else
                             Resultado.Append(i, j, -1 * A.Get(i, j));
                    }
                }
            }
            return Resultado;
        }
        
        //Método que devuelve una matriz triangular inferior
        public static Matriz TriangularInferior(Matriz A)
        {
           Matriz Resultado = new Matriz(A.rows, A.columns);

           for (int i = 0; i < 4; i++)
           {
                for (int j = 0; j < 4; j++)
                {
                    if (j > i)
                    {
                        Resultado.Append(i, j, 0);
                    }
                    else
                    {
                        if(A.Get(i, j) == 0)
                             Resultado.Append(i, j, 0);
                        else
                             Resultado.Append(i, j, -1 * A.Get(i, j));
                    }
                }
           }
           return Resultado;
        }
        
        //Método que obtiene la matriz diagonal
        public static Matriz Diagonal(Matriz A)
        {
            Matriz Resultado = new Matriz(A.rows, A.columns);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                    {
                        Resultado.Append(i, j, 0);
                    }
                    else
                    {
                        Resultado.Append(i, j, 1/A.Get(i, j));
                    }
                }
            }
            return Resultado;
        }

        // Funcion que devuelve la matriz dominante
        public static Matriz dominante(Matriz A)
        {
            Matriz Resultado = A;

            double dd = 0, suma, aux = 0, may = 0;
            int ind = 0;

            for (int k = 0; k < 4; k++)
            {
                may = Math.Abs(Resultado.Get(k, k));

                for (int l = k + 1; l < 4; l++)
                {
                    if (may < Math.Abs(Resultado.Get(l, k)))
                    {
                        may = Math.Abs(Resultado.Get(l, k));
                        ind = l;
                    }

                }

                suma = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (k == j)
                    {
                        dd = Math.Abs(Resultado.Get(k, j));
                    }
                    else
                    {
                        suma = suma + Resultado.Get(k, j);
                    }
                }

                if (dd < suma)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        aux = Resultado.Get(i, k);
                        Resultado.Append(i, k, Resultado.Get(i, ind));
                        Resultado.Append(i, ind, aux);
                    }
                }
            }

            return Resultado;
        }//Fin método dominante

        // Funcion que devuelve una fila de la matriz
        // como un vector.
        public Vector Get(int i) {
            Vector v = new Vector(matriz.GetLength(1));

            for(int j = 0; j < v.len; j++) {
                v.vector[j] = matriz[i, j];
            }

            return v;
        }

        // Funcion para obtener una copia del
        // objeto Matriz.
        public Matriz Copy() {
            Matriz copy = new Matriz(rows, columns);

            for(int i = 0; i < rows; i++) {
                for(int j = 0; j < columns; j++) {
                    copy.Append(i, j, matriz[i, j]);
                }
            }

            return copy;
        }

        // Funcion para insertar un vector como
        // a una fila (i) de la matriz.
        public void Insert(Vector v, int i) {
            if(v.len == columns) {
                for(int j = 0; j < v.len; j++) {
                    matriz[i, j] = v.vector[j];
                }
            } else {
                Console.WriteLine($"Error: El numero de elementos del vector es diferente al numero de elementos de la fila {i} de la matriz ):");
            }
        }

        // Metodo de eliminacion de Gauss-Jordan
        public static Matriz GaussJordan(Matriz A) {
            // Matriz resultante
            Matriz B = A.Copy();

            for(int i = 0; i < B.rows; i++) {
                for(int j = 0; j < B.columns; j++) {
                    // Se realizan las operaciones de acuerdo
                    // a la diagonal de la matriz.
                    if(i == j) {
                        if(B.Get(i, j) != 1) {
                            // Si el elemento en la diagonal es un 0
                            // se intercambia el renglon por otro.
                            if(B.Get(i, j) == 0) {
                                for(int f = i; f < B.rows; f++) {
                                    if(B.Get(f, j) == 1 || B.Get(f, j) != 0) {

                                        //Console.WriteLine("\nSe intercambian renglones");
                                        //Console.Write($"\nR[{i}] -> R[{f}]");
                                        //Console.WriteLine("\nResultado: \n");
                                        Vector aux = B.Get(i);
                                        B.Insert(B.Get(f), i);
                                        B.Insert(aux, f);
                                        //B.Print();
                                        break;
                                    }
                                }
                            }

                            // Se obtiene la fila de la matriz
                            Vector row = B.Get(i);

                            //Console.Write($"\nR[{i}]/{B.Get(i, j)} = ");

                            // Se divide el valor de la diagonal
                            // entre si mismo para obtener un pivote.
                            row.Div(B.Get(i, j));
                            
                            //row.Print();
                            
                            // Se insertan los nuevos valore de
                            // la fila a la matriz.
                            B.Insert(row, i);
                            //B.Print();
                        }

                        // Se colocan ceros arriba y abajo de cada 
                        //valor de la diagonal de la matriz
                        for (int k = 1; k < B.rows; k++)
                        {
                            // Si el valor que está debajo o arriba
                            // del valor de la diagonal es diferente
                            // de cero, se realizan las operaciones
                            // entre renglones para obtener un cero.
                            if (B.Get((i + k) % B.rows, j) != 0)
                            {
                                // Vector que guardará el resultado
                                // de la operacion entre reglones.
                                Vector result;
                                // Obtengo la fila de la matriz
                                Vector row = B.Get(i);
                                // Fila en donde se colocará un cero.
                                Vector nextRow = B.Get((i + k) % B.rows);

                                // Se realiza la operacion
                                row.Mult(-1 * B.Get((i + k) % B.rows, j));
                                result = Vector.Add(row, nextRow);
                                
                                //Console.Write($"\n-{B.Get((i + k) % B.rows, j)} * R[{i}] + R[{(i + k) % B.rows}] = ");
                                //result.Print();

                                // Se insertan los nuevos valores de la fila
                                // de la matriz.
                                B.Insert(result, (i + k) % B.rows);
                                
                                //Console.WriteLine("\n Resultado Matriz = \n");
                                
                                //B.Print();
                            }
                        }

                    }
                }
            }

            return B;
        }

        // Funcion para calcular la matriz triangular superior.
        public static Matriz Triangular(Matriz A) {
            // Matriz resultante
            Matriz B = A.Copy();

            for(int i = 0; i < B.rows; i++) {
                for(int j = 0; j < B.columns-1; j++) {
                    // Se realizan las operaciones de acuerdo
                    // a la diagonal de la matriz.
                    if(i == j && B.Get(i, j) != 0) {
                        // Se colocan ceros abajo de cada valor de
                        // la diagonal.
                        for (int k = i+1; k < B.rows; k++)
                        {
                            // Vector que guardará el resultado
                            // de la operacion entre reglones.
                            Vector result;
                            // Obtengo la fila de la matriz
                            Vector row = B.Get(i);
                            // Fila en donde se colocará un cero.
                            Vector nextRow = B.Get(k);

                            // Se realiza la operacion
                            row.Mult(-1 * B.Get(k, j) / B.Get(i, j));
                            result = Vector.Add(row, nextRow);

                            //Console.Write($"\n{-1*B.Get(k, j)}/{B.Get(i, j)} * R[{i}] + R[{k}] = ");
                            //result.Print();

                            // Se insertan los nuevos valores de la fila
                            // de la matriz.
                            B.Insert(result, k);

                            //Console.WriteLine("\n Resultado Matriz = \n");

                            //B.Print();
                        }

                    }
                }
            }
            // Se devuelve la matriz triangular
            return B;
        }

        // Funcion para calcular el determinante de una matriz
        // cuadrada. Recibe como parametro la matriz cuadrada
        // y devuelve su determinante.
        public static double Determinant(Matriz A) {
            double det = 1;

            if(A.rows == A.columns) {
                Matriz B = Triangular(A);

                for(int i = 0; i < B.rows; i++) { det *= B.Get(i, i); }

                if(det == -0) det *= -1;
                return det;
            } else {
                Console.WriteLine("Error: no se puede calcular el determinante, la matriz no es cuadrada ):");
                return 0;
            }
        }

        // Funcion para obtener una matriz identidad.
        // Recibe como parametro el numero de filas y
        // columnas de la matriz identidad deseada.
        public static Matriz Identity(int n) {
            Matriz I = new Matriz(n);
            
            for(int i = 0; i < I.rows; i++) I.Append(i, i, 1);

            return I;
        }

        // Funcion para obtener una matriz identidad.
        // Recibe como parametro el numero de filas y
        // columnas de la matriz identidad deseada.
        public static Matriz Combine(Matriz A, Matriz B) {
            Matriz AB = new Matriz(A.rows, A.columns*2);
            
            for(int i = 0; i < AB.rows; i++) {
                for(int j = 0; j < AB.columns; j++) {
                    if(j >= AB.columns/2) {
                        AB.Append(i, j, B.Get(i, j%A.columns));
                    } else {
                        AB.Append(i, j, A.Get(i, j));
                    }
                }
            }

            return AB;
        }

        public static Matriz Inverse(Matriz A) {
            if(A.rows == A.columns){
                if(Matriz.Determinant(A) != 0) {
                    // Agrego a la matriz una matriz identidad
                    Matriz B = Combine(A, Matriz.Identity(A.rows));
                    // Creo la matriz que guardará la matriz inversa
                    Matriz inverse = new Matriz(A.rows, A.columns);

                    // Se realiza la eliminacion por Gauss-Jordan
                    B = Matriz.GaussJordan(B);
                    
                    // Se extrae solo la matriz identidad que
                    // fue agregada a la matriz. Esta tendrá
                    // los valores de la matriz inversa.
                    for(int i = 0; i < B.rows; i++) {
                        for(int j = B.columns/2; j < B.columns; j++) {
                            inverse.Append(i, j%A.columns, B.Get(i, j));
                        }
                    }
                    return inverse;
                    
                } else {
                    Console.WriteLine("Error: el determinante de la matriz es 0 ):");
                    return null;
                }
            } else {
                Console.WriteLine("Error: la matriz no es cuadrada ):");
                return null;
            }
        }
    }
}
