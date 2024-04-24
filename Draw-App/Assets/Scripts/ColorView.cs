using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Draw;

    public class ColorView : MonoBehaviour
    {

    public DrawController drawController;

    void Start()
    {
        drawController.LineColor = Color.black; // Başlangıçta siyah renk seçili
    }

    // Butona bağlı fonksiyon.
    public void ChangeColorToGreen() 
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = Color.green;
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }
    public void ChangeColorToRed()
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = Color.red;
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }
    public void ChangeColorToBlack()
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = Color.black;
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }
    public void ChangeColorToBlue()
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = Color.blue;
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }
    public void ChangeColorToPurple()
    {
        if (drawController.GetCurrentRenderer() != null)
        {
            drawController.LineColor = new Color(0.5f, 0, 0.5f, 1);
            drawController.GetCurrentRenderer().startColor = drawController.LineColor;
            drawController.GetCurrentRenderer().endColor = drawController.LineColor;
        }
    }

}


