using UnityEngine;
using System.Collections;

public class paintingActive : MonoBehaviour {

	float counter;
 	GameObject painting;

	// Use this for initialization
	void Start () {

		painting = GameObject.Find ("ArtFrame");
		counter = 15f;
		painting.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		counter -= Time.deltaTime;
		if (counter <= 0)
		{
			painting.SetActive(true);
		}
	}
}
