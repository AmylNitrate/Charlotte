using UnityEngine;
using System.Collections;

public class LightSources : MonoBehaviour {

	public bool indicatorOn;
	public bool inspecting;
	public GameObject indicator;

	// Use this for initialization
	void Start () 
	{

		indicatorOn = false;
		inspecting = false;

	}

	// Update is called once per frame
	void Update () 
	{
		if (indicatorOn) 
		{
			if (Input.GetButtonDown ("Space")) 
			{
				if (gameObject.tag.Equals ("Battery")) 
				{
					GameObject.Find ("Inventory").GetComponent<Inventory> ().AddItem (1);
					Data.control.Batteries++;
					Destroy (gameObject);
				} 
				else if (gameObject.tag.Equals ("Match")) 
				{
					GameObject.Find ("Inventory").GetComponent<Inventory> ().AddItem (0);
					Data.control.Matches++;
					Destroy (gameObject);

				} 
			}
		}
	}

	void OnTriggerEnter()
	{
		indicator.SetActive (true);
		indicatorOn = true;

	}

	void OnTriggerExit()
	{
		indicator.SetActive (false);
		indicatorOn = false;
	}
}
