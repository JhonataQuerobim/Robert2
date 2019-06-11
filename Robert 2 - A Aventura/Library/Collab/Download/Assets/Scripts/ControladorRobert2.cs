using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorRobert2 : MonoBehaviour
{
    public float velocidade;
    public GameObject camera;
    public GameObject raio;

    private float rotX;
    private Rigidbody rb;

    public static float tempo = 100;
    public static int vidas = 5;

    public Slider sliderVidas;
    public Image imgSliderVidas;
    public Image imgVidas;
    public Image img;

    public float timer;
    public float tempoUso;

    public RawImage[] BoostImages;

    private float varImg = 0;

    private AudioSource source;

    public AudioClip hitParede;
    public AudioClip raioAbdutor;

    public GameObject gameover;
    public AudioClip somDerrota;
    public bool somDerrotaTocando = false;

    public Text TextoTimer;

    public static bool flag = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        tempoUso = 0;
        if (timer == 0)
            timer = 10;

        source = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        tempo -= Time.deltaTime;
	    if(tempo > 0 && vidas > 0)
		    TextoTimer.text = "Tempo restante: " + tempo.ToString("F2") + " segundos";
	    else
		    TextoTimer.text = " ";
        if (tempo > 0 && vidas > 0)
        {
            if (Input.GetKey(KeyCode.Space) || Controla_Raio.flag)
            {
                raio.SetActive(true);
                source.PlayOneShot(raioAbdutor, 0.2f);
            }
            else
                raio.SetActive(false);
            if (raio.activeSelf == false)
            {
                float moveHorizontal = Input.GetAxis("Vertical");
                float moveVertical = Input.GetAxis("Horizontal");
                rotX = camera.transform.rotation.eulerAngles.y * Mathf.Deg2Rad;
                Vector3 movimento = new Vector3(moveHorizontal * Mathf.Sin(rotX), 0.0f, moveHorizontal * Mathf.Cos(rotX));
                Vector3 movimento2 = new Vector3(moveVertical * Mathf.Cos(rotX), 0.0f, moveVertical * -1 * Mathf.Sin(rotX));
                rb.AddForce((movimento + movimento2) * velocidade);
            }
        }

        else
        {
            gameover.SetActive(true);
            flag = true;
            if (somDerrotaTocando == false)
                source.PlayOneShot(somDerrota, 1);
            somDerrotaTocando = true;
        }
            

        Color corImgVidas = imgVidas.color;
        Color corSliderVidas = imgSliderVidas.color;

        if (sliderVidas.value > vidas)
        {
            sliderVidas.value -= Time.deltaTime * 2;
            corSliderVidas.a = 1;
            corImgVidas.a = 1;
        }
        else
        {
            //Debug.Log("Vida nao caindo" + corSliderVidas.a.ToString());

            sliderVidas.value = vidas;
            if(corImgVidas.a > 0.2f & vidas>1)
            {
                corSliderVidas.a = corSliderVidas.a - 0.015f;
                corImgVidas.a = corSliderVidas.a - 0.015f;
            }
            if(vidas==1)
            {
                varImg += 0.1f;
                corImgVidas.a = Mathf.Cos(varImg) * 0.6f + 0.4f;
                corSliderVidas.a = Mathf.Cos(varImg) * 0.6f + 0.4f;
            }

            
        }

        imgVidas.color = corImgVidas;
        imgSliderVidas.color = corSliderVidas;


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Time.time > tempoUso + timer)
            {
                tempoUso = Time.time;
                rotX = camera.transform.rotation.eulerAngles.y * Mathf.Deg2Rad;
                Vector3 movimento = new Vector3(1 * Mathf.Sin(rotX), 0.0f, 1 * Mathf.Cos(rotX));
                rb.AddForce(movimento * velocidade * 5, ForceMode.Impulse);
            }
            else
            {
                
            }
        }

        ColorirUp((Time.time - tempoUso)*100/ timer);

        Color alfa = img.color;
        if (alfa.a > 0)
            alfa.a = alfa.a - 0.015f;
        img.color = alfa;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Espinho")
        {
            Vector3 espinho = new Vector3(-500, 0, -500);
            rb.AddForce(espinho);

	        vidas--;
            source.PlayOneShot(hitParede, 0.4f);

            Color alfa = img.color;
            alfa.a = 0.7f;
            img.color = alfa;
        }

        if (col.gameObject.tag == "Cenário")
            source.PlayOneShot(hitParede, 0.4f);
    }

    void ColorirUp(float porcent)
    {
        //Debug.Log(porcent.ToString());
        Color aux;
        int u = (int)(porcent / 10);
        for(int i = 0; i < 11; i++)
        {
            aux = BoostImages[i].color;
            aux.a = 0;
            if (u == i)
                aux.a = 0.8f;

            if(u > 10 & i == 10)
                aux.a = 0.8f;

            BoostImages[i].color = aux;
        }
    }
}
