using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

	public GameObject studyMail, portrait, hateMail, Newspaper, fallenPortrait;
	public AudioSource faxsource;
	public AudioClip fax;

	Text textRef1;

	public int itemsFound;

	// Use this for initialization
	void Start () {

		textRef1 = GameObject.Find ("Info").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (itemsFound == 3) 
		{
			TriggerTwo ();
			itemsFound = 0;
		}
	}

	public void FaxMachine(GameObject paper)
	{
		paper.SetActive (true);
		faxsource.PlayOneShot (fax);

	}

	public void TriggerOne()
	{
		//Audio(door open)
		//studyMail.SetActive (true);
		textRef1.text = "";
		GameObject.Find ("StudyDoor").GetComponent<Door> ().OpenDoor(120);
	}
		 

	public void TriggerTwo()
	{
		//Audio(door open)
		GameObject.Find ("LaundryDoor").GetComponent<Door> ().OpenDoor (100);

	}

	public void TriggerThree()
	{
		//Audio(change atmosphere)
		hateMail.SetActive(true);
		Newspaper.SetActive (true);
		Debug.Log ("did the thing");
	}
	public void TriggerFour()
	{
		//Audio(porttrait smash)
		fallenPortrait.SetActive(true);
	}

}
