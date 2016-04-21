using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour 
{
	ItemDatabase database;
	GameObject inventoryPanel;
	GameObject slotPanel;
	public GameObject inventorySlot;
	public GameObject inventoryItem;

	int slotAmount;
	public List<Item> items = new List<Item>();
	public List<GameObject> slots = new List<GameObject>();

	void Start()
	{
		database = GetComponent<ItemDatabase> ();
		slotAmount = 2;
		inventoryPanel = GameObject.Find ("InventoryPanel");
		slotPanel = inventoryPanel.transform.FindChild ("SlotPanel").gameObject;

		for (int i = 0; i < slotAmount; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate (inventorySlot));
			slots [i].transform.SetParent (slotPanel.transform);
		}

    }

    public void AddItem(int id)
	{
		Item itemToAdd = database.FetchItemByID (id);

		if (itemToAdd.Stackable && Check (itemToAdd)) 
		{
			for (int i = 0; i < items.Count; i++) 
			{
				if (items [i].ID == id) 
				{
					ItemData data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
					data.Amount++;
					data.transform.GetChild (0).GetComponent<Text> ().text = data.Amount.ToString ();
					break;
				}
			}
		} 
		else 
		{
			for (int i = 0; i < items.Count; i++) 
			{

				if (items [i].ID == -1) 
				{
					items[i] = itemToAdd;
					GameObject itemObj = Instantiate (inventoryItem);
					itemObj.GetComponent<ItemData> ().item = itemToAdd;
					itemObj.GetComponent<ItemData> ().Amount = 1;
					itemObj.transform.SetParent (slots [i].transform);
					itemObj.transform.position = slots[i].transform.position;
					itemObj.GetComponent<Image> ().sprite = itemToAdd.Icon;
					itemObj.name = itemToAdd.Title;

					break;
				}
			}
		}
			
	}

	//this function checks is an item is already in the inventory
	bool Check(Item item)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (items[i].ID == item.ID) 
			{
				return true;
			}
		}
		return false;
	}
}
