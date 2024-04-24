using Draw;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erase : MonoBehaviour
{
    public DrawController drawController;

    void Start()
    {
        drawController.LineColor = Color.white; //White color is initially selected
       
    }

    // Function depends on button
    public void ChangeColorToWhite()
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = Color.white;
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }

}
