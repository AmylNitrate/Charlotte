﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour {

	public Item item;
	private string data;
	private GameObject tooltip;

	void Start()
	{
		tooltip = GameObject.Find("ToolTip");
		tooltip.SetActive (false);
	}

	void Update()
	{
		if (tooltip.activeSelf) 
		{
			tooltip.transform.position = Input.mousePosition;
		}
	}

	public void Activate(Item item)
	{
		this.item = item;
		ConstructDataString ();
		tooltip.SetActive (true);
	}

	public void Deactivate()
	{
		tooltip.SetActive (false);
	}
	public void ConstructDataString()
	{
		data = item.Title + "\nDescription: " + item.Desc;
        tooltip.transform.GetChild (0).GetComponent<Text> ().text = data;
	}
}
