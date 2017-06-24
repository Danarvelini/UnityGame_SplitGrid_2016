using UnityEngine;
using System;

namespace ArcadePUCCampinas
{
    [System.Serializable]
    public class JogoInfo
    {
        public string id_jogo;
        public string nome;
        public string equipe;
        public string disciplina;
        public string urlCapa;

        public static JogoInfo CarregarJson(string dados)
        {
            return JsonUtility.FromJson<JogoInfo>(dados);
        }
    }

    [System.Serializable]
    public class ListaJogos
    {
        public IdJogo[] jogos;

        public static ListaJogos CarregarJson(string dados)
        {
            return JsonUtility.FromJson<ListaJogos>(dados);
        }
    }

    [System.Serializable]
    public class IdJogo
    {
        public string id_jogo;

        public static IdJogo CarregarJson(string dados)
        {
            return JsonUtility.FromJson<IdJogo>(dados);
        }
    }
}

