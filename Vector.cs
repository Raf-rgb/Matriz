using System;

namespace Matriz
{
    class Vector
    {
        public double[] vector;
        public int len;

        // Constructor que recibe el tamaño
        // de vector y crea un vector vacio.
        public Vector(int n) {
            vector = new double[n];
            len = n;
        }

        // Constructor que recibe un vector de entrada
        // como un arreglo de tipo double.
        public Vector(double[] vector_) {
            vector = vector_;
            len = vector_.Length;
        }

        // Constructor que recibe un vector de entrada
        // como string con un formato. 
        // Ejemplo: {1, 2, 3, 4}
        public Vector(string vector_) {
            vector = toVector(vector_);
            len = vector.Length;
        }

        // Funcion para sumar dos vectores
        // Devuelve el resultado de la suma.    
        public static Vector Add(Vector v1, Vector v2) {
            Vector v3 = new Vector(v1.len);

            try {
                for(int i = 0; i < v1.len; i++) v3.vector[i] = v1.vector[i] + v2.vector[i];
            } catch {
                Console.WriteLine("\nError: los vectores no tiene la misma cantidad de elementos.");
            }
            
            return v3;
        }

        // Funcion para sumar un vector al vector actual
        public void Add(Vector v) {
            if(len == v.len) {
                for(int i = 0; i < len; i++) vector[i] += v.vector[i];
            } else {
                Console.WriteLine("\nError: los vectores no tiene la misma cantidad de elementos.");
            }
        }

        // Funcion para restar dos vectores
        // Devuelve el resultado de la resta.    
        public static Vector Sub(Vector v1, Vector v2) {
            Vector v3 = new Vector(v1.len);

            try {
                for(int i = 0; i < v1.len; i++) v3.vector[i] = v1.vector[i] - v2.vector[i];
            } catch {
                Console.WriteLine("\nError: los vectores no tiene la misma cantidad de elementos.");
            }
            
            return v3;
        }

        // Funcion para restar un vector al vector actual
        public void Sub(Vector v) {
            if(len == v.len) {
                for(int i = 0; i < len; i++) vector[i] -= v.vector[i];
            } else {
                Console.WriteLine("\nError: los vectores no tiene la misma cantidad de elementos.");
            }
        }

        // Funcion para multiplicar un vector
        // (escalar un vector), devuelve el
        // producto de la multiplicacion.
        public static Vector Mult(Vector v, double c) {
            Vector v2 = new Vector(v.len);

            for(int i = 0; i < v.len; i++) v2.vector[i] = v.vector[i] * c;

            return v2;
        }

        // Funcion para multiplicar un vector
        // (escalar un vector).
        public void Mult(double c) {
            for(int i = 0; i < len; i++) vector[i] = vector[i] * c;
        }

        // Funcion para dividir un vector,
        // devuelve el producto de la 
        // multiplicacion.
        public static Vector Div(Vector v, double c) {
            Vector v2 = new Vector(v.len);

            for(int i = 0; i < v.len; i++) {
                v2.vector[i] = v.vector[i] / c;
                
                if(v2.vector[i] == -0) v2.vector[i] = 0;
            }

            return v2;
        }

        // Funcion para dividir un vector.
        public void Div(double c) {
            for(int i = 0; i < len; i++) {
                vector[i] = vector[i] / c;

                if(vector[i] == -0) vector[i] = 0;
            }
        }

        // Funcion que devuelve el producto punto de 
        // dos vectores.
        public static double DotProduct(Vector v1, Vector v2) {
            double sum = 0;

            try {
                for(int i = 0; i < v1.len; i++) sum += v1.vector[i] * v2.vector[i];
            } catch {
                Console.WriteLine("\nError: Error: los vectores no tiene la misma cantidad de elementos.");
            }
            
            return sum;
        }

        // Funcion que devuelve la distancia entre dos vectores
        public static double Dist(Vector v1, Vector v2) {
            return Math.Sqrt(DotProduct(v1, v2));
        }

        // Se convierte un vector de entrada en string
        // a un vector de tipo double para ser usado
        // en cualquier calculo.
        private double[] toVector(string s) {
            String[] elementos; // Gurada cada valor del vector
            double[] vec; // El vector resultante de la conversion

            // Se arregla el formato del vector de entrada
            // (string) para su conversion.
            s = s.Replace(" ", "");
            s = s.Replace("{", "");
            s = s.Replace("}", "");

            // Se separan los valores del vector de entrada (string)
            elementos = s.Split(",");

            // Se inicializa el vector resultante con el tamaño
            // igual a la cantidad de elementos del vector de 
            // entrada.
            vec = new double[elementos.Length];

            // Se guardan los elementos del vector de entrada (string)
            // en el vector de salida (double).
            for(int i = 0; i < elementos.Length; i++) {
                vec[i] = Convert.ToDouble(elementos[i]);
            }

            // Se devuelve el vector resultante de la conversion.
            return vec;
        }

        // Funcion para imprimir un vector en una sola
        // linea en la consola.
        public void Print() {
            Console.Write("[");
            foreach(double v in vector) Console.Write($" '{v}' ");
            Console.Write("]\n");
        }
    }
}
