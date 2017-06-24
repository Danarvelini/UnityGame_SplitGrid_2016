using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgAleatorio : MonoBehaviour
{
    public Material skybox;
    public float intervaloMin;
    public float intervaloMax;
    public float fator;
    private Color corAlvo1, corAlvo2;
    private float escala;

    IEnumerator Start()
    {
        escala = 1;
        while (enabled)
        {
            yield return new WaitForSecondsRealtime(Random.Range(intervaloMin, intervaloMax));
            corAlvo1 = Random.ColorHSV(0, 1, 0.9f, 1f);
            corAlvo2 = Random.ColorHSV(0, 1, 0.9f, 1f);
            escala = Random.Range(1f, 1.3f);
        }
    }

    void Update()
    {
        skybox.SetColor("_Color1", Color.Lerp(skybox.GetColor("_Color1"), corAlvo1, Time.deltaTime * fator));
        skybox.SetColor("_Color2", Color.Lerp(skybox.GetColor("_Color2"), corAlvo2, Time.deltaTime * fator));
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * escala, Time.deltaTime * fator);
    }
}
