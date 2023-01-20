using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPixels : MonoBehaviour
{

    [SerializeField]
    GameObject pixelPrefab;


    // Start is called before the first frame update
    void Start()
    {
        for (float y = -1f; y < -0.6; y = y + 0.1f)
        {
            for (float x = 3; x < 5; x = x + 0.1f)
            {
                for (float z = 1; z < 5; z = z + 0.1f)
                {
                    GameObject p = Instantiate(pixelPrefab, new Vector3(x, y, z), Quaternion.identity);
                    p.transform.parent = gameObject.transform;
                    p.GetComponent<Renderer>().material.color = new Color(0.5f*x-1.5f, 2.5f*y+2.5f, 0.25f*z-0.25f, 1f);
                    p.GetComponent<takePlaneValues>().planeValues(x, y, z);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
