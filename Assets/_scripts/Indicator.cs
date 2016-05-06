using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {

	public bool indicatorOn;
	[SerializeField] public FirstPersonController fps;
	public bool inspecting;
	public GameObject thisObject, indicator, MainPanel;

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
						MainPanel.SetActive(true);
						//JournalPanel.SetActive(true);
						thisObject.SetActive (true);
						inspecting = true;
					} 
					if (gameObject.tag.Equals ("Collectable")) 
					{
						thisObject.SetActive (true);
						Destroy (gameObject);
					} 
					if (gameObject.tag.Equals ("Cups")) 
					{
						fps.yes = false;
						thisObject.SetActive (true);
					}
					if (gameObject.tag.Equals ("Phone")) {
						fps.yes = false;
						GameObject.Find ("GameController").GetComponent<GameHandler> ().Call000 ();
						GameObject.FindGameObjectWithTag ("Player").GetComponent<Darkness> ().timer = 5000;
					}

					
				} 
				else if (inspecting == true) 
				{
					fps.yes = true;
					//gameObject.GetComponent<MeshRenderer> ().enabled = true;
					MainPanel.SetActive(false);
					//JournalPanel.SetActive(false);
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
