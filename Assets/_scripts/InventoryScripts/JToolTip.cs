using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JToolTip : MonoBehaviour
{

    public JItem jitem;
    private string data;
    private GameObject jtooltip;

    void Start()
    {
        jtooltip = GameObject.Find("JToolTip");
        jtooltip.SetActive(false);
    }

    void Update()
    {
        if (jtooltip.activeSelf)
        {
            jtooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(JItem jitem)
    {
        this.jitem = jitem;
        ConstructDataString();
        jtooltip.SetActive(true);
    }

    public void Deactivate()
    {
        jtooltip.SetActive(false);
    }
    public void ConstructDataString()
    {
        data = jitem.Title + "\nDescription: " + jitem.Desc;
        jtooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
