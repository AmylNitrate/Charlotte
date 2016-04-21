using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;

public class JournalDatabase : MonoBehaviour
{
    private List<JItem> jDatabase = new List<JItem>();
    private JsonData itemData;

    void Start()
    {

        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/JournalItems.json"));
        ConstructItemDatabase();

    }

    public JItem FetchItemByID(int id)
    {
        for (int i = 0; i < jDatabase.Count; i++)
        {
            if (jDatabase[i].ID == id)
            {
                return jDatabase[i];
            }
        }
        return null;
    }

    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            jDatabase.Add(new JItem((int)itemData[i]["id"], itemData[i]["title"].ToString(), itemData[i]["desc"].ToString(), itemData[i]["slug"].ToString()));
        }
    }

}
public class JItem
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public string Slug { get; set; }
    public Sprite Icon { get; set; }

    public JItem(int id, string title, string desc, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Desc = desc;
        this.Slug = slug;
        this.Icon = Resources.Load<Sprite>("Sprites/Items/" + slug);
    }

    public JItem()
    {
        this.ID = -1;
    }
}
