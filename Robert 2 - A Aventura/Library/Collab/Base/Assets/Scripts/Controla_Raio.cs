using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controla_Raio : MonoBehaviour {
    public GameObject player;
    public static bool flag = false;
    private Vector3 offset;
	public Image img;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ObjetoCerto") || other.CompareTag("ObjetoErrado"))
        {
            this.transform.position = player.transform.position + offset;
            flag = true;
            other.transform.position = new Vector3(transform.position.x, other.transform.position.y + (Time.deltaTime * 5) * other.transform.localScale.y, transform.position.z);
            other.transform.Rotate(new Vector3(180, 180, 180) * Time.deltaTime);
            other.transform.localScale = new Vector3(0.9f * other.transform.localScale.x, 0.9f * other.transform.localScale.y, 0.9f * other.transform.localScale.z);
            if (other.transform.localScale.x < 0.05)
            {
				if (other.CompareTag ("ObjetoCerto"))
					HUD.Estrutura.Remove (other.gameObject);
				else if (other.CompareTag ("ObjetoErrado")) 
				{
					ControladorRobert2.vidas--;
					Color alfa = img.color;
					alfa.a = 0.7f;
					img.color = alfa;
				}
                other.gameObject.SetActive(false);
                other.gameObject.transform.position = new Vector3(other.transform.position.x, 6, other.transform.position.z);
                flag = false;
            }
        }
    }
}
