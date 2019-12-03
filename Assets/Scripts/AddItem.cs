using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    Gamemanager m_instance;
    public Text itemName;
    public Text quantity;
    public Text height;
    public Text width;
    public Text length;
    public Text space;
    public GameObject fail;

    public void Awake()
    {
        m_instance = Gamemanager._instance;
    }

    public void Start()
    {
        space.text = m_instance.filledSpace + "/" + m_instance.capacity;
    }

    public void addItem()
    {
        //Debug.Log(itemName.text);
        //Debug.Log(Int32.Parse(quantity.text));
        Item myItem = new Item(itemName.text, Int32.Parse(height.text),
        Int32.Parse(width.text), Int32.Parse(length.text), Int32.Parse(quantity.text));

        if (Gamemanager._instance.filledSpace - myItem.Height * myItem.Width * myItem.Length > 0)
        {
            m_instance.addItemToList(myItem);
            space.text = m_instance.filledSpace + "/" + m_instance.capacity;
        }
        else
        {
            Debug.Log("Failed to add item");
            StartCoroutine(failText());
        }
    }

    IEnumerator failText()
    {
        fail.SetActive(true);
        yield return new WaitForSeconds(5);
        fail.SetActive(false);
    }

    // remaining space in defined warehouse
    public int remainingSpace()
    {
        //**CHANGE LOCATION OF THESE VARS LATER** 

        //Initialize variables for Warehouse
        int total_WarehouseSize = 0;
        int remaining_WarehouseSpace = 0;

        //Initialize variables for items
        int itemSize_x = 0;
        int itemSize_y = 0;
        int itemSize_z = 0;

        //**TAKE USER INPUT FOR ABOVE VARIABLES AND STORE INPUT HERE ** 

        //Calculates an item's total size
        int total_itemSize = (itemSize_x * itemSize_y * itemSize_z);


        //Checks if there is remaining space in warehouse
        //If theres remaining space, add item and subtract item size from the total
        //If remaining space is 0 or less than an item size, output error message

        if (remaining_WarehouseSpace > 0)
        {
            //addItem();
            remaining_WarehouseSpace = (total_WarehouseSize - total_itemSize);
        }

        else if (remaining_WarehouseSpace == 0)
        {
            //OUTPUT MESSAGE ON GUI BUT FOR NOW 
            Console.WriteLine("There is no more space in your warehouse");
        }
        else if (remaining_WarehouseSpace < total_itemSize)
        {
            //OUTPUT MESSAGE ON GUI BUT FOR NOW 
            Console.WriteLine("ERROR: Not enough space in warehouse to store item, please try a different item");
        }

        return remaining_WarehouseSpace;
    }

    public void debugItemList()
    {
        m_instance.debugItemList();
    }

    public void debugListDebugWarehouse3D()
    {
        m_instance.debugWarehouse3D();
    }
}
