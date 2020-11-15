# Matriz
Librería para operaciones con matrices

## Creando matrices
La matriz por defecto estará inicializada en cero (la matriz estará llena de ceros)

```c#
  // Creando una matriz de 3 filas x 4 columnas
  Matriz m = new Matriz(3, 4);
```

Matriz cuadrada 

```c#
  // Creando una matriz cuadrada 3 filas x 3 columnas
  Matriz m = new Matriz(3);
```

### Imprimiendo una matriz

```c#
  // Creando una matriz cuadrada 3 filas x 3 columnas
  Matriz m = new Matriz(3);
  
  //Mostrando en consola todos los valores de la matriz
  m.Print();
 
  // Resultado:
  // 0  0  0
  // 0  0  0
  // 0  0  0
```

### Inicializando una matriz

```c#
  Matriz m = new Matriz(new double[,] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
  });
  
  m.Print();
  
  // Resultado:
  // 1  2  3
  // 4  5  6
  // 7  8  9
```

Llenando una matriz

```c#
  Matriz matriz = new Matriz(3);
  
  for(int i = 0; i < matriz.m; i++) {
    for(int j = 0; j < matriz.n; j++) {
      Console.Write($"Ingrese el valor [{i}, {j}] = ");
      double valor = Convert.ToDouble(Console.ReadLine());
      
      matriz.append(i, j, valor);
    }
  }
```

### Suma de matrices

Para sumar los valores de una matriz B a una matriz A:

```c#
  Matriz A = new Matriz({
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  Matriz B = new Matriz({
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  // Se suman los valores de B a los valores de A
  A.Sumar(B);
  A.Print();
  
  // Resultado:
  // 3  3  3
  // 3  3  3
  // 3  3  3
```

Para sumar dos matrices y obtener una matriz como resultado:

```c#
  Matriz A = new Matriz({
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  Matriz B = new Matriz({
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  // Matriz que guardará el resultado de la suma
  Matriz C = new Matriz(3);
  
  // Se suman las matrices A y B, y se guarda el resultado en
  // la matriz C.
  C.Sumar(A, B);
  C.Print();
  
  // Resultado:
  // 3  3  3
  // 3  3  3
  // 3  3  3
```
