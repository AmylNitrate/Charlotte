using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class ItemData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Item item;
	public int Amount;

	private ToolTip tooltip;


	void Start()
	{
		tooltip = GameObject.Find ("Inventory").GetComponent<ToolTip> ();
	}


	public void OnPointerEnter(PointerEventData eventData)
	{
		tooltip.Activate (item);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		tooltip.Deactivate ();
	}


}
