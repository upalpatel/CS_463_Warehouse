using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Warehouse : MonoBehaviour
{
    Gamemanager m_instance;
    public Text height;
    public Text width;
    public Text length;

    public void Start()
    {
        m_instance = Gamemanager._instance;
    }

    public void outputDimensions()
    {
        // parse height, width, length
        m_instance.warehouseHeight = Int32.Parse(height.text);
        m_instance.warehouseWidth = Int32.Parse(width.text);
        m_instance.warehouseLength = Int32.Parse(length.text);

        // define max capacity and used space(none at initialization)
        m_instance.capacity = m_instance.warehouseHeight * m_instance.warehouseWidth * m_instance.warehouseLength;
        m_instance.filledSpace = m_instance.capacity;

        // define range of 3d array
        m_instance.warehouse3D = new string[m_instance.warehouseHeight, m_instance.warehouseWidth, m_instance.warehouseLength];
        
        // intialize all elements to "" empty instead of null
        /* 
        for (int y = 0; y < m_instance.warehouse3D.GetLength(0); y++)
        {
            // x dimension
            for (int x = 0; x < m_instance.warehouse3D.GetLength(1); x++)
            {
                // z dimension
                for (int z = 0; z < m_instance.warehouse3D.GetLength(2); z++)
                {
                    m_instance.warehouse3D[y,x,z] = "";
                }
            }
        }*/
        // debug codes
        //Debug.Log(height.text);
        //Debug.Log(width.text);
        //Debug.Log(length.text);
    }
}
