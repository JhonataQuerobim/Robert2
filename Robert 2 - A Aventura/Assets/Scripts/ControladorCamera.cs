using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamera : MonoBehaviour {

    public GameObject player;
    public float vel_rotacao;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        float rotX = Input.GetAxis("Mouse X") * vel_rotacao * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * vel_rotacao*5 * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, rotX);
        //transform.RotateAround(Vector3.left, rotY);
        transform.Rotate(new Vector3(-rotY,0,0));
        transform.position = player.transform.position + offset;
	}
}
