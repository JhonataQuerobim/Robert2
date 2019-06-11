﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudançaDeFaseTutorial : MonoBehaviour {

    void Update()
    {
        if (GameObject.Find("Raio").activeSelf && (GameObject.FindGameObjectWithTag("Player").transform.position.x >= (this.transform.position.x - 2)) && (GameObject.FindGameObjectWithTag("Player").transform.position.x <= (this.transform.position.x + 2)) && (GameObject.FindGameObjectWithTag("Player").transform.position.z >= (this.transform.position.z - 2)) && (GameObject.FindGameObjectWithTag("Player").transform.position.z <= (this.transform.position.z + 2)))
            if (EstruturaDeDado.Estrutura.EstaVazia)
                Application.LoadLevel((Application.loadedLevel)+1);
    }
}
