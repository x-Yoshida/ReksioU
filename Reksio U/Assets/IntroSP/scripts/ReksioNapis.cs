using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ReksioNapis : MonoBehaviour
{

    ///float czas = 0.05f;
    public bool move1 = false;

    float t;
    Vector2 startPosition;
    public Vector2 target;
    public float timeToReachTarget =2.06f;
    void Start()
    {
        startPosition = transform.position;
        Debug.Log(transform.position);
    }
    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        transform.position = Vector2.Lerp(startPosition, target, t);

    }

    public void SetDestination(Vector2 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }

    /*
    void MoveNapis2()
    {

        float xpos = 11.75f;
        position.x = xpos;
        transform.position = position;
        move2 = false;
        move3 = true;
        Debug.Log(transform.position);

        czas = 0.06f;
    }
    void MoveNapis3() 
    { 
    
    
    
    }
    */

}
