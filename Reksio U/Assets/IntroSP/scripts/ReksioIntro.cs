using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReksioIntro : MonoBehaviour
{
    public AudioSource dzwiek1;
    public AudioSource dzwiek2;
    public AudioSource dzwiek3;
    public GameObject NapisReksio;
    public ReksioNapis reksioNapis;
    public Animator anim;


    void Dzwiek1Play()
    {

        dzwiek1.Play(0);
        
    }
    void Dzwiek2Play()
    {

        dzwiek2.Play(0);

    }
    void Dzwiek3Play()
    {

        dzwiek3.Play(0);

    }

    void SpawnNapis()
    {

        GameObject napis = Instantiate(NapisReksio, new Vector2(16, 0), Quaternion.identity) as GameObject;

    }
    void Movenapis()
    {

        reksioNapis.move1 = true;

    }

    void StopAnimation()
    {

        anim.enabled = false;

    }


}
