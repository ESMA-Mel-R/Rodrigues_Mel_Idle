using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public Getpoints Gp;
    private bool active;

    void Start()
    {
        active = false;
    }

    void Update()
    {
        if (active)
        {
            StartCoroutine(Boost());
            active = false;
        }
    }

    public void Activate()
    {
        active = true;
    }

    IEnumerator Boost()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(5);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
