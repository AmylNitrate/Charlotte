using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {

	public bool indicatorOn;
	[SerializeField] public FirstPersonController fps;
	public bool inspecting;
	public GameObject thisObject, indicator, JournalPanel;

	// Use this for initialization
	void Start () 
	{

		indicatorOn = false;
		fps = GameObject.FindGameObjectWithTag ("Player").GetComponent<FirstPersonController> ();
		inspecting = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (indicatorOn) 
		{
			if (Input.GetButtonDown ("Space")) 
			{

				if (inspecting == false) 
				{
					if (gameObject.tag.Equals ("Object")) 
					{
						fps.yes = false;
						indicator.SetActive (false);
						//gameObject.GetComponent<MeshRenderer> ().enabled = false;
						JournalPanel.SetActive(true);
						thisObject.SetActive (true);
						inspecting = true;
					} 
					else if (gameObject.tag.Equals ("Collectable")) 
					{
						thisObject.SetActive (true);
						Destroy (gameObject);
					} 

					
				} 
				else if (inspecting == true) 
				{
					fps.yes = true;
					//gameObject.GetComponent<MeshRenderer> ().enabled = true;
					JournalPanel.SetActive(false);
					Destroy (gameObject);
					inspecting = false;
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
