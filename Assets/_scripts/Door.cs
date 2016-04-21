using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door : MonoBehaviour {

	public float _speed;
	public iTween.EaseType curve;
	public bool _doorReady;
	public GameObject note;

	public bool unlocked, faxTriggered, isOpen;

	public int doorCurveAmount;


	Text textRef1;
	//public AudioClip m_doorsound;
	//public AudioSource audiosource;

	// Use this for initialization
	void Start () 
	{
		_speed = 2f;
		textRef1 = GameObject.Find ("Info").GetComponent<Text> ();
	}

	public void Update () 
	{
		if (_doorReady) 
		{
			if (!isOpen) 
			{
				if (unlocked) 
				{
					textRef1.text = "";

					if (Input.GetKeyDown (KeyCode.Space)) 
					{
						OpenDoor (doorCurveAmount);
						//audiosource.clip = openDoor;
					}
					
				}
				else if (!unlocked) 
				{
					if (Input.GetKeyDown (KeyCode.Space)) 
					{
						textRef1.text = "Door Locked";
						//audiosource.clip = lockedDoor;
						if (!faxTriggered) 
						{
							GameObject.Find ("GameController").GetComponent<GameHandler> ().FaxMachine (note);
							faxTriggered = true;
						}
					}
				}
			}
		}
	}
	
	void OnTriggerEnter()
	{
		_doorReady = true;
	}
	
	void OnTriggerExit()
	{
		_doorReady = false;
	}

	public void OpenDoor(int curveAmount)
	{
		//door creep audio
		iTween.RotateTo (gameObject, iTween.Hash ("rotation", new Vector3 (0, curveAmount, 0), "time", _speed, "easetype", curve));
		isOpen = true;
	}
	

}
