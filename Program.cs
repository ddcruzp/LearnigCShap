using System;

namespace LearnigCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); 

            char [,] board = new char[8,8]; 

            Inicializar(board);

            board[1,2] = 'X' ;
            board[1,6] = 'X' ;
            board[2,2] = 'X' ;
            board[4,1] = 'X' ;
            board[4,3] = 'X' ;
            board[4,6] = 'X' ;
            board[5,2] = 'X' ;
            board[5,4] = 'X' ;
            board[6,3] = 'X' ;

            PrintBoard(board); 

            ponerNumeros(board); 
        }

        public static void PrintBoard (char [,]board)
        {
            for (int i=0 ;i<board.GetLength(0);i++)
            {
                for (int j=0; j< board.GetLength(1); j++)
                {
                    System.Console.Write(board[i,j]+ " ");
                }
                System.Console.WriteLine();
            }
        }

        public static void Inicializar (char [,] board )
        {
            for (int i=0 ;i<board.GetLength(0);i++)
            {
                for (int j=0; j< board.GetLength(1); j++)
                {
                    board[i,j] = '_'; 
                }
            }
        }

        public static void ponerNumeros (char [,] board)
        {
            //Implementar esto 
        }
    }
}
