using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TripleInput : MonoBehaviour
{
    public Text field1;
    public Text field2;
    public Text field3;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void outputDimensions()
    {
        Debug.Log(field1.text);
        Debug.Log(field2.text);
        Debug.Log(field3.text);
    }
}
