using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InventorySystem : MonoBehaviour
{
    public Dictionary<Enum, List<Item>> Items = new Dictionary<Enum, List<Item>>();
     List<Item> Rocks = new List<Item>();
    List<Item> Potions = new List<Item>();
    List<Item> Arrows = new List<Item>();
     public enum items
    {
        ROCKS, POTIONS, ARROWS
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Items.Add(items.ROCKS, Rocks);
        Items.Add(items.POTIONS, Potions);
        Items.Add(items.ARROWS, Arrows);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal")/10,0,0);//beweging
    }
    void OnTriggerEnter(Collider col)
    {
        print("collision");
        if (col.gameObject.GetComponent<Item>())
        {
            AddItem(col.gameObject.GetComponent<Item>());
        }
        
    }
    void AddItem(Item item)
    {
       
        
        switch (item.type)
        {
            case "Rock":
                {
                    Rocks.Add(item);
                    break;
                }
            case "Potion":
                {
                    Potions.Add(item);
                    break;
                }
            case "Arrow":
                {
                    Arrows.Add(item);
                    break;
                }
        }
        item.gameObject.SetActive(false);
       
    }
    
}
