using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class JournalData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public JItem jitem;
    public int Amount;

    private JToolTip jtooltip;


    void Start()
    {
        jtooltip = GameObject.Find("Journal").GetComponent<JToolTip>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        jtooltip.Activate(jitem);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        jtooltip.Deactivate();
    }


}
