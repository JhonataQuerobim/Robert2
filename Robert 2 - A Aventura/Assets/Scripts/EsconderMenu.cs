using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsconderMenu : MonoBehaviour {

    public GameObject menu;

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && !ControladorRobert2.flag)
        {
            MudarEstado();

        }
	}

    public void MudarEstado()
    {
        menu.SetActive(!menu.activeSelf);
        if (menu.activeSelf)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}
