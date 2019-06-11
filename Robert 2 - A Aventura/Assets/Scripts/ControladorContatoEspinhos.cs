using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorContatoEspinhos : MonoBehaviour {
    public float valorForca;

    public Image img;

    private void Start()
    {
        valorForca = 25;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 ForcaRetracao = new Vector3(-valorForca, 0, -valorForca);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(ForcaRetracao, ForceMode.Impulse);

			ControladorRobert2.vidas--;

            Color alfa = img.color;
            alfa.a = 0.7f;
            img.color = alfa;
        }
    }
}
