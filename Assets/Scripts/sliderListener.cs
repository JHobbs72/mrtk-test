using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class sliderListener : MonoBehaviour
{
    [SerializeField]
    private PinchSlider sliderX;
    [SerializeField]
    private PinchSlider sliderY;
    [SerializeField]
    private PinchSlider sliderZ;
    [SerializeField]
    private GameObject pixelControl;

    private GameObject[] pixels;

    // Start is called before the first frame update
    void Start()
    {
        sliderX.SliderValue = 1; 
        sliderY.SliderValue = 1;
        sliderZ.SliderValue = 1;

        sliderX.OnValueUpdated.AddListener(delegate { ValueChangeX(); });
        sliderY.OnValueUpdated.AddListener(delegate { ValueChangeY(); });
        sliderZ.OnValueUpdated.AddListener(delegate { ValueChangeZ(); });

        pixels = GameObject.FindGameObjectsWithTag("pixels");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ValueChangeX()
    {
        updateVals(sliderX.SliderValue, sliderY.SliderValue, sliderZ.SliderValue);
    }

    private void ValueChangeY()
    {
        updateVals(sliderX.SliderValue, sliderY.SliderValue, sliderZ.SliderValue);
    }
    private void ValueChangeZ()
    {
        updateVals(sliderX.SliderValue, sliderY.SliderValue, sliderZ.SliderValue);
    }

    private void updateVals(float x, float y, float z)
    {
        foreach (GameObject p in pixels)
        {
            p.GetComponent<takePlaneValues>().setVisible(new Vector3(x, y, z));
        }
    }
}
