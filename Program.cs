using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Quiz_de_Trívia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pergunta> perguntas = new List<Pergunta>
            {
               new Pergunta("Qual é a capital do Brasil?", new List<string> { "Rio de Janeiro", "São Paulo", "Brasília", "Salvador" }, 3),
               new Pergunta("Quem escreveu 'Dom Quixote'?", new List<string> { "Miguel de Cervantes", "William Shakespeare", "Charles Dickens", "Homer" }, 1),
               new Pergunta("Qual é o planeta mais próximo do Sol?", new List<string> { "Marte", "Vênus", "Mercúrio", "Júpiter" }, 3),
               new Pergunta("De quem é a famosa frase “Penso, logo existo”?", new List<string> { "Platão",  "Galileu Galilei", "Descartes", "Sócrates", "Francis Bacon" }, 3),
            };

            //Iniciar Jogo
            Jogo jogo = new Jogo (perguntas);
            jogo.IniciarJogo();
        }
    }
}
