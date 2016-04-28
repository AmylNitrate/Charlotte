using UnityEngine;
using System.Collections;

public class torch : MonoBehaviour {

	public float time;

	// Use this for initialization
	void Start () 
	{

		time = GameObject.FindGameObjectWithTag("Player").GetComponent<Darkness>().timer = 30;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (time < 0) 
		{
			gameObject.SetActive (false);
		}

	}
}
