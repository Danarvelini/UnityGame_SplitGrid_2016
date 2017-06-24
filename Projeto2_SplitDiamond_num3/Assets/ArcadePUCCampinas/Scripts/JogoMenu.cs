using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadePUCCampinas
{
    public class JogoMenu : MonoBehaviour
    {
        public string id_jogo;
        public Image capa;
        public Text txtTitulo;
        public Text txtDescricao;
        private Animator _anim;

        void Awake()
        {
            _anim = GetComponent<Animator>();
        }

        public IEnumerator CarregarCapa(string urlCapa)
        {
            WWW tex = new WWW(urlCapa);
            yield return tex;
            Texture2D texCapa = new Texture2D(900, 900);
            tex.LoadImageIntoTexture(texCapa);
            Sprite spriteCapa = Sprite.Create(texCapa, new Rect(0, 0, 900, 900), new Vector2(0.5f, 0.5f));
            capa.sprite = spriteCapa; 
        }

        public void CarregarDescricao(JogoInfo info)
        {
            txtTitulo.text = info.nome;
            txtDescricao.text = info.equipe + "\n\n" + info.disciplina;
        }

        public void Entrar()
        {
            _anim.SetTrigger("Entrada");
        }

        public void Sair()
        {
            _anim.SetTrigger("Saida");
        }

        public void Desbloquear()
        {
            ArcadeMenu.Instance.bloquear = false;
        }
    }

}

