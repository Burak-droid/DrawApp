using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Draw;

    public class ColorView : MonoBehaviour
    {
        public Button button;

        private bool isopen = false;

        //open the slider when clicking button

        public void ClickButton()
        {
            isopen = !isopen;
            button.gameObject.SetActive(isopen);
    }
    }

