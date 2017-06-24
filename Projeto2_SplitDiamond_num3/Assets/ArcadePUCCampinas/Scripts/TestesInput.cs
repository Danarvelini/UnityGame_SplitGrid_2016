/* Enric Llagostera <http://enric.llagostera.com.br> */

using UnityEngine;
using ArcadePUCCampinas;

public class TestesInput : MonoBehaviour
{
    #region Public fields

    public EControle botao;

    #endregion

    #region Class members

    #endregion

    #region Unity methods

    void Start()
    {
    }

    void Update()
    {
        //print("HORIZONTAL " + Input.GetAxis("HORIZONTAL0") + " VERTICAL " + Input.GetAxis("VERTICAL0"));
        print("BOTAO " + InputArcade.Apertado(0, EControle.DIREITA));
    }

    #endregion

    #region Private methods

    #endregion
}
