using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimentoLaser : MonoBehaviour {

    public float distMaxima;
    public bool paraBaixo = true;
    public float velocidade;
    public float posInicial;

	// Use this for initialization
	void Start () {
        if (velocidade == 0)
            velocidade = 0.1f;
        if (distMaxima == 0)
            distMaxima = 9;
        
        posInicial = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position - new Vector3(0, velocidade, 0);

        if ((transform.position.y < 2) & (velocidade > 0))
            velocidade *= -1;

        if ((transform.position.y > posInicial) & (velocidade < 0))
            velocidade *= -1;
    }
}
