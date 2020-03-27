using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class DisplayItems : MonoBehaviour
{
    public Text t;
    InventorySystem iSyst;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "";
        iSyst = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
        foreach(KeyValuePair<Enum,List<Item>> lists in iSyst.Items)
        {
            t.text += lists.Key.ToString() + ": " + lists.Value.Count.ToString() + "\n";
        }
        
    }
}
