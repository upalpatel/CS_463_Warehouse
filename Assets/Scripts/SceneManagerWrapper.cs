using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerWrapper : MonoBehaviour
{
    // loads scene at scene index, singular
    /*
    0_Start
    1_Warehouse Sizing
    2_Item Design
    3_Item List
    4_Warehouse Plan
     */
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
}
