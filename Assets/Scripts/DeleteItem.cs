using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteItem : MonoBehaviour
{
    Gamemanager m_instance;
    public Text itemName;
    public Text listField;
    public Text capacity;

    public void Awake()
    {
        m_instance = Gamemanager._instance;
    }

    // Start is called before the first f(rame update
    void Start()
    {}
    
    public void Delete()
    {
        m_instance.DeleteItemFrom3D(itemName.text);

        
        if (m_instance.itemList.Count == 0)
        {
            listField.text = "List of Items here...";
        }
        else
        {
            listField.text = "";
            foreach (Item iter in m_instance.itemList)
            {
                //Debug.Log("Name: " + iter.Name + ", Quantity: " + iter.Quantity + ", Height: "
                //+ iter.Height + ", Width: " + iter.Width + ", Length: " + iter.Length);
                listField.text += "Name: " + iter.Name + ", Quantity: " + iter.Quantity + ", Height: "
                + iter.Height + ", Width: " + iter.Width + ", Length: " + iter.Length + "\n";
            }
        }
        capacity.text = m_instance.filledSpace + "/" + m_instance.capacity;
    }

}
