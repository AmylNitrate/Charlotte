using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelTimer : MonoBehaviour {

	float counter;
	// Use this for initialization
	void Start () {
		
		counter = 45f;
	}
	
	// Update is called once per frame
	void Update () {
		
		counter -= Time.deltaTime;
		if (counter <= 0)
		{
			if (Data.control.Scene2 == false) {
				SceneManager.LoadScene ("SceneOne");
			}
			if (Data.control.Scene2 == true) {
				SceneManager.LoadScene ("SceneTwo");
			}
		}
	}
}
