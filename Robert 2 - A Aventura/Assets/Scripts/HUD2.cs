using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD2 : MonoBehaviour
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
            GUI.DrawTexture(new Rect((float)((Screen.width * (0.99)) - (NossaHUD.width * (0.00043) * Screen.height)), (float)(Screen.height * (0.01)), (float)(NossaHUD.width * (0.00043) * Screen.height), (float)(NossaHUD.height * (0.00035) * Screen.height)), NossaHUD);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Tardis")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000126) * Screen.height))), (float)((Screen.height * (0.046))), (float)(Textura[0].width * (0.0001) * Screen.height), (float)(Textura[0].height * (0.0001) * Screen.height)), Textura[0]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Sorvete")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.0001525) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[1].width * (0.0001) * Screen.height), (float)(Textura[1].height * (0.0001) * Screen.height)), Textura[1]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Sanduiche")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.0001875) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[2].width * (0.0001) * Screen.height), (float)(Textura[2].height * (0.0001) * Screen.height)), Textura[2]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Maleta")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000234) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[3].width * (0.0001) * Screen.height), (float)(Textura[3].height * (0.0001) * Screen.height)), Textura[3]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Game_Boy")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000273) * Screen.height))), (float)((Screen.height * (0.047))), (float)(Textura[4].width * (0.0001) * Screen.height), (float)(Textura[4].height * (0.0001) * Screen.height)), Textura[4]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Cone")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000304) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[5].width * (0.0001) * Screen.height), (float)(Textura[5].height * (0.0001) * Screen.height)), Textura[5]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Celular")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.000332) * Screen.height))), (float)((Screen.height * (0.051))), (float)(Textura[6].width * (0.00037) * Screen.height), (float)(Textura[6].height * (0.00037) * Screen.height)), Textura[6]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("Envelope")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.0003715) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[7].width * (0.0001) * Screen.height), (float)(Textura[7].height * (0.0001) * Screen.height)), Textura[7]);
            if (!EstruturaDeDado.Estrutura.EstaNaLista(GameObject.Find("TV")))
                GUI.DrawTexture(new Rect((float)(((Screen.width * (0.99)) - (NossaHUD.width * (0.00042) * Screen.height))), (float)((Screen.height * (0.048))), (float)(Textura[8].width * (0.0001) * Screen.height), (float)(Textura[8].height * (0.0001) * Screen.height)), Textura[8]);
        }
    }
}
