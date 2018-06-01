using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour {

    public float speed = 0.05f;
    private int runden = 0;
    public Text rundenDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += transform.forward * vertical * speed;
        transform.Rotate(transform.up * horizontal);
        //Debug.Log(vertical);
	}

    private void OnTriggerEnter(Collider collider)
    {
        runden++;
        rundenDisplay.text = "Runden: " + runden;
        //Debug.Log("Collision detected");
    }
}
