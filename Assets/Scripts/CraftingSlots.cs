﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSlots : MonoBehaviour
{
    [SerializeField]
    private CraftRecipeDatabase recipeDatabase;
    private List<UIItem> uiItems = new List<UIItem>();
    [SerializeField]
    private UIItem craftResultSlot;

    private void Start()
    {
        uiItems = GetComponent<SlotPanel>().uiItems;
        uiItems.ForEach(i => i.craftingSlot = true);
    }

    public void UpdateRecipe()
    {
        int[] itemTable = new int[uiItems.Count]; 
        for(int i = 0; i < uiItems.Count; i++)
        {
            if(uiItems[i].item != null)
            {
                itemTable[i] = uiItems[i].item.id;
            }
        }
        Item itemToCraft = recipeDatabase.CheckRecipe(itemTable);
        UpdateCraftingResultSlot(itemToCraft);
    }

    void UpdateCraftingResultSlot(Item itemToCraft)
    {
        craftResultSlot.UpdateItem(itemToCraft);
    }
}
