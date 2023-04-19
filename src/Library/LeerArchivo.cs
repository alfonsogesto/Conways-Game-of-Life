using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace archivo
{
    public class LeerArch
    {
       public static bool[,] AbrirTablero(string url)
       {
        string content=File.ReadAllText(url);
        string[] contentlines=content.Split("\n");
        bool[,] tablero = new bool [contentlines.Length, contentlines[0].Length];
        for (int  y=0; y<contentlines.Length;y++)
        {
            for (int x=0; x<contentlines[y].Length; x++)
            {
                 if(contentlines[y][x]=='1')
                 {
                    tablero[x,y]=true;
                 }
  
            }

        }

        return tablero;
       }

    }
}