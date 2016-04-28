using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Journal : MonoBehaviour
{
//    JournalDatabase jDatabase;
    GameObject JournalPanel;
//    GameObject jSlotPanel;
//    public GameObject journalSlot;
//    public GameObject journalItem;
//
//    int slotAmount;
//    public List<JItem> items = new List<JItem>();
//    public List<GameObject> slots = new List<GameObject>();
//
    public bool journalOpen;
//
    void Start()
    {
//
//        jDatabase = GetComponent<JournalDatabase>();
//        slotAmount = 2;
        JournalPanel = GameObject.Find("JournalPanel");
//        jSlotPanel = JournalPanel.transform.FindChild("jSlotPanel").gameObject;
//
//        for (int i = 0; i < slotAmount; i++)
//        {
//            items.Add(new JItem());
//            slots.Add(Instantiate(journalSlot));
//            slots[i].transform.SetParent(jSlotPanel.transform);
//        }
//
        JournalPanel.SetActive(false);
        journalOpen = false;
//
//
   }

    void Update()
    {
            if(Input.GetKeyDown(KeyCode.I))
            {
                if (!journalOpen)
                {
                    JournalPanel.SetActive(true);
                    journalOpen = true;
                }
                else
                {
                    JournalPanel.SetActive(false);
                    journalOpen = false;
                }

            }

        

    }

//    public void AddItem(int id)
//    {
//        JItem itemToAdd = jDatabase.FetchItemByID(id);
//
//            for (int i = 0; i < items.Count; i++)
//            {
//
//                if (items[i].ID == -1)
//                {
//                    items[i] = itemToAdd;
//                    GameObject itemObj = Instantiate(journalItem);
//                    itemObj.GetComponent<JournalData>().jitem = itemToAdd;
//                    itemObj.GetComponent<JournalData>().Amount = 1;
//                    itemObj.transform.SetParent(slots[i].transform);
//                    itemObj.transform.position = slots[i].transform.position;
//                    itemObj.GetComponent<Image>().sprite = itemToAdd.Icon;
//                    itemObj.name = itemToAdd.Title;
//
//                    break;
//                }
//            }
//
//    }
//
//    //this function checks is an item is already in the inventory
//    bool Check(JItem item)
//    {
//        for (int i = 0; i < items.Count; i++)
//        {
//            if (items[i].ID == item.ID)
//            {
//                return true;
//            }
//        }
//        return false;
//    }
}
