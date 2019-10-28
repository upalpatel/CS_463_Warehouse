using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderWarehouse : MonoBehaviour
{
    public GameObject cubePrefab;
    private Gamemanager m_instance;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        m_instance = Gamemanager._instance;
        position = gameObject.transform.position;
    }

    public void renderWarehouse()
    {
        for (int y = 0; y < m_instance.warehouse3D.GetLength(0); y++)
        {
            // x dimension
            for (int x = 0; x < m_instance.warehouse3D.GetLength(1); x++)
            {
                // z dimension
                for (int z = 0; z < m_instance.warehouse3D.GetLength(2); z++)
                {
                    // check for non-empty
                    if (m_instance.warehouse3D[y,x,z] != null)
                    {
                        GameObject clone;
                        clone = Instantiate(cubePrefab, new Vector3(position.x+(1f*y),
                    position.y+(1f*x), position.z+(1f*z)),transform.rotation);
                        clone.name = m_instance.warehouse3D[y,x,z];
                    }
                 }
            }
        }
        
    }
}
