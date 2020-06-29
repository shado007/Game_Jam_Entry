using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxInsanity(float insanity)
    {
        slider.maxValue = insanity;
        slider.value = 0f;
    }
    
    public void SetInsanity(float insanity)
    {
        slider.value = insanity;
    }
}
