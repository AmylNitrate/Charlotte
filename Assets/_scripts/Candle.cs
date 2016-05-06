using UnityEngine;
using System.Collections;

public class Candle : MonoBehaviour 
{
	public bool indicatorOn;
	public GameObject flames, wic, indicator;
	// Use this for initialization
	void Start () 
	{
		indicatorOn = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (indicatorOn) 
		{
			if (Input.GetButtonDown ("Space")) 
			{
				if (Data.control.Matches > 0) 
				{
					Data.control.Matches--;
					GameObject.Find ("Inventory").GetComponent<Inventory> ().UseItem (0);
					flames.SetActive (true);
					wic.SetActive (true);
					GameObject.FindGameObjectWithTag("Player").GetComponent<Darkness>().timer = 10;
				} 
				else if (Data.control.Matches <= 0) 
				{
					Debug.Log ("NO MATCHES");
				}
			}
		}
		if (GameObject.FindGameObjectWithTag ("Player").GetComponent<Darkness> ().timer <= 0) {
			flames.SetActive (false);
			wic.SetActive (false);
		}
	}

	void OnTriggerEnter()
	{
		indicator.SetActive (true);
		indicatorOn = true;

	}

	void OnTriggerExit()
	{
		indicator.SetActive (false);
		indicatorOn = false;
	}
}
