using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMove : MonoBehaviour
{
    float t;
    Vector2 startPosition;
    public Vector2 target;
    public float timeToReachTarget;
    public Napis3 createnapis;
    public Animator anim;

    void Start()
    {
        startPosition = transform.position;
        DestroyObjectDelayed();
        Invoke("CreateNapis3", timeToReachTarget-0.001f);
        Invoke("StopAnimation", timeToReachTarget);
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
    void DestroyObjectDelayed()
    {
        Destroy(gameObject, timeToReachTarget + (float).74);
    }
    void CreateNapis3()
    {
        createnapis.CreateNapis3();
    }

    void StopAnimation()
    {

        anim.enabled = false;

    }


}
