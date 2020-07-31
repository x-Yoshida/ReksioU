using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Napis1Move : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        DestroyObjectDelayed();

    }


// Update is called once per frame
    void Update()
    {

      
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        

    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 7);
    }


}
