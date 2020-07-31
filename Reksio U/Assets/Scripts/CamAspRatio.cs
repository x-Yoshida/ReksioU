using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class CamAspRatio : MonoBehaviour
{


    public float x = 4.0f;
    public float y = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Proporcje obrazu docelowe
        float targetaspect = x / y;
        //Proporcje okna
        float windowaspect = (float)Screen.width / (float)Screen.height;
        
        float scaleheight = windowaspect / targetaspect;

        Camera camera = GetComponent<Camera>();

        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;
            Debug.Log(rect);
            rect.width = 1.0f;
            rect.height = scaleheight;
            Debug.Log(rect);
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;
            Debug.Log(rect);

            camera.rect = rect;

        }
        else
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;
            Debug.Log(rect);
            rect.width = scalewidth;
            rect.height = 1.0f;
            Debug.Log(rect);
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;
            Debug.Log(rect);

            camera.rect = rect;
        }
    }

    // Update is called once per frame
  
}
