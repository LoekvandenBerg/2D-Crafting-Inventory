using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items;

    private void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
         return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "Diamond Axe", "A axe made out of diamond", 
            new Dictionary<string, int>
            {
                {"Power", 15 },
                {"Defense", 7 }
            }),
            new Item(2, "Diamond Ore", "Ore with diamonds in it",
            new Dictionary<string, int>
            {
                {"Value", 15 },
            }),
            new Item(3, "Steel Axe", "A axe made out of steel",
            new Dictionary<string, int>
            {
                {"Power", 5 },
                {"Defense", 2 }
            }),
            new Item(4, "Steel Ore", "Ore made of steel",
            new Dictionary<string, int>
            {
                {"Value", 5 },               
            }),
            new Item(5, "Arrow", "Just some wood",
            new Dictionary<string, int>
            {
                {"Value", 5 },
            }),
            new Item(6, "Fish", "Still flopping",
            new Dictionary<string, int>
            {
                {"Value", 5 },
            }),
            new Item(7, "Cooked Fish", "Yummy",
            new Dictionary<string, int>
            {
                {"Value", 10 },
            }),
        };
    }
}
