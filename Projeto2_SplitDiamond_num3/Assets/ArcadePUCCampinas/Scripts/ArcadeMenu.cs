using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;
using System;


namespace ArcadePUCCampinas
{
    public class ArcadeMenu : Singleton<ArcadeMenu>
    {
        public bool bloquear;
        private string _urlGeral;
        public IdJogo[] listaIds;
        public List<JogoInfo> infosJogos;
        public List<JogoMenu> jogosMenu;
        public int ativo;
        private float _fade;
        public SpriteRenderer fadeOut;
        private bool _abrindoJogo;

        void Awake()
        {
            InputArcade.Inicializar();
            infosJogos = new List<JogoInfo>();
            jogosMenu = new List<JogoMenu>();
            Screen.fullScreen = true;
            Cursor.visible = false;
            Application.runInBackground = true;
            _urlGeral = "file://" + Application.streamingAssetsPath; 
            Color atual = Color.black;
            atual.a = 0f;
            fadeOut.color = atual;
            _abrindoJogo = false;
        }

        IEnumerator Start()
        {
            /*
            var path = Path.Combine(_urlGeral, "listaJogos.json");
            Debug.Log(path);
            var data = File.ReadAllText(path, System.Text.Encoding.UTF8);
            Debug.Log(data);
            */

            WWW jsonData = new WWW(Path.Combine(_urlGeral, "listaJogos.json"));
            yield return jsonData;
            listaIds = ListaJogos.CarregarJson(jsonData.text).jogos;
            foreach (var jogo in listaIds)
            {
                WWW jsonJogo = new WWW(Path.Combine(_urlGeral, jogo.id_jogo + "/infos.json"));
                yield return jsonJogo;
                var infoJogo = JogoInfo.CarregarJson(jsonJogo.text);
                infosJogos.Add(infoJogo);
                CriarJogoMenu(infoJogo);
            }
            ativo = UnityEngine.Random.Range(0, jogosMenu.Count);
            jogosMenu[ativo].Entrar();
        }

        void CriarJogoMenu(JogoInfo info)
        {
            var jogoMenu = GameObject.Instantiate(Resources.Load<JogoMenu>("JogoMenu"), transform);
            jogoMenu.gameObject.name = info.id_jogo;
            jogoMenu.id_jogo = info.id_jogo;
            jogoMenu.StartCoroutine(jogoMenu.CarregarCapa(Path.Combine(_urlGeral, info.id_jogo + "/" + info.urlCapa)));
            jogoMenu.CarregarDescricao(info);
            jogosMenu.Add(jogoMenu);
        }

        void Update()
        {
            if (!bloquear && (InputArcade.Apertou(0, EControle.CIMA) || InputArcade.Apertou(1, EControle.CIMA)))
            {
                bloquear = true;
                jogosMenu[ativo].Sair();
                ativo++;
                if (ativo >= jogosMenu.Count)
                {
                    ativo = 0;
                }
                jogosMenu[ativo].Entrar();
            }

            if (!bloquear && (InputArcade.Apertou(0, EControle.BAIXO) || InputArcade.Apertou(1, EControle.BAIXO)))
            {
                bloquear = true;
                jogosMenu[ativo].Sair();
                ativo--;
                if (ativo < 0)
                {
                    ativo = jogosMenu.Count - 1;
                }
                jogosMenu[ativo].Entrar();
            }

            if (!bloquear && (InputArcade.Apertou(0, EControle.VERDE) || InputArcade.Apertou(1, EControle.VERDE)))
            {
                bloquear = true;
                _abrindoJogo = true;
                StartCoroutine(AbrirJogo());
            }

            if (_abrindoJogo)
            {
                Color atual = fadeOut.color;
                atual.a += Time.deltaTime * 2f;
                fadeOut.color = atual;
            }
        }

        void LateUpdate()
        {
            InputArcade.Atualizar();
        }

        IEnumerator AbrirJogo()
        {
            UnityEngine.Debug.Log("PROCESS NAME: " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            yield return new WaitForSecondsRealtime(2f);
            Camera.main.GetComponent<AudioListener>().enabled = false;
            var path = Path.Combine(Application.streamingAssetsPath, jogosMenu[ativo].id_jogo + "/" + jogosMenu[ativo].id_jogo + ".exe");
            try
            {
                Process processo = new Process();
                processo.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                processo.StartInfo.CreateNoWindow = false;
                processo.StartInfo.UseShellExecute = false;
                processo.StartInfo.FileName = path;
                processo.EnableRaisingEvents = true;
                //processo.Exited += new EventHandler(ProcessoSaiu);
                processo.Start();
                processo.WaitForExit();
                _abrindoJogo = false;
                Color atual = Color.black;
                atual.a = 0f;
                fadeOut.color = atual;
                bloquear = false;
            }
            catch (Exception e)
            {
                print(e);        
            }
        }
    }
}
