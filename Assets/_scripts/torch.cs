using UnityEngine;
using System.Collections;

public class torch : MonoBehaviour {

	public float time;
	public GameObject torchLight;
	public bool lettherebelight;

	// Use this for initialization
	void Start () 
	{
		lettherebelight = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;

		if (lettherebelight) {
			torchLight.SetActive (true);
			GameObject.FindGameObjectWithTag("Player").GetComponent<Darkness>().timer = 30;
			time = 30;
			lettherebelight = false;
		}

		if (Input.GetKey (KeyCode.B)) 
		{
			if (Data.control.Batteries > 0) 
			{
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Darkness> ().timer = 30;
				torchLight.SetActive (true);
				time = 30;
				Data.control.Batteries--;
			}
		}

		if (time < 0) 
		{
			torchLight.SetActive (false);
			lettherebelight = false;
		}

	}
}
