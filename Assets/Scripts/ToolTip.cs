using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    private Text toolTipText;

    // Start is called before the first frame update
    void Start()
    {
        toolTipText = GetComponentInChildren<Text>();
        gameObject.SetActive(false);
    }

    public void GenerateToolTip(Item item)
    {
        string statText = "";
        foreach(var stat in item.stats)
        {
            statText += "\n" + stat.Key.ToString() + ": " + stat.Value;
        }
        string toolTip = string.Format("<b>{0}</b>\n{1}\n{2}", item.title, item.description, statText);
        toolTipText.text = toolTip;
        gameObject.SetActive(true);
    }        
}
