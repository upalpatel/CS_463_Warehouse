using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Item
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Quantity { get; set; }

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
    public List<Item> itemList = new List<Item>();
    public int warehouseHeight, warehouseWidth, warehouseLength;
    public int capacity;
    public int filledSpace;
    public string[,,] warehouse3D;

    // keep open as singleton
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
        // warehouse = height, width, length
        bool candidateInserted = false;
        // y dimension
        for (int y = 0; y < warehouse3D.GetLength(0); y++)
        {
            // x dimension
            for (int x = 0; x < warehouse3D.GetLength(1); x++)
            {
                // z dimension
                for (int z = 0; z < warehouse3D.GetLength(2); z++)
                {
                    // check if space is empty and candidate no inserted, else skip it
                    if (warehouse3D[x, y, z] == null && candidateInserted == false)
                    {
                        // check if it fits the range
                        if (
                            itemToAdd.Height + y <= warehouse3D.GetLength(1) &&
                            itemToAdd.Width + x <= warehouse3D.GetLength(0) &&
                            itemToAdd.Length + z <= warehouse3D.GetLength(2))
                        {
                            // check valid candidate
                            bool candidate = true;
                            // get candidate position height
                            for (int h = y; h < y + itemToAdd.Height; h++)
                            {
                                for (int i = x; i < x + itemToAdd.Width; i++)
                                {
                                    for (int j = z; j < z + itemToAdd.Length; j++)
                                    {
                                        // check if position IS NOT empty, bool false
                                        if (warehouse3D[h, i, j] != null)
                                        // if (warehouse3D[h, i, j].CompareTo("") != 0)
                                        {
                                            candidate = false;
                                        }
                                    }
                                }
                            }

                            // define candidate space if true
                            if (candidate)
                            {
                                for (int h = y; h < y + itemToAdd.Height; h++)
                                {
                                    for (int i = x; i < x + itemToAdd.Width; i++)
                                    {
                                        for (int j = z; j < z + itemToAdd.Length; j++)
                                        {
                                            // fill position with valid candidate name
                                            warehouse3D[h, i, j] = itemToAdd.Name;
                                        }
                                    }
                                }
                                // unflag candidate to prevent further insertion
                                candidateInserted = true;
                            }
                        }

                    }
                }
            }
        }
        // only append data and capacity if inserted
        if (candidateInserted == true)
        {
            // add to list of items
            itemList.Add(itemToAdd);
            // subtract used space from filledspace
            filledSpace -= itemToAdd.Height * itemToAdd.Width * itemToAdd.Length;
        }

    }

    public void debugWarehouse3D()
    {
        for (int y = 0; y < warehouse3D.GetLength(0); y++)
        {
            // x dimension
            for (int x = 0; x < warehouse3D.GetLength(1); x++)
            {
                // z dimension
                for (int z = 0; z < warehouse3D.GetLength(2); z++)
                {
                    Debug.Log("[" + y + "][" + x + "][" + z + "]: " + warehouse3D[y, x, z]);
                }
            }
        }
    }

    public void debugItemList()
    {
        foreach (Item iter in itemList)
        {
            Debug.Log("Name: " + iter.Name + ", Quantity: " + iter.Quantity + ", Height: "
            + iter.Height + ", Width: " + iter.Width + ", Length: " + iter.Length);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
