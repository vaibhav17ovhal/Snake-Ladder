﻿using Snake_Ladder;
using System;

namespace SnakeLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder game");
            Play start = new Play();
            start.DieRoll();
            start.Game();
        }
    }
}
    
