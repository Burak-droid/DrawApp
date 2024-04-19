using Draw;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderView : MonoBehaviour
{
    public Slider slider;
    public DrawController drawController; // DrawController nesnesi bu script üzerinden atanacak

    private void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged); // Slider'ın değeri değiştiğinde çağrılacak metod
    }

    private void OnSliderValueChanged(float value)
    {
        drawController.StartWidth = value; // Slider'ın değerine göre DrawController'daki startWidth güncelleniyor
    }

    private bool isopen = false;

    //open the slider when clicking button

    public void ClickButton()
    {
        isopen = !isopen;
        slider.gameObject.SetActive(isopen);
    }


}
