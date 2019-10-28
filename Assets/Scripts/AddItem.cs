using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    Gamemanager m_instance = Gamemanager._instance;
    public Text name;
    public Text quantity;
    public Text height;
    public Text width;
    public Text length;

    public void addItem()
    {
        Item myItem = new Item(name.text, Int32.Parse(quantity.text), 
        Int32.Parse(height.text), Int32.Parse(width.text), Int32.Parse(length.text));
        m_instance.addItemToList(myItem);
    }
}
