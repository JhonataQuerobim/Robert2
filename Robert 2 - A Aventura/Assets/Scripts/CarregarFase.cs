using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarFase : MonoBehaviour
{

    public void LoadByIndex(int sceneIndex)
    {
        if (sceneIndex < 4)
        {
            ControladorRobert2.vidas = 5;
            ControladorRobert2.tempo = 150;
        }
        else
        {
            ControladorRobert2.vidas = 5;
            ControladorRobert2.tempo = 250;
        }
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1;
    }
}
