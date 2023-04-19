using System;

namespace PII_Game_Of_Life
{
    public class TableroCompleto
    {
        public bool[,] tablero{get; set;}
        public TableroCompleto(bool[,] tablero)
        {
            this.tablero=tablero;
        }
        public int getWidth()
        {
            return this.tablero.GetLength(1);
        }
    
        public int getHeight()
        {
            return this.tablero.GetLength(2);
        }

        public static void Play(TableroCompleto gameboard, int boardHeight, int boardWidth)
        {
            throw new NotImplementedException();
        }

        public void Play(int boardHeight, int boardWidth)
        {
            throw new NotImplementedException();
        }
    }
}
