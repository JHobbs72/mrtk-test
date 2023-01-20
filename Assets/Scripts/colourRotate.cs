using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourRotate : MonoBehaviour
{
    
    // Map one range to another [x1, x2] -> [y1, y2] =
    // out = y1 + ((y2 - y1) / (x2 - x1)) * (in - x1)
    // out = 127.5 * in + 127.5

    private MeshRenderer mr;

    private int count = 0;

    [SerializeField]
    float r = 0;
    [SerializeField]
    float g = 0;
    [SerializeField]
    float b = 0;


    private void Start()
    {
        mr = GetComponent<MeshRenderer>();

        gameObject.transform.rotation = new Quaternion(0.1f, -1.0f, 1.0f, 1);
        Debug.Log("XX");
       
    }

    // Update is called once per frame
    //void Update()
    //{
    //    count++;
    //    if (count >= 100)
    //    {
    //        Quaternion rot = gameObject.transform.rotation;

    //        mr.material.SetColor("_Color", new Color((float)(0.5 * rot.x + 0.5), (float)(0.5 * rot.y + 0.5), (float)(0.5 * rot.z + 0.5)));

    //        //mr.material.SetColor("_Color", new Color(r, g, b, 1.0f));

    //        count = 0;
    //    }
    //}
}
