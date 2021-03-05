using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SeatBeltScript : MonoBehaviour
{
    public Slider beltslider;
    public float slidervalue;
    // Start is called before the first frame update
    void Start()
    {
        beltslider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
       
        slidervalue = beltslider.GetComponent<Slider>().value;
        if (slidervalue == 1)
        {
           // Debug.Log("Hello");
            Application.LoadLevel("GamePlay");
        }
    }

    public void setSliderValue()
    {

        beltslider.value = beltslider.value + 0.05f;

    } 
}
