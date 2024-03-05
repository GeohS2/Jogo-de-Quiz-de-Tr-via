using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Quiz_de_Trívia
{
    public class Jogo
    {
        private List<Pergunta> perguntas;
        private Random random;
        private int pontuacao;
        private Stopwatch stopwatch;

        public Jogo(List<Pergunta> perguntas)
        {
            this.perguntas = perguntas;
            random = new Random();
            pontuacao = 0;
            stopwatch = new Stopwatch();
        }

        public void IniciarJogo()
        {
            Console.WriteLine("Bem-vindo ao Jogo de Quiz de Trívia!");
            Console.WriteLine("Você terá que responder o máximo de perguntas possível em um determinado tempo de conhecimentos gerais.");
            Console.WriteLine();
            Console.WriteLine("Pronto para começar? Pressione Enter para iniciar...");
            Console.ReadLine();

            stopwatch.Start();

            foreach (var pergunta in perguntas)
            {
                ApresentarPergunta(pergunta);
            }
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();

            stopwatch.Stop();
            Console.WriteLine($"Pontuação final: {pontuacao}");
            Console.WriteLine($"Tempo total: {stopwatch.Elapsed.TotalSeconds} segundos");
            Console.WriteLine("Obrigado por jogar!");

            Console.WriteLine("Pressione Enter para sair ...");
            Console.ReadLine() ;
        }

        private void ApresentarPergunta(Pergunta pergunta)
        {
            Console.WriteLine(pergunta.Texto);

            for (int i = 0; i < pergunta.OpcoesResposta.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pergunta.OpcoesResposta[i]}");
            }

            Console.WriteLine("Escolha a opção correta: ");
            int escolha = 0;
            bool escolhaValida = false;

            //Garantir que a escolha do usuário seja válida
            while (!escolhaValida)
            {
                if(int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= pergunta.OpcoesResposta.Count)
                {
                    escolhaValida = true;
                }
                else
                {
                    Console.WriteLine("Escolha inválida. Por favor, insira novamente.");
                }
            }

            if ( escolha == pergunta.RespostaCorreta)
            {
                Console.WriteLine("Resposta correta!");
                pontuacao++;
                //Vou Adicionar efeitos sonoros e animações para resposta correta.
            }
            else
            {
                Console.WriteLine("Resposta incorreta.");
            }

            Console.WriteLine();
            Console.Clear();

        }

        private int CalcularPontuacao()
        {
            double tempoDecorrido = stopwatch.Elapsed.TotalSeconds;
            double bonusTempo = 10 - Math.Min(tempoDecorrido, 10);
            return (int)Math.Round(bonusTempo) + 1;
        }
    }
}
