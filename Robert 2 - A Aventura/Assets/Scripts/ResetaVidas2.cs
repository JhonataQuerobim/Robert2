using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetaVidas2 : MonoBehaviour {
	void Start () {
        ControladorRobert2.vidas = 5;
        ControladorRobert2.tempo = 250;
        Time.timeScale = 1;
    }
}
