using UnityEngine;
using System.Collections;

public class Phone : MonoBehaviour {

	public AudioClip call;
	public AudioSource phonesource;

	public bool canPlay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (canPlay) 
		{
			phonesource.PlayOneShot (call);
		}
	}


}
