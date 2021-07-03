using System;

namespace JogoDaVelha.controller
{
    class Controller
    {
        private string[,] marcacoes;
        private bool xoro;
        public Controller()
        {
            xoro = true;
            this.marcacoes = new string[3, 3];
            this.Tabuleiro();
        }

        private void Tabuleiro()
        {

            Console.WriteLine("  1  2  3 ");
            Console.WriteLine($"A {marcacoes[0, 0]} | {marcacoes[0, 1]}  | {marcacoes[0, 2]} ");
            Console.WriteLine(" ----------");
            Console.WriteLine($"B {marcacoes[1, 0]} | {marcacoes[1, 1]}  | {marcacoes[1, 2]} ");
            Console.WriteLine(" ----------");
            Console.WriteLine($"C {marcacoes[2, 0]} | {marcacoes[2, 1]}  | {marcacoes[2, 2]}  ");
            this.Selecionar();

        }

        private void Marcar(int i, int j)
        {
            if (string.IsNullOrEmpty(marcacoes[i, j]))
            {
                if (xoro)
                {
                    marcacoes[i, j] = "X";
                    FimDeJogo("X");

                }
                else
                {
                    marcacoes[i, j] = "O";
                    FimDeJogo("O");
                }
                xoro = !xoro;
            }
            else
            {
                Console.WriteLine("casa já selecionada");
            }
            Tabuleiro();
        }

        private void FimDeJogo(string x)
        {
            if ((marcacoes[0, 0] == x && marcacoes[0, 1] == x && marcacoes[0, 2] == x) || (marcacoes[1, 0] == x && marcacoes[1, 1] == x && marcacoes[1, 2] == x) || (marcacoes[2, 0] == x && marcacoes[2, 1] == x && marcacoes[2, 2] == x) || (marcacoes[0, 0] == x && marcacoes[1, 0] == x && marcacoes[2, 0] == x) || (marcacoes[1, 0] == x && marcacoes[1, 1] == x && marcacoes[1, 2] == x) || (marcacoes[2, 0] == x && marcacoes[0, 1] == x && marcacoes[0, 2] == x) || (marcacoes[0, 0] == x && marcacoes[1, 1] == x && marcacoes[2, 2] == x) || (marcacoes[0, 2] == x && marcacoes[1, 1] == x && marcacoes[2, 0] == x))
            {
                MsgDeVitoria(x);
            }
        }

        private void MsgDeVitoria(string x)
        {
            Console.WriteLine($"{x} ganhou o jogo!");
            Console.WriteLine("Iniciando novo jogo...");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            marcacoes = new string[3, 3];
            xoro = false;
        }

        private void Selecionar()
        {
            Console.WriteLine("Diga qual casa deseja escolher:");
            string selecao = Console.ReadLine();

            switch (selecao.ToUpper())
            {
                case "A1":
                    Marcar(0, 0);
                    break;
                case "A2":
                    Marcar(0, 1);
                    break;
                case "A3":
                    Marcar(0, 2);
                    break;
                case "B1":
                    Marcar(1, 0);
                    break;
                case "B2":
                    Marcar(1, 1);
                    break;
                case "B3":
                    Marcar(1, 2);
                    break;
                case "C1":
                    Marcar(2, 0);
                    break;
                case "C2":
                    Marcar(2, 1);
                    break;
                case "C3":
                    Marcar(2, 2);
                    break;
                default:
                    Console.WriteLine("digite um valor válido.");
                    Selecionar();
                    break;
            }
        }
    }
}
