using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public Autoclick Ac;
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
        Ac._gain = Ac._gain * 2;
        Gp._addScore = Gp._addScore * 2;
        yield return new WaitForSeconds(5);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
