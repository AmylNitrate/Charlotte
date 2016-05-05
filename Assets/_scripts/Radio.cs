using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour {

	public AudioClip radio;
	public AudioSource radiosource;

	public bool canPlay, indicatorOn;

	public GameObject indicator;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canPlay) 
		{
			radiosource.PlayOneShot (radio);
			canPlay = false;
		}
		if (indicatorOn) 
		{
			if (Input.GetButtonDown ("Space")) 
			{
				if (radiosource.isPlaying) {
					radiosource.Stop ();
					GameObject.Find ("FrontDoor").GetComponent<Door> ().OpenDoor (120);

				} 
			}
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
