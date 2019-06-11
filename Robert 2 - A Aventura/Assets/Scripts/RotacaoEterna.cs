using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoEterna : MonoBehaviour {

    private Rigidbody corpo;
    public float velocidade;

	// Use this for initialization
	void Start () {
        corpo = GetComponent<Rigidbody>();
        if (velocidade == 0)
            velocidade = 5;
	}
	
	// Update is called once per frame
	void Update () {
        corpo.transform.Rotate(Vector3.up * Time.deltaTime * velocidade);
	}
}
