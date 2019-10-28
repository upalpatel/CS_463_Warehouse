using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item
{
    public string Name {get; set;}
    public int Height {get; set;}
    public int Width {get; set;}
    public int Length {get; set;}
    public int Quantity {get; set;}

    public Item(string name, int height, int width, int length, int quantity)
    {
        Name = name;
        Height = height;
        Width = width;
        Length = length;
        Quantity = quantity;
    }
}

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager _instance;
    List<Item> itemList = new List<Item>(); 
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } 
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(_instance);
    }

    public void addItemToList(Item itemToAdd)
    {
        itemList.Add(itemToAdd);
    }

    public void debugItemList()
    {
        foreach (Item iter in itemList)
        {
            Debug.Log(iter.Name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
