using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ArcadePUCCampinas
{
    public class ArcadeJogo : Singleton<ArcadeJogo>
    {
        private bool _noMenu;
        private int _contador;
        private Transform _menu;
        public Text _txtContador;

        void Awake()
        {
            InputArcade.Inicializar();
            Screen.fullScreen = true;
            Cursor.visible = false;
            Application.runInBackground = true;
            _noMenu = false;
            _menu = transform.FindChild("Menu");
            _menu.gameObject.SetActive(false);
        }

        void Update()
        {
            if (!_noMenu)
            {
                if (InputArcade.Apertou(0, EControle.MENU))
                {
                    StartCoroutine(MostrarMenu());
                }    
            }
            else
            {
                // se pressionar de novo, sai do jogo
                if (InputArcade.Apertou(0, EControle.MENU))
                {
                    print("saiu");
                    Application.Quit();
                }
            }

        }

        void LateUpdate()
        {
            InputArcade.Atualizar();
        }

        IEnumerator MostrarMenu()
        {
            // mostra menu e pausa o tempo do jogo
            _noMenu = true;
            _contador = 5;
            _menu.gameObject.SetActive(true);
            Time.timeScale = 0;
            _txtContador.text = _contador.ToString();
            // contagem regressiva para voltar ao jogo
            yield return new WaitForSecondsRealtime(1f);
            _contador--;
            _txtContador.text = _contador.ToString();
            yield return new WaitForSecondsRealtime(1f);
            _contador--;
            _txtContador.text = _contador.ToString();
            yield return new WaitForSecondsRealtime(1f);
            _contador--;
            _txtContador.text = _contador.ToString();
            yield return new WaitForSecondsRealtime(1f);
            _contador--;
            _txtContador.text = _contador.ToString();
            yield return new WaitForSecondsRealtime(1f);
            // se o fluxo chegou aqui, religa o tempo e esconde o menu
            Time.timeScale = 1;
            _noMenu = false;
            _menu.gameObject.SetActive(false);
        }
    }
}