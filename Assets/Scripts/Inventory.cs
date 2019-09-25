using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> playerItems = new List<Item>();
    [SerializeField]
    private UIInventory inventoryUI;
    ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
    }

    private void Start()
    {
        AddItem(1);
        AddItem(2);
        AddItem(4);
        AddItem(4);
        AddItem(4);
        AddItem(4);
        AddItem(5);
        AddItem(5);
        AddItem(5);
        AddItem(5);
    }
    public void AddItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

    public void AddItem(string name)
    {
        Item itemToAdd = itemDatabase.GetItem(name);
        inventoryUI.AddItemToUI(itemToAdd);
        playerItems.Add(itemToAdd);
    }

    public Item CheckForItem(int id)
    {
        return playerItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            playerItems.Remove(itemToRemove);
        }
        else
        {
            Debug.Log("Can't find the item");
        }
    }
}
