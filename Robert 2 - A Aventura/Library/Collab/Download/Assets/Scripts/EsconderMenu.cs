using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderMenu : MonoBehaviour {

    public GameObject menu;

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            MudarEstado();

        }
	}

    public void MudarEstado()
    {
        menu.SetActive(!menu.activeSelf);
        if (menu.activeSelf)
            Time.timeScale = 1;
        else
            Time.timeScale = 0;
    }
}
