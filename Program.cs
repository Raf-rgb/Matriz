using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] funciones = new string[] 
            {
                "7x-2y+1z+2w = 3",
                "2x+8y+3z+1w = -2",
                "-1x+0y+5z+2w = 5",
                "0x+2y-1z+4w = 4",
                "",
                "0x+3y-1z+8w = 15",
                "2x-1y+10z-1w = 11",
                "-1x+11y-2z+3w = 6",
                "10x-1y+2z+0w = 6",
                "",
                "2x+8y+3z+1w = -2",
                "0x+2y-1z+4w = 4",
                "7x-2y+1z+2w = 3",
                "-1x+0y+5z+2w = 5",
            };
            bool v = true;
            int op = 0;
            while (v)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine(" (1) Sistema de Ecuaciones Lineales");
                Console.WriteLine(" (2) Sistema de Ecuaciones no Lineales");
                Console.WriteLine(" (3) Salir del sistema");
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception error)
                {
                    Console.WriteLine("ha ocurrido un erro "+error.Message);
                }
                if (op == 1)
                {
                    Console.WriteLine("--Menu Sistemas de ecuaciones Lineales--");
                    Console.WriteLine(" (1) ");
                    Console.WriteLine($"{funciones[0]}");
                    Console.WriteLine($"{funciones[1]}");
                    Console.WriteLine($"{funciones[2]}");
                    Console.WriteLine($"{funciones[3]}");
                    Console.WriteLine(" (2) ");
                    Console.WriteLine($"{funciones[5]}");
                    Console.WriteLine($"{funciones[6]}");
                    Console.WriteLine($"{funciones[7]}");
                    Console.WriteLine($"{funciones[8]}");
                    Console.WriteLine(" (3) ");
                    Console.WriteLine($"{funciones[10]}");
                    Console.WriteLine($"{funciones[11]}");
                    Console.WriteLine($"{funciones[12]}");
                    Console.WriteLine($"{funciones[13]}");
                    try{
                        op = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception error){
                        Console.WriteLine("ha ocurrido un erro "+error.Message);
                    }
                    if (op >= 1 || op <= 3) {
                        funcionesLineales(op);
                        Console.WriteLine("--Menu Metodo de Solucion--");
                        Console.WriteLine(" (1) Gauss-Jacobi");
                        Console.WriteLine(" (1) Gauss-Seidel");
                        try{
                            op = Convert.ToInt32(Console.ReadLine());
                        }catch(Exception error){
                            Console.WriteLine("ha ocurrido un erro "+error.Message);
                        }
                        if (op == 1){

                        }else{
                            
                        }
                    }
                }else if (op == 2){

                }else if (op == 3){
                    v = false;
                }
            }
        }
        static void funcionesLineales(int op)
        {     
            if (op == 1){
                Matriz m = new Matriz(new double[,] {
                    {7, -2, 1, 2},
                    {2, 8, 3, 1},
                    {-1, 0, 5, 2},
                    {0, 2, -2, 4}
                });
                m.Print();
            }else if (op == 2){
                
                Matriz m = new Matriz(new double[,] {
                    {0, 3, -1, 8},
                    {2, -1, 10, -1},
                    {-1, 11, -2, 3},
                    {10, -1, 2, 0}
                });
                m.Print();
            }else if (op == 3){
                Matriz m = new Matriz(new double[,] {
                    {2, 8, 3, 1},
                    {0, 2, -1, 4},
                    {7, -2, 1, 2},
                    {-1, 0, 5, 2}
                });
                m.Print();
            }            
        }
    }
}
