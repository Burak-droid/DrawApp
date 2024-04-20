using Draw;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erase : MonoBehaviour
{
    public DrawController drawController;

    public void UseEraser()
    {
        LineRenderer currentRenderer = drawController.GetCurrentRenderer();
        if (currentRenderer != null)
        {
            Destroy(currentRenderer.gameObject);     
        }
    }

}
