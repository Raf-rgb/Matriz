using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
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

                }else if (op == 2)
                {

                }
                else if (op == 3) 
                {
                    v = false;
                } 
            }
        }
    }
}
