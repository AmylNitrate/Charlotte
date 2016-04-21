using UnityEngine;
using System.Collections;

public class CandleRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit()
	{
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Darkness> ().timer = 0;
	}
}
