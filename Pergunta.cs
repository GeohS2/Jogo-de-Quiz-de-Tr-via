using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Quiz_de_Trívia
{
    public class Pergunta
    {
        public string Texto { get; set; }
        public List<string> OpcoesResposta { get; set; }
        public int RespostaCorreta { get; set; }

        public Pergunta (string texto,  List<string> opcoesResposta, int respostaCorreta)
        {
            Texto = texto;
            OpcoesResposta = opcoesResposta;
            RespostaCorreta = respostaCorreta;
        }
    }
}
