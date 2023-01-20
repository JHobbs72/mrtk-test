using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class scaleOnSlide : MonoBehaviour
{

    [SerializeField]
    private PinchSlider sliderX;

    [SerializeField]
    private PinchSlider sliderY;

    private float scaleX;
    private float scaleY;

    private GameObject childOne;
    private GameObject childTwo;
    private GameObject childThree;
    private GameObject childFour;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;

        if (sliderX == null)
        {
            sliderX = new PinchSlider();
        }

        childOne = gameObject.GetNamedChild("one");
        childTwo = gameObject.GetNamedChild("two");
        childThree = gameObject.GetNamedChild("three");
        childFour = gameObject.GetNamedChild("four");

        sliderX.OnValueUpdated.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValueChangeCheck()
    {
        Debug.Log("x");

        switch (sliderX.SliderValue)
        {
            case 0f:

                childOne.SetActive(false);
                childTwo.SetActive(false);
                childThree.SetActive(false);
                childFour.SetActive(false);

                break;

            case 0.25f:

                childOne.SetActive(true);
                childTwo.SetActive(false);
                childThree.SetActive(false);
                childFour.SetActive(false);

                break;

            case 0.5f:

                childOne.SetActive(true);
                childTwo.SetActive(true);
                childThree.SetActive(false);
                childFour.SetActive(false);

                break;

            case 0.75f:

                childOne.SetActive(true);
                childTwo.SetActive(true);
                childThree.SetActive(true);
                childFour.SetActive(false);

                break;

            case 1.0f:

                childOne.SetActive(true);
                childTwo.SetActive(true);
                childThree.SetActive(true);
                childFour.SetActive(true);

                break;
        }
    }
}
