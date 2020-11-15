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

Mostrando todos los valores de la matriz

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

Mostrando un valor en la posicion (i, j)

```c#
  // Creando una matriz cuadrada 3 filas x 3 columnas
  Matriz m = new Matriz(3);
  
  //Mostrando en consola el valor en la posicion (0, 0)
  m.Get(0, 0);
 
  // Resultado:
  // 0
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
  
  for(int i = 0; i < matriz.rows; i++) {
    for(int j = 0; j < matriz.columns; j++) {
      Console.Write($"Ingrese el valor [{i}, {j}] = ");
      double valor = Convert.ToDouble(Console.ReadLine());
      
      matriz.Append(i, j, valor);
    }
  }
```

### Suma de matrices

Para sumar los valores de una matriz B a una matriz A:

```c#
  Matriz A = new Matriz(new double[,]{
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  Matriz B = new Matriz(new double[,]{
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  // Se suman los valores de B a los valores de A
  A.Add(B);
  A.Print();
  
  // Resultado:
  // 3  3  3
  // 3  3  3
  // 3  3  3
```

Para sumar dos matrices y obtener una matriz como resultado:

```c#
  Matriz A = new Matriz(new double[,]{
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  Matriz B = new Matriz(new double[,]{
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  // Matriz que guardará el resultado de la suma
  Matriz C = new Matriz(3);
  
  // Se suman las matrices A y B, y se guarda el resultado en
  // la matriz C.
  C = Matriz.Add(A, B);
  C.Print();
  
  // Resultado:
  // 3  3  3
  // 3  3  3
  // 3  3  3
```

### Restando matrices

Para restar los valores de una matriz B a una matriz A:

```c#
  Matriz A = new Matriz(new double[,]{
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  Matriz B = new Matriz(new double[,]{
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  // Se restan los valores de B a los valores de A
  A.Sub(B);
  A.Print();
  
  // Resultado:
  // 1  1  1
  // 1  1  1
  // 1  1  1
```

Para sumar dos matrices y obtener una matriz como resultado:

```c#
  Matriz A = new Matriz(new double[,]{
    {2, 2, 2},
    {2, 2, 2},
    {2, 2, 2}
  });
  
  Matriz B = new Matriz(new double[,]{
    {1, 1, 1},
    {1, 1, 1},
    {1, 1, 1}
  });
  
  // Matriz que guardará el resultado de la resta
  Matriz C = new Matriz(3);
  
  // Se restan las matrices A y B, y se guarda el resultado en
  // la matriz C.
  C = Matriz.Sub(A, B);
  C.Print();
  
  // Resultado:
  // 1  1  1
  // 1  1  1
  // 1  1  1
```

### Multiplicando matrices

Para multiplicar dos matrices y obtener una matriz como resultado:

```c#
  Matriz A = new Matriz(new double[,]{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
  });
  
  Matriz B = new Matriz(new double[,]{
    {1, 0, 0},
    {0, 1, 0},
    {0, 0, 1}
  });
  
  // Matriz que guardará el resultado de la multiplicación
  Matriz C = new Matriz(3);
  
  // Se multiplican las matrices A y B, y se guarda el resultado en
  // la matriz C.
  C = Matriz.Mult(A, B);
  C.Print();
  
  // Resultado (multiplicar una matriz A por una matriz identidad B, es equivalente a multiplicar cada elemento de la matriz A por 1):
  // 1  2  3
  // 4  5  6
  // 7  8  9
```
