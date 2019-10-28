using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItems : MonoBehaviour
{
    Gamemanager m_instance;
    public Text listField;
    public Text capacity;

    public void Start()
    {
        m_instance = Gamemanager._instance;

        if (m_instance.itemList.Count == 0)
        {
            // do nothing
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
