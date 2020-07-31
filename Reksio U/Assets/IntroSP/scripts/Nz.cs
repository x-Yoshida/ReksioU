using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nz : MonoBehaviour
{
    public float czas;
    // Start is called before the first frame update
    public GameObject napis3;
    public GameObject Reksio;
  
    void Update()
    {
        czas -= Time.deltaTime;
        Del();
    }

    // Update is called once per frame
    void Del()
    {
        if (czas < 0)
        {
            GameObject reksio=Instantiate(Reksio, new Vector2(0, 0),Quaternion.identity) as GameObject;
            GameObject.Destroy(napis3, 0);

        }
    }
}
