using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourRotate : MonoBehaviour
{
    
    // degrees = 360
    // rgb     = 255
    // input(degrees) * 0.6986 = output(rgb)
    private float map = 0.6986f;

    private MeshRenderer mr;

    private int count = 0;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 80)
        {
            Quaternion rot = transform.rotation;
            Vector3 currentRotationAngles = rot.eulerAngles;
            //Debug.Log(currentRotationAngles.ToString());

            mr.material.SetColor("_Color", new Color((int)currentRotationAngles.x * map, (int)currentRotationAngles.y * map, (int)currentRotationAngles.z * map));

            count = 0;
        }
    }
}
