using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Inner cube to maintain the same position and rotation as outer cube but cubes should scale independently
    
    [SerializeField]
    private GameObject outer;

    private int count = 0;

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 100)
        {
            gameObject.transform.position = outer.transform.position;

            gameObject.transform.rotation = outer.transform.rotation;

            count = 0;
        }
    }
}
