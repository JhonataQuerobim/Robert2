using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGiroEspinhos : MonoBehaviour {

    public float varTempo;
    public float velocidade;
    public float frequencia;
    public bool sentidoHorario;

    private void Start()
    {
        varTempo = 0;
        velocidade = 5;
        frequencia = 4;
    }
    // Update is called once per frame
    void Update () {
        varTempo += Time.deltaTime;

        Vector3 rotacao = new Vector3(funcaoQtdGiro()*velocidade, 0, 0);

        if (sentidoHorario)
            rotacao *= -1;

        transform.Rotate(rotacao);
	}

    float funcaoQtdGiro()
    {
        /*float alfa = Mathf.Pow((varTempo - 0.001f), 2)/6;
        float saida = Mathf.Exp(-alfa) / (3 * Mathf.Sqrt(2 * Mathf.PI));
        return saida;*/

        float alfa = varTempo / frequencia * Mathf.PI;
        float beta = Mathf.Sin(alfa);
        float saida = Mathf.Abs(beta)/2 + 0.25f;
        return saida;
    }
}
