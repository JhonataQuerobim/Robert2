using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{

    public GameObject[] ObjetosCertos;
    public Texture2D NossaHUD;
    public Texture2D[] Textura;
    void Start()
    {
        EstruturaDeDado.Estrutura = new Lista<GameObject>();
        ObjetosCertos = GameObject.FindGameObjectsWithTag("ObjetoCerto");
        for (int i = 0; i < ObjetosCertos.Length; i++)
        {
            EstruturaDeDado.Estrutura.Insere(ObjetosCertos[i]);
        }
    }

    private void OnGUI()
    {
        if (!ControladorRobert2.flag)
        {
            GUI.DrawTexture(new Rect((float)((Screen.width * (0.99)) - (NossaHUD.width * (0.00035) * Screen.height)), (float)(Screen.height * (0.01)), (float)(NossaHUD.width * (0.00035) * Screen.height), (float)(NossaHUD.height * (0.00035) * Screen.height)), NossaHUD);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Guarda_Chuva")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000128) * Screen.height))), (float)((Screen.height * (0.067))), (float)(Textura[0].width * (0.00033) * Screen.height), (float)(Textura[0].height * (0.00033) * Screen.height)), Textura[0]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Coco")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000168) * Screen.height))), (float)((Screen.height * (0.058))), (float)(Textura[1].width * (0.00030) * Screen.height), (float)(Textura[1].height * (0.00036) * Screen.height)), Textura[1]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Concha")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000217) * Screen.height))), (float)((Screen.height * (0.075))), (float)(Textura[2].width * (0.0004) * Screen.height), (float)(Textura[2].height * (0.00045) * Screen.height)), Textura[2]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Castelo")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000248) * Screen.height))), (float)((Screen.height * (0.059))), (float)(Textura[3].width * (0.00045) * Screen.height), (float)(Textura[3].height * (0.00035) * Screen.height)), Textura[3]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Bola")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000288) * Screen.height))), (float)((Screen.height * (0.065))), (float)(Textura[4].width * (0.00033) * Screen.height), (float)(Textura[4].height * (0.00033) * Screen.height)), Textura[4]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Boia")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000338) * Screen.height))), (float)((Screen.height * (0.077))), (float)(Textura[5].width * (0.0004) * Screen.height), (float)(Textura[5].height * (0.0004) * Screen.height)), Textura[5]);
        }
    }
}
