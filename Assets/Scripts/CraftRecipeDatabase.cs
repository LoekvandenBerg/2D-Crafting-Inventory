using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CraftRecipeDatabase : MonoBehaviour
{
    public List<CraftRecipe> recipes;
    private ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = GetComponent<ItemDatabase>();
        BuildCraftRecipeDatabase();
    }

    public Item CheckRecipe(int[] recipe)
    {
        foreach (CraftRecipe craftRecipe in recipes)
        {
            if (craftRecipe.requiredItems.SequenceEqual(recipe))
            {
                return itemDatabase.GetItem(craftRecipe.itemToCraft);
            }
        }
        return null;
    }

    void BuildCraftRecipeDatabase()
    {
        recipes = new List<CraftRecipe>()
        {
            new CraftRecipe(1,
            new int[]
            {
                5,2,2,
                5,0,2,
                5,0,0
            }),
            new CraftRecipe(3,
            new int[]
            {
                5,4,4,
                5,0,4,
                5,0,0
            }),
            new CraftRecipe(7,
            new int[]
            {
                0,0,6,
                6,6,0,
                6,6,0
            }),
        };
    }
}
