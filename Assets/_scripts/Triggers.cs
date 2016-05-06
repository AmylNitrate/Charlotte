using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour {

	public GameObject torch, note, upstairscol, _bloodstain, cups, j3;
	public AudioSource bloodstain;
	public AudioClip car;

	// Use this for initialization
	void Start () 
	{
		if (gameObject.name.Equals ("familyPortrait")) 
		{
			torch.SetActive (true);
			GameObject.Find ("Radio").GetComponent<Radio> ().canPlay = true;
		}
		if (gameObject.name.Equals ("SpellingToys")) {
			_bloodstain.SetActive (true);
			bloodstain.PlayOneShot (car);
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
		if (gameObject.name.Equals ("JournalEntry2")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().FaxMachine (note);
		}
		if (gameObject.name.Equals ("Note4")) {
			cups.SetActive (true);
			j3.SetActive (true);
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
