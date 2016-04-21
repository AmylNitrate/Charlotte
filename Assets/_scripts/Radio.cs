using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour {

	public AudioClip radio;
	public AudioSource radiosource;

	public bool canPlay, indicatorOn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canPlay) 
		{
			radiosource.PlayOneShot (radio);
			canPlay = false;
		}
		if (indicatorOn) {
			if (Input.GetButtonDown ("Space")) {
				if (radiosource.isPlaying) {
					radiosource.Stop ();
				} else if (!radiosource.isPlaying) {
					radiosource.PlayOneShot (radio);
				}
			}
		}
	}

	void OnTriggerEnter()
	{
		//turn indicator on
		indicatorOn = true;
	}

}
