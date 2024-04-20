using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Draw
{
    public class DrawController : MonoBehaviour
    {
        private LineRenderer currentRenderer;
        private List<Vector2> touchPos = new List<Vector2>();
        private float startWidth;
        private Color lineColor;
      

        public float StartWidth
        {
            get { return startWidth; }
            set { startWidth = value; }
        }

        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        public LineRenderer currentRender
        {
            get { return currentRender; }
            set { currentRender = value; }
        }




        public LineRenderer GetCurrentRenderer()
        {
            return currentRenderer;
        }


        void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                if (touch.phase == TouchPhase.Began)
                {
                    CreateNewLine(touchPosition);
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    touchPos.Add(touchPosition);
                    currentRenderer.positionCount = touchPos.Count;
                    currentRenderer.SetPosition(touchPos.Count - 1, touchPosition);
                }
            }
        }
       


        private void CreateNewLine(Vector2 lineStartPosition)
        {
            GameObject newLine = new GameObject("Line");
            currentRenderer = newLine.AddComponent<LineRenderer>();
            currentRenderer.material = new Material(Shader.Find("Sprites/Default"));

            currentRenderer.startWidth = 0.1f;
            currentRenderer.endWidth = 0.1f;
            currentRenderer.useWorldSpace = true;
            currentRenderer.positionCount = 1;
            currentRenderer.SetPosition(0, lineStartPosition);

            currentRenderer.startColor = Color.black;
            currentRenderer.endColor = Color.black;


            currentRenderer.startWidth = StartWidth;
            currentRenderer.endWidth = StartWidth;

            currentRenderer.startColor = LineColor;
            currentRenderer.endColor = LineColor;

            touchPos.Clear();
            touchPos.Add(lineStartPosition);
        }
    }
    
}

