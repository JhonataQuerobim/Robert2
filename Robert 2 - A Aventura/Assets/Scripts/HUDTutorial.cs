using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDTutorial : MonoBehaviour
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
            GUI.DrawTexture(new Rect((float)((Screen.width * (0.99)) - (NossaHUD.width * (0.00048) * Screen.height)), (float)(Screen.height * (0.01)), (float)(NossaHUD.width * (0.00048) * Screen.height), (float)(NossaHUD.height * (0.00035) * Screen.height)), NossaHUD);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Cubo")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000327) * Screen.height))), (float)((Screen.height * (0.029))), (float)(Textura[0].width * (0.000285) * Screen.height), (float)(Textura[0].height * (0.000285) * Screen.height)), Textura[0]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Capsula")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000453) * Screen.height))), (float)((Screen.height * (0.029))), (float)(Textura[1].width * (0.000285) * Screen.height), (float)(Textura[1].height * (0.000285) * Screen.height)), Textura[1]);
        }
    }
}
