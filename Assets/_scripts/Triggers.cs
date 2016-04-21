using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour {

	public GameObject torch, note, upstairscol;

	// Use this for initialization
	void Start () 
	{
		if (gameObject.name.Equals ("familyPortrait")) 
		{
			GameObject.Find ("Radio").GetComponent<Radio> ().canPlay = true;
			torch.SetActive (true);
		}
		if (gameObject.name.Equals ("bills")) {
			GameObject.Find ("FrontDoor").GetComponent<Door> ().OpenDoor(120);
		}
		if (gameObject.name.Equals ("LawnToy")) {
			//play dad dying audio
		}
		if (gameObject.name.Equals ("bloodstain")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().TriggerThree ();
		}
		if (gameObject.name.Equals ("HateMail")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().FaxMachine (note);
		}
		if (gameObject.name.Equals ("Note3")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().TriggerFour ();
		}
		if (gameObject.name.Equals ("fallenPortrait")) {
			//Audio(upstairs noise)
			Destroy(upstairscol);
		}
	}

	void Update()
	{
		if (Input.GetButtonDown ("Space")) {
			if (gameObject.activeInHierarchy == true) {
				gameObject.SetActive (false);
			}
		}
	}
}
