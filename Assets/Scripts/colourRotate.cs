using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourRotate : MonoBehaviour
{
    
    // Map one range to another [x1, x2] -> [y1, y2] =
    // out = y1 + ((y2 - y1) / (x2 - x1)) * (in - x1)
    // out = 127.5 * in + 127.5

    // degrees = 360
    // rgb     = 255
    // input(degrees) * 0.6986 = output(rgb)
    private float map = 0.6986f;

    private MeshRenderer mr;

    private int count = 0;

    [SerializeField]
    int r = 0;
    [SerializeField]
    int g = 0;
    [SerializeField]
    int b = 0;


    private void Start()
    {
        mr = GetComponent<MeshRenderer>();

        gameObject.transform.rotation = new Quaternion(0.1f, -1.0f, 1.0f, 1);
        Debug.Log("XX");
       
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 100)
        {
            Quaternion rot = gameObject.transform.rotation;

            //mr.material.setcolor("_color", new color((int)(127.5 * rot.x + 127.5), (int)(127.5 * rot.y + 127.5), (int)(127.5 * rot.z + 127.5)));

            //mr.material.color = new Color(r, g, b);
            mr.material.SetColor("_EmissionColor", new Color(r, g, b));

            count = 0;
        }
    }
}
