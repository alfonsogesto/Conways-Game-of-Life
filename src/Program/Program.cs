using System;
using System.Text;
using System.Collections.Generic;
using System.IO;


namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            TableroCompleto gameboard = new TableroCompleto();
            int boardHeight= gameboard.getHeight();
            int boardWidth= gameboard.getWidth();
            TableroCompleto.Play(gameboard, boardHeight,boardWidth);
        }
    }
}
