using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takePlaneValues : MonoBehaviour
{
    [SerializeField]
    private float thisx;
    [SerializeField]
    private float thisy;
    [SerializeField]
    private float thisz;

    public void planeValues(float x, float y, float z)
    {
        thisx = x;
        thisy = y;
        thisz = z;
    }

    public void setVisible(Vector3 visible)
    {
        if (thisx >= visible.x && thisy >= visible.y && thisz >= visible.z)
        {
            gameObject.GetComponent<MeshRenderer>().enabled= true;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
