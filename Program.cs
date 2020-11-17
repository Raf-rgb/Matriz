using System;

namespace Matriz
{
    class Program
    {
        static string op = "1";
        static void Main(string[] args)
        {
            Vector p0;
            double tol;
            while(true) {
                Console.WriteLine("\n////// Tipo de sistema de ecuaciones //////");
                Console.WriteLine("\n1) Sistema de ecuaciones lineales");
                Console.WriteLine("2) Sistema de ecuaciones no lineales");
                Console.WriteLine("3) Salir");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.Write("  > ");
                op = Console.ReadLine();
                op.Replace(" ", "");

                if(op.Equals("1")) {
                    while(true) {
                        // Se muestra un menu de sistemas de ecuaciones no lineales
                        // para resolver por el metodo de Newton-Raphson.
                        Console.WriteLine("\n////// Sistemas de ecuaciones lineales //////");
                        Console.WriteLine("\n1) | 7 -2  1  2 | 3 |\n" +
                                        "   | 2  8  3  1 |-2 |\n" +
                                        "   |-1  0  5  2 | 5 |\n" +
                                        "   | 0  2 -1  4 | 4 |");
                        Console.WriteLine("\n2) | 0  3 -1  8 | 15 |\n" +
                                        "   | 2 -1 10 -1 | 11 |\n" +
                                        "   |-1 11 -2  3 |  6 |\n" +
                                        "   |10 -1  2  0 |  6 |");
                        Console.WriteLine("\n3) | 4 -2  0  0 | 0 |\n" +
                                        "   |-2  5 -1  0 | 2 |\n" +
                                        "   | 0 -1  4  2 | 3 |\n" +
                                        "   | 0  0  2  3 |-2 |");
                        Console.WriteLine("\n4) | 2  8  3  1 |-2 |\n" +
                                        "   | 0  2 -1  4 | 4 |\n" +
                                        "   | 7 -2  1  2 | 3 |\n" +
                                        "   |-1  0  5  2 | 5 |");
                        Console.WriteLine("\n5) Salir");
                        //El usuario selecciona una opcion
                        Console.WriteLine("\nSeleccione una opcion: ");
                        Console.Write("  > ");
                        op = Console.ReadLine();
                        op.Replace(" ", "");

                        if(op.Equals("1") || op.Equals("2") || op.Equals("3") || op.Equals("4")) {
                            // Variable auxiliar que nos indicará el sistema
                            // que el usuario seleccionó en el menú anterior.
                            string aux = op;
                            while(true) {
                                Console.WriteLine("\n////// Tipo de sistema de ecuaciones //////");
                                Console.WriteLine("\n1) Sistema de ecuaciones lineales");
                                Console.WriteLine("2) Sistema de ecuaciones no lineales");
                                Console.WriteLine("3) Salir");
                                Console.WriteLine("\nSeleccione una opcion: ");
                                Console.Write("  > ");
                                op = Console.ReadLine();
                                op.Replace(" ", "");

                                if(op.Equals("1")) {
                                    Console.WriteLine("\n////// Metodo de Gauss-Jacobi //////");
                                    Console.Write("\nIngrese la tolerancia: ");
                                    tol = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el no de iteraciones: ");
                                    int iteraciones = Convert.ToInt32(Console.ReadLine());
                                    GaussJacobi(aux, tol, iteraciones);
                                } else if(op.Equals("2")) {
                                    Console.WriteLine("\n////// Metodo de Gauss-Jacobi //////");
                                    Console.WriteLine("\nAqui va el metodo de Gauss-Seidel");
                                } else if(op.Equals("3")) {
                                    break;
                                } else {
                                    Console.WriteLine($"\nError: La opcion {op} no existe, intentelo de nuevo ):");
                                }
                            }
                        } else if(op.Equals("5")) {
                            break;
                        } else {
                            Console.WriteLine($"\nError: La opcion {op} no existe, intentelo de nuevo ):");
                        }
                    }
                    
                } else if (op.Equals("2")) {
                    Console.Clear();
                    while(true) {
                        // Se muestra un menu de sistemas de ecuaciones no lineales
                        // para resolver por el metodo de Newton-Raphson.
                        Console.WriteLine("\n////// Metodo de Newton Raphson //////");
                        Console.WriteLine("\n1) f(x, y, z) = 9x^2 + 36y^2 + 4z^2 - 36\n" +
                                        "   f(x, y, z) = x^2 - 2y^2 - 20z\n" + 
                                        "   f(x, y, z) = x^2 - y^2 + z^2");
                        Console.WriteLine("\n2) f(x, y, z) = 3x - cos(yz) - 1/2\n" +
                                        "   f(x, y, z) = 4x^2 - 625y^2 + 2y - 1\n" + 
                                        "   f(x, y, z) = e^(-xy)x^2 + 20z + (10PI - 3) / 3");
                        Console.WriteLine("\n3) Salir");
                        //El usuario selecciona una opcion
                        Console.WriteLine("\nSeleccione una opcion: ");
                        Console.Write("  > ");
                        op = Console.ReadLine();
                        op.Replace(" ", "");

                        // Si seleccionó algun sistema, es se resuleve con
                        // la funcion NewtonRaphson() y se muestran los 
                        // resultados.
                        if(op.Equals("1") || op.Equals("2")) {
                            // Se indica el formato para ingresar el vector
                            // inicial.
                            Console.WriteLine("\n-- Utilice los siguientes formatos --");
                            Console.WriteLine("-> {1, 2, 3}");
                            Console.WriteLine("-> 1, 2, 3");
                            // Se pide al usuario el vector inicial p0.
                            Console.Write("\nIngrese el vector inicial p0: ");
                            p0 = new Vector(Console.ReadLine());
                            // Se pide al usuario la tolerancia.
                            Console.Write("Ingrese la tolerancia: ");
                            tol = Convert.ToDouble(Console.ReadLine());
                            
                            // Se muestran los resultados obtenidos del
                            // metodo de Newton-Raphson.
                            Console.WriteLine("\n--- Solución ---");
                            Vector r = NewtonRaphson(p0, tol);
                            
                            Console.WriteLine($"\nx -> {r.vector[0]}");
                            Console.WriteLine($"y -> {r.vector[1]}");
                            Console.WriteLine($"z -> {r.vector[2]}");
                        } else if(op.Equals("3")) {
                            break;
                        } else {
                            Console.WriteLine($"Error: La opcion {op} no existe, intentelo de nuevo ):");
                        }
                    }
                } else if(op.Equals("3")){
                    break;
                } else {
                    Console.WriteLine($"Error: La opcion {op} no existe, intentelo de nuevo ):");
                }
            }
            
            
        }

        // Funcion para obtener la matriz
        // del sistema seleccionado por 
        // el usuario.
        static Matriz System(string sistema) {
            Matriz m;

            if(sistema.Equals("1")) {
                m = new Matriz(new double[,] {
                    { 7, -2, 1, 2 }, 
                    { 2, 8, 3, 1 }, 
                    { -1, 0, 5, 2 }, 
                    { 0, 2, -1, 4 }
                });
            } else if(sistema.Equals("2")) {
                m = new Matriz(new double[,] {
                    { 0, 3, -1, 8 }, 
                    { 2, -1, 10, -1 }, 
                    { -1, 11, -2, 3 }, 
                    { 10, -2, 2, 0 }
                });
            } else if(sistema.Equals("3")) {
                m = new Matriz(new double[,] {
                    { 4, -2, 0, 0 }, 
                    { -2, 5, -1, 0 }, 
                    { 0, -1, 4, 2 }, 
                    { 0, 0, 2, 3 }
                });
            } else {
                m = new Matriz(new double[,] {
                    { 2, 8, 3, 1 }, 
                    { 0, 2, -1, 4 }, 
                    { 7, -2, 1, 1 }, 
                    { -1, 0, 5, 2 }
                });
            }

            return m;
        }

        // Funcion para obtener la matriz
        // del sistema seleccionado por 
        // el usuario.
        static Vector VectorResultados(string sistema) {
            //Matriz m;
            Vector v;

            if(sistema.Equals("1")) {
                v = new Vector("{3, -2, 5, 4}");
                /*m = new Matriz(new double[,] {
                    { 3 }, 
                    { -2 }, 
                    { 5 }, 
                    { 4 }
                });*/
            } else if(sistema.Equals("2")) {
                v = new Vector("{15, 11, 6, 6}");
                /*m = new Matriz(new double[,] {
                    { 15 }, 
                    { 11 }, 
                    { 6 }, 
                    { 6 }
                });*/
            } else if(sistema.Equals("3")) {
                v = new Vector("{0, 2, 3, -2}");
                /*m = new Matriz(new double[,] {
                    { 0 }, 
                    { 2 }, 
                    { 3 }, 
                    { -2 }
                });*/
            } else {
                v = new Vector("{-2, 4, 3, 5}");
                /*m = new Matriz(new double[,] {
                    { -2 }, 
                    { 4 }, 
                    { 3 }, 
                    { 5 }
                });*/
            }

            return v;
        }

        // Funcion que devuelve una matriz 
        // evaluada en un vector que contiene
        // los valores de las variables (x, y, z).
        static Vector F(Vector v) {
            // Se obtienen los valores de las variables
            // del vector que es recibido como parametro.
            double x = v.vector[0];
            double y = v.vector[1];
            double z = v.vector[2];

            // Matriz que guardará el resultado de la
            // evaluacion.
            Vector F;

            // Se obtendrá una evaluacion de acuerdo al 
            // sistema que el usuario haya seleccionado.
            if(op.Equals("1")) {
                // Se definen los valores de la matriz
                F = new Vector(new double[]{
                    9 * Math.Pow(x, 2) + 36 * Math.Pow(y, 2) + 4 * Math.Pow(z, 2) -36,
                    Math.Pow(x, 2) - 2 * Math.Pow(y, 2) - 20 * z,
                    Math.Pow(x, 2) - Math.Pow(y, 2) + Math.Pow(z, 2)
                });

                return F;
            } else {
                // Se definen los valores de la matriz
                F = new Vector(new double[]{
                    3 * x - Math.Cos(y * z) - 1/2,
                    4 * Math.Pow(x, 2) - 625 * Math.Pow(y, 2) + 2 * y - 1,
                    Math.Exp(-x * y) * Math.Pow(x, 2) + 20 * z + (10 * Math.PI - 3)/3
                });

                return F;
            }
        }

        // Funcion que devuelve el Jacobiano
        // de una matriz evaluada en un 
        // vector que contiene los valores de
        // las variables (x, y, z).
        static Matriz J(Vector v) {
            // Se obtienen los valores de las variables
            // del vector que es recibido como parametro.
            double x = v.vector[0];
            double y = v.vector[1];
            double z = v.vector[2];

            Matriz J;

            // Se obtendrá una evaluacion de acuerdo al 
            // sistema que el usuario haya seleccionado.
            if(op.Equals("1")) {
                // Se definen los valores de la matriz
                J = new Matriz(new double[,]{
                    {18 * x, 72 * y, 8 * z},
                    {2 * x, -4 * y, -20},
                    {2 * x, -2 * y, 2 * z}
                });

                return J;
            } else {
                // Se definen los valores de la matriz
                J = new Matriz(new double[,]{
                    {3, z * Math.Sin(y * z), y * Math.Sin(y * z)},
                    {8 * x, 2-1250 * y, 0},
                    {2 * x * Math.Exp(-x * y) - Math.Pow(x, 2) * y * 
                     Math.Exp(-x * y), Math.Pow(-x, 3) * Math.Exp(-x * y), 20}
                });

                return J;
            }
        }

        // Implementacion del metodo de Gauss-Jacobi
        // Recibe como parametros la tolerancia a
        // considerar y el numero de iteraciones.
        static void GaussJacobi(string sistema, double tol_, int n) {

            Matriz m = System(sistema);
            Vector Iniciales = VectorResultados(sistema);

            Matriz resultados = new Matriz(4, 1);

            double tol = tol_, error = 100, sumaError;
            int Iteraciones = n;
            int itr = 0;
            
            Vector ceros = new Vector("{ 0, 0, 0, 0 }");


            //Matrices que guardan los resultados

            Matriz matrizDominante = new Matriz(4, 4);
            Matriz superior = new Matriz(4, 4);
            Matriz inferior = new Matriz(4, 4);
            Matriz MatrizC = new Matriz(4, 4);
            Matriz MatrizDiagonal = new Matriz(4, 4);
            Matriz Diagonal = new Matriz(4, 4);
            Matriz D = new Matriz(4, 4);

            Vector Resultados = new Vector(4);
            Vector Operacion1 = new Vector(4);
            Vector Operacion2 = new Vector(4);
            Vector Operacion3 = new Vector(4);
            Vector Final = new Vector(4);
            Vector xnew = new Vector(4);

            Console.WriteLine("Matriz original");

            m.Print();

            matrizDominante = Matriz.Dominante(m);

            Console.WriteLine("Matriz dominante");

            matrizDominante.Print();

            Console.WriteLine("Matriz resultados");

            Iniciales.Print();

            superior = Matriz.TriangularSuperior(matrizDominante);

            inferior = Matriz.TriangularInferior(matrizDominante);

            MatrizC = Matriz.Add(superior, inferior);

            MatrizDiagonal = Matriz.DiagonalNormal(matrizDominante);

            D = Matriz.Sub(MatrizDiagonal, matrizDominante);

            Diagonal = Matriz.Diagonal(matrizDominante);

            for (int i = 0; i < 4; i++)
            {
                Resultados.vector[i] = ceros.vector[i];
            }

            Operacion1 = Matriz.Mult(Diagonal, Iniciales);

            Operacion2 = Matriz.Mult(D, Resultados);

            Operacion3 = Matriz.Mult(Diagonal, Operacion2);

            Final = Vector.Add(Operacion3, Operacion1);

            Console.WriteLine("\n -- Iteración 1 -- ");

            Final.Print();

            itr = 1;

            while(error > tol && itr < Iteraciones)
            {
                xnew = Final;

                Operacion2 = Matriz.Mult(D, Final);

                Operacion3 = Matriz.Mult(Diagonal, Operacion2);

                Final = Vector.Add(Operacion3, Operacion1);

                Console.Write("\n -- Iteración "+(itr+1)+" -- ");
                Console.Write("\nValores finales: ");
                Console.WriteLine();

                Final.Print();

                itr++;

                sumaError = 0;
                for(int i = 0; i < 4; i++)
                {
                    sumaError += Math.Pow((Final.vector[i] - xnew.vector[i]),2);
                }

                error = Math.Sqrt(sumaError);

                Console.Write("\nError de: " + error);
                Console.WriteLine("\n");
            }
        }


        static Vector NewtonRaphson(Vector p0_, double tol) {
            double dist = 1; // Distancia inicial
            Vector p0 = p0_; // Vector inicial
            int i = 0;
            
            //Console.Write($"\nVector inicial = ");
            //p0.Print();
            //Console.WriteLine("Tolerancia = " + tol);
            
            while(dist > tol) {
                //  Inverse(J(P0)) * f(p0)
                Vector aux = Matriz.Mult(Matriz.Inverse(J(p0)), F(p0));
                // Se calcula el siguiente vector (p1)
                // p1 = p0 - Inverse(J(P0)) * f(p0)
                Vector p1 = Vector.Sub(p0, aux);

                //Console.Write($"\np[{i}] = ");
                //p1.Print();
                
                // Se calcula la distancia entre los dos
                // vectores [p1, p0]
                dist = Vector.Dist(p1, p0);

                //Console.WriteLine("\nError: " + dist);

                // Se intercambian valores para la siguiente
                // aproximacion
                p0 = p1;
                i++;
            }

            // Al terminar el ciclo, se muestra el error obtenido
            // y la funcion devuelve el vector con los valores
            // de las variables (x, y, z).
            Console.WriteLine("\nError: " + dist);
            return p0;
        }
    }
}
