using Draw;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderView : MonoBehaviour
{
    public Slider slider;
    public DrawController drawController;
   
    private void Start()
    {
        drawController.StartWidth = 0.1f;
        slider.value = drawController.StartWidth;
        // Slider'ın değeri değiştiğinde HandleSliderValueChanged metodunun çağrılmasını sağlar
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
        slider.onValueChanged.AddListener(UpdateLineWidth);

    }

    private void HandleSliderValueChanged(float value)
    {
        drawController.StartWidth = value;
    }

    private void UpdateLineWidth(float value)
    {
        // Şu anda çizilen çizginin kalınlığını günceller
        if (drawController.GetCurrentRenderer() != null)
        {
            
            drawController.GetCurrentRenderer().endWidth = drawController.StartWidth;
            drawController.GetCurrentRenderer().startWidth = drawController.StartWidth; 
        }
    }
  
}
