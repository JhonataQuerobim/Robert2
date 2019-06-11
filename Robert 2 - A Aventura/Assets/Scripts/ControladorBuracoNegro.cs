using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBuracoNegro : MonoBehaviour {

    public GameObject azul;
    public GameObject vermelho;
    public GameObject camera;
    public int estado;
    public float distancia;
    public float timerAzul;
    public float timerVermelho;
    public float dt;

    public AudioSource source;
    public AudioClip somBuraco;
    public AudioClip entrandoBuraco;
    public AudioClip carregandoBuraco;

    public Image img;
    public Text texto;

	// Use this for initialization
	void Start () {
        estado = 0;
        azul.SetActive(false);
        vermelho.SetActive(false);

        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        float tempo;
        tempo = Time.time;

        float rot = camera.transform.rotation.eulerAngles.y * Mathf.Deg2Rad;
        Vector3 movimento = new Vector3(distancia * Mathf.Sin(rot), 0.0f, distancia * Mathf.Cos(rot));

        Color tex = texto.color;
        if (tex.a > 0)
            tex.a = tex.a - 0.00875f;
        texto.color = tex;

        

        if (Input.GetKeyDown("x"))
        {           
            if(tempo > timerAzul)
            {
                if (estado == 00)
                    estado = 01;
                else
                    estado = 11;
                timerAzul = tempo + dt;
                
                azul.transform.position = transform.position + movimento + new Vector3(0, 2, 0);
                azul.transform.eulerAngles = new Vector3(0, camera.transform.rotation.eulerAngles.y + 90, 90);
                azul.SetActive(true);

                source.PlayOneShot(somBuraco, 0.7f);

            }
            else
            {
                string resposta = "Tempo para recarregar: " + (timerAzul - tempo).ToString("F2") + " segundos";
                texto.text = resposta;

                source.PlayOneShot(carregandoBuraco, 1);

                Color bt = texto.color;
                bt = Color.blue;
                bt.a = 1;
                texto.color = bt;
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (tempo > timerVermelho)
            {
                if (estado == 00)
                    estado = 10;
                else
                    estado = 11;

                timerVermelho = tempo + dt;

                vermelho.transform.position = transform.position + movimento + new Vector3(0, 2, 0);
                vermelho.transform.eulerAngles = new Vector3(0, camera.transform.rotation.eulerAngles.y + 90, 0);
                vermelho.SetActive(true);

                source.PlayOneShot(somBuraco, 0.7f);
            }
            else
            {
                string resposta = "Tempo para recarregar: " + (timerVermelho - tempo).ToString("F2") + " segundos";
                texto.text = resposta;

                source.PlayOneShot(carregandoBuraco, 1);

                Color bt = texto.color;
                bt = Color.red;
                bt.a = 1;
                texto.color = bt;
            }
        }

        Color alfa = img.color;
        if (alfa.a > 0)
            alfa.a = alfa.a - 0.01f;
        img.color = alfa;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "BuracoAzul" & estado==11)
        {
            source.PlayOneShot(entrandoBuraco, 1);
            Vector3 be = vermelho.transform.position + new Vector3(5, 0, 0);
            be.y = transform.position.y;
            transform.position = be;

            Color alfa = img.color;
            alfa.a = 1;
            img.color = alfa;
        }

        if (collision.gameObject.tag == "BuracoVermelho" & estado == 11)
        {
            source.PlayOneShot(entrandoBuraco, 1);
            Vector3 be = azul.transform.position + new Vector3(5, 0, 0);
            be.y = transform.position.y;
            transform.position = be;

            Color alfa = img.color;
            alfa.a = 1;
            img.color = alfa;
        }
    }
}
