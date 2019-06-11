using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetaVidas : MonoBehaviour {

	void Start () {
        ControladorRobert2.vidas = 5;
        ControladorRobert2.tempo = 150;
        Time.timeScale = 1;
    }
	
}
