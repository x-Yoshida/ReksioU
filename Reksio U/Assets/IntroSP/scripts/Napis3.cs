using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UIElements;

public class Napis3 : MonoBehaviour
{
    public bool nap3=false;
    public GameObject napis3;
    // Start is called before the first frame update


    public void CreateNapis3()
    {
        GameObject obj = Instantiate(napis3, new Vector2(0, 0), Quaternion.identity) as GameObject;
        nap3 = false;
    }
}
