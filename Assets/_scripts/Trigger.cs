using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour {

	public GameObject note;


	// Use this for initialization
	void Start () 
	{
		if (gameObject.name.Equals ("Note1")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().TriggerOne ();
		}
		if (gameObject.name.Equals ("EmptyCups")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().itemsFound += 1;
		}
		if (gameObject.name.Equals ("Plant")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().itemsFound += 1;
		}
		if (gameObject.name.Equals ("PlantBook")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().itemsFound += 1;
		}
		if (gameObject.name.Equals ("LaundryMail")) {
			GameObject.Find ("GameController").GetComponent<GameHandler> ().FaxMachine (note);
		}
		if (gameObject.name.Equals ("Note2")) {
			Data.control.Scene2 = true;
			SceneManager.LoadScene("SceneTwo");
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
