﻿using GameTOP.lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1(),
                new Jogador2());
            jogo.IniciarJogo();
        }
    }

}
