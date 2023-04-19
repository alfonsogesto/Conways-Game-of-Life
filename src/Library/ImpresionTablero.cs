using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using PII_Game_Of_Life;

namespace gameBoard
{
    public class ImpresionTablero
    {
        public static bool[,] Play(PII_Game_Of_Life.TableroCompleto gameboard, int boardHeight, bool[,] tablero)
        {
        bool[,] b=tablero;                                          
        int width=b.GetLength(0);                                   
        int height=b.GetLength(0);                              
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y< height;y++)
        {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
           
            Thread.Sleep(300);
    
        }

     }

        public static void Play(TableroCompleto gameboard, int boardHeight, int boardWidth)
        {
            throw new NotImplementedException();
        }
    }
}