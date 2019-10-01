using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScripts : MonoBehaviour
{
    public Text field1;
    public Text field2;
    public Text field3;
    public GameObject cube;

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

    // realtime item deformation
    public void Update()
    {

        // width
        if (field1.text != "")
        {
            int num1 = int.Parse(field1.text);
            cube.transform.localScale = new Vector3(num1,cube.transform.localScale.y, cube.transform.localScale.z);
        }
        // height
        if (field2.text != "")
        {
            int num2 = int.Parse(field2.text);
            cube.transform.localScale = new Vector3(cube.transform.localScale.x,num2, cube.transform.localScale.z);
        }
        // length
        if (field3.text != "")
        {
            int num3 = int.Parse(field3.text);
            cube.transform.localScale = new Vector3(cube.transform.localScale.x,cube.transform.localScale.y, num3);
        }
    }
}
