using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ArcadePUCCampinas
{
    public enum EControle
    {
        CIMA,
        DIREITA,
        BAIXO,
        ESQUERDA,
        VERDE,
        VERMELHO,
        AMARELO,
        AZUL,
        BRANCO,
        PRETO,
        MENU
    }

    public enum EEixo
    {
        HORIZONTAL,
        VERTICAL
    }

    public static class InputArcade
    {
        private static Dictionary<EControle, bool[]> antes;
        private static Dictionary<EControle, bool[]> atual;

        public static void Inicializar()
        {
            antes = new Dictionary<EControle, bool[]>();
            atual = new Dictionary<EControle, bool[]>();

            antes[EControle.CIMA] = new bool[2];
            antes[EControle.DIREITA] = new bool[2];
            antes[EControle.BAIXO] = new bool[2];
            antes[EControle.ESQUERDA] = new bool[2];
            antes[EControle.VERDE] = new bool[2];
            antes[EControle.VERMELHO] = new bool[2];
            antes[EControle.AMARELO] = new bool[2];
            antes[EControle.AZUL] = new bool[2];
            antes[EControle.BRANCO] = new bool[2];
            antes[EControle.PRETO] = new bool[2];
            antes[EControle.MENU] = new bool[2];

            atual[EControle.CIMA] = new bool[2];
            atual[EControle.DIREITA] = new bool[2];
            atual[EControle.BAIXO] = new bool[2];
            atual[EControle.ESQUERDA] = new bool[2];
            atual[EControle.VERDE] = new bool[2];
            atual[EControle.VERMELHO] = new bool[2];
            atual[EControle.AMARELO] = new bool[2];
            atual[EControle.AZUL] = new bool[2];
            atual[EControle.BRANCO] = new bool[2];
            atual[EControle.PRETO] = new bool[2];
            atual[EControle.MENU] = new bool[2];
        }

        public static void Atualizar()
        {
            for (int i = 0; i < 2; i++)
            {
                antes[EControle.CIMA][i] = atual[EControle.CIMA][i];
                antes[EControle.DIREITA][i] = atual[EControle.DIREITA][i];
                antes[EControle.BAIXO][i] = atual[EControle.BAIXO][i];
                antes[EControle.ESQUERDA][i] = atual[EControle.ESQUERDA][i];
                antes[EControle.VERDE][i] = atual[EControle.VERDE][i];
                antes[EControle.VERMELHO][i] = atual[EControle.VERMELHO][i];
                antes[EControle.AMARELO][i] = atual[EControle.AMARELO][i];
                antes[EControle.AZUL][i] = atual[EControle.AZUL][i];
                antes[EControle.BRANCO][i] = atual[EControle.BRANCO][i];
                antes[EControle.PRETO][i] = atual[EControle.PRETO][i];
                antes[EControle.MENU][i] = atual[EControle.MENU][i];

                atual[EControle.CIMA][i] = Consultar(i, EControle.CIMA);
                atual[EControle.DIREITA][i] = Consultar(i, EControle.DIREITA);
                atual[EControle.BAIXO][i] = Consultar(i, EControle.BAIXO);
                atual[EControle.ESQUERDA][i] = Consultar(i, EControle.ESQUERDA);
                atual[EControle.VERDE][i] = Consultar(i, EControle.VERDE);
                atual[EControle.VERMELHO][i] = Consultar(i, EControle.VERMELHO);
                atual[EControle.AMARELO][i] = Consultar(i, EControle.AMARELO);
                atual[EControle.AZUL][i] = Consultar(i, EControle.AZUL);
                atual[EControle.BRANCO][i] = Consultar(i, EControle.BRANCO);
                atual[EControle.PRETO][i] = Consultar(i, EControle.PRETO);
                atual[EControle.MENU][i] = Consultar(i, EControle.MENU);
            }
        }

        public static bool Apertou(int jogador, EControle input)
        {
            return (antes[input][jogador] == false) && (atual[input][jogador] == true);
        }

        public static bool Soltou(int jogador, EControle input)
        {
            return (antes[input][jogador] == true) && (atual[input][jogador] == false);
        }

        public static bool Apertado(int jogador, EControle input)
        {
            return atual[input][jogador];
        }

        public static float Eixo(int jogador, EEixo eixo)
        {
            switch (eixo)
            {
                case EEixo.HORIZONTAL:
                    {
                        return Input.GetAxis("HORIZONTAL" + jogador);
                    }
                case EEixo.VERTICAL:
                    {
                        return Input.GetAxis("VERTICAL" + jogador);
                    }
                default :
                    {
                        return 0;
                    }
            }
        }

        private static bool Consultar(int jogador, EControle input)
        {
            switch (input)
            {
                case EControle.MENU:
                    {
                        return Input.GetButton("MENU");
                    }
                case EControle.CIMA:
                    {
                        return Input.GetAxis("VERTICAL" + jogador) > 0f;
                    }
                case EControle.BAIXO:
                    {
                        return Input.GetAxis("VERTICAL" + jogador) < 0f;
                    }
                case EControle.DIREITA:
                    {
                        return Input.GetAxis("HORIZONTAL" + jogador) > 0f;
                    }
                case EControle.ESQUERDA:
                    {
                        return Input.GetAxis("HORIZONTAL" + jogador) < 0f;
                    }
                default:
                    return Input.GetButton(input.ToString() + jogador);
            }
        }
    }
}

